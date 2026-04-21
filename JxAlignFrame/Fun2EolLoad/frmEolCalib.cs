using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base;
using Modules;
using Alignlib;
using static JxAlignVision.Static;
using System.Threading;
using Sunny.UI;

namespace JxAlignVision
{
    public partial class frmEolCalib : UIForm
    {
        public List<ECoord> MoveRobList = new List<ECoord>();
        public List<ECoord> MoveImgList = new List<ECoord>();

        public List<ECoord> RotateRobList = new List<ECoord>();
        public List<ECoord> RotateImgList = new List<ECoord>();

        List<string> testRotateResult = new List<string>();
        List<double> diff_rxs = new List<double>();
        List<double> diff_rys = new List<double>();

        //ModCCDMV _ccd;
        BaseHikCamera _mcam;
        MyVision _mvision;
        CfgEolCCDCalib _mcalib;
        string _mccdnum;

        public frmEolCalib(BaseHikCamera _cam, MyVision _vision, CfgEolCCDCalib _calib, string _ccdnum)
        {
            InitializeComponent();
            _mcam = _cam;
            _mvision = _vision;
            _mcalib = _calib;
            _mccdnum = _ccdnum;

            _mcam.OnNewImage += Cam_OnNewImage;
            //_ccd = new ModCCDMV();
            //_ccd.Open();

            lb_mat.Text = _mcalib.MatCamera.ToString();
            this.Text = "Cam" + _ccdnum + "标定";
        }

        private void Frm_Calib_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModLogger.Record(() => {
                _mcalib.Save();
                Config.App.Save();
            });
        }

        private void Cam_OnNewImage(Cognex.VisionPro.CogImage8Grey obj)
        {
            if (ckb_AutoGrabbing.Checked)
            {
                cogDisplay1.Record = null;
                cogDisplay1.Image = obj;
            }
        }

        ECoord RunVpp()
        {
            var img = _mcam.GetNewImage();
            cogDisplay1.Invoke(new Action(() => {
                cogDisplay1.Image = img;
            }));
            ECoord pos = _mvision.GetCalibCurrVisionPt(img);
            cogDisplay1.Invoke(new Action(() => {
                cogDisplay1.Record = _mvision.GetRecord();
            }));
            return pos.Clone();
        }

        private void btn_RunVpp_Click(object sender, EventArgs e)
        {
            ModLogger.Operate($"Cam{_mccdnum}-运行标定VPP", () => {
                var pos = RunVpp();
                var robpt = Device.EolLoadPlc.GetPlcCurPosCoord;
                var img2robpt = robpt.ToolUsed(_mcalib.MatCamera.TransformCoord(pos));
                lb_img2robpos.Text = img2robpt.ToString();
                lb_imagepos.Text = pos.ToString();
            });
        }

        private void btn_EditVpp_Click(object sender, EventArgs e)
        {
            ModLogger.Operate($"Cam{_mccdnum}-修改标定VPP", () => {
                _mvision.Edit();
            });
        }

        private void btn_Calib_Click(object sender, EventArgs e)
        {
            ModLogger.Operate($"Cam{_mccdnum}-标定", () => {
                if (!CheckDevice())
                {
                    MessageBox.Show("硬件设备已断开");
                    return;
                }
                splitContainer1.Panel1.Enabled = false;
                ModLogger.RecordThread(() => {
                    try
                    {
                        double dx = (double)nud_dx.Value;
                        double dy = (double)nud_dy.Value;
                        double dr = (double)nud_dr.Value;
                        double verify_limit_r = (double)nud_verify_limitr.Value;
                        double verify_dr = (double)nud_verify_dr.Value;
                        int delaytime = (int)nud_delay.Value;
                        double pix = (double)nud_pix.Value / 1000.0;
                        double iteration = (double)nud_iteration.Value;
                        GetData(dx, dy, dr, delaytime);
                        Calib(pix, iteration);
                        Verify(verify_limit_r, verify_dr, delaytime);
                        SaveCalibResultData2CSV();
                        this.Invoke(new Action(() => {
                            MessageBox.Show("标定完成");
                            splitContainer1.Panel1.Enabled = true;
                        }));
                    }
                    catch(Exception ex)
                    {
                        this.Invoke(new Action(() => {
                            MessageBox.Show("标定失败：" + ex.Message);
                            splitContainer1.Panel1.Enabled = true;
                        }));
                    }
                });
            });
        }

        bool CheckDevice()
        {
            if (!Device.EolLoadPlc.IsOpen()) return false;
            if (!_mcam.IsOpen()) return false;
            return true;
        }

        void GetData(double step_x, double step_y, double step_r, int delaytime)
        {
            MoveRobList.Clear();
            MoveImgList.Clear();
            RotateRobList.Clear();
            RotateImgList.Clear();
            dataGridView1.Rows.Clear();

            //记录初始点位
            double x0, y0, r0;
            Device.EolLoadPlc.GetPlcCurPos(out x0, out y0, out r0);

            //生成Move点位
            for(double x = -step_x; x <= step_x; x += step_x)
            {
                for(double y = -step_y; y <= step_y; y += step_y)
                {
                    MoveRobList.Add(new ECoord(x0 + x, y0 + y, r0));
                    MoveImgList.Add(new ECoord());
                }
            }

            //生成Rotate点位
            for(double r = -2 * step_r; r <= 2 * step_r; r += step_r)
            {
                RotateRobList.Add(new ECoord(x0, y0, r0 + r));
                RotateImgList.Add(new ECoord());
            }

            //记录Move点位信息
            for(int i = 0; i < MoveRobList.Count; i++)
            {
                Device.EolLoadPlc.MovePlcPosCoord = MoveRobList[i];
                Thread.Sleep(delaytime);
                MoveImgList[i] = RunVpp();
                AppendRow($"Move{i}", MoveRobList[i], MoveImgList[i]);
                
            }

            Device.EolLoadPlc.MovePlcPos(x0, y0, r0, true);
            Thread.Sleep(delaytime);
            RunVpp();

            for(int i = 0; i < RotateRobList.Count; i++)
            {
                Device.EolLoadPlc.MovePlcPosCoord = RotateRobList[i];
                Thread.Sleep(delaytime);
                RotateImgList[i] = RunVpp();
                AppendRow($"Rotate{i}", RotateRobList[i], RotateImgList[i]);
            }

            Device.EolLoadPlc.MovePlcPos(x0, y0, r0, true);
            Thread.Sleep(delaytime);
            RunVpp();
        }

        void AppendRow(string name, ECoord rob, ECoord cam)
        {
            dataGridView1.Invoke(new Action(() => {
                dataGridView1.Rows.Add(
                    name,
                    rob.X.ToString("0.000"),
                    rob.Y.ToString("0.000"),
                    rob.R.ToString("0.000"),
                    cam.X.ToString("0.000"),
                    cam.Y.ToString("0.000"),
                    cam.R.ToString("0.000")
                    );
                this.dataGridView1.FirstDisplayedScrollingRowIndex = this.dataGridView1.Rows.Count - 1;
            }));
        }

        void Calib(double pix, double iteration)
        {
            //相机标定点
            var backupRobotPt = new ECoord(MoveRobList[MoveRobList.Count / 2].X,
                MoveRobList[MoveRobList.Count / 2].Y, MoveRobList[MoveRobList.Count / 2].R);

            var backupImgPt = new ECoord(MoveImgList[MoveImgList.Count / 2].X,
                MoveImgList[MoveImgList.Count / 2].Y, MoveImgList[MoveImgList.Count / 2].R);

            var robPts = MoveRobList.Select(p => new EPoint(p.X, p.Y)).ToList();
            var imgPts = MoveImgList.Select(p => new EPoint(p.X, p.Y)).ToList();
            imgPts = imgPts.Select(p => 2 * imgPts[imgPts.Count / 2] - p).ToList();

            //计算九点矩阵
            var m = AlignFunc.GetAffineMatrix(imgPts, robPts);

            //计算圆心
            var ro_img2rob = RotateImgList.Select(p => m.TransformPoint(new EPoint(p.X, p.Y))).ToList();
            var circle = AlignFunc.FitCircle(ro_img2rob);

            //修正工具角度误差
            //var ptRotateMid = m.TransformCoord(RotateImgList[RotateImgList.Count / 2]);

            //var pt2 = m.TransformCoord(RotateImgList[RotateImgList.Count / 2 - 1]);
            //var pt3 = m.TransformCoord(RotateImgList[RotateImgList.Count / 2]);
            //var pt4 = m.TransformCoord(RotateImgList[RotateImgList.Count / 2 + 1]);

            //var angle2 = Math.Atan2(pt2.Y - circle.CenterY, pt2.X - circle.CenterX) * 180d / Math.PI;
            //var angle3 = Math.Atan2(pt3.Y - circle.CenterY, pt3.X - circle.CenterX) * 180d / Math.PI;
            //var angle4 = Math.Atan2(pt4.Y - circle.CenterY, pt4.X - circle.CenterX) * 180d / Math.PI;

            //var scale1 = (angle3 - angle2)
            //     / (RotateRobList[RotateRobList.Count / 2].R
            //     - RotateRobList[RotateRobList.Count / 2 - 1].R);
            //var scale2 = (angle4 - angle3)
            //     / (RotateRobList[RotateRobList.Count / 2 + 1].R
            //     - RotateRobList[RotateRobList.Count / 2].R);
            //var scale = (scale1 + scale2) / 2d;

            //var ptcirclecenter = new EPoint(pt3.X - (circle.CenterX - pt3.X) * scale,
            //                                pt3.Y - (circle.CenterY - pt3.Y) * scale);
            //var tool = ptRotateMid.ToPoint() - ptcirclecenter;


            //计算旋转工具，带回九点，重新计算矩阵
            var tool = ro_img2rob[2] - circle.ToPoint();
            var TrobPts = MoveRobList.Select(p => new EPoint(p.X, p.Y) + tool).ToList();
            var m1 = AlignFunc.GetAffineMatrix(imgPts, TrobPts);

            //计算标定点到矩阵角点工具
            var m1tc = m1.TransformCoord(0, 0, 0);
            var tool1 = backupRobotPt.CalcTool(m1tc);

            //将矩阵旋转，平移置0；
            m1 = m1.RotateAt(m1tc.R, backupRobotPt.X, backupRobotPt.Y);
            m1.Dx = 0; m1.Dy = 0;
            
            int c = 0;
            //迭代计算提高精度
            for (c = 0; c < iteration; c++)
            {
                //提取点
                List<EPoint> tmpPts = new List<EPoint>();
                List<ECoord> ptTmps = new List<ECoord>();
                List<ECoord> ptTmp2s = new List<ECoord>();
                for (int i = 0; i < RotateImgList.Count; i++)
                {
                    var ptTmp = m1.TransformCoord(RotateImgList[i]);
                    ptTmps.Add(ptTmp);
                    var ptTmp2 = RotateRobList[i].ToolUsed(tool1).ToolUsed(ptTmp);
                    ptTmp2s.Add(ptTmp2);
                    tmpPts.Add(ptTmp2.ToPoint());
                }

                //工具标定
                var mCenter = AlignFunc.FitCircle(tmpPts);
                var cRobot0 = tmpPts[0];
                var mTool = cRobot0 - mCenter.ToPoint();

                if (Math.Abs(mTool.X) < pix && Math.Abs(mTool.Y) < pix)
                {
                    break;
                }
                //标定后处理
                //var pTarget = m1tc.Clone();
                //var pOffset = m1tc.ToolUndo(tool1) - backupRobotPt;
                //pTarget.X -= pOffset.X + mTool.X;
                //pTarget.Y -= pOffset.Y + mTool.Y;
                //var mOutput = backupRobotPt.CalcTool(pTarget);

                var tmp = ptTmp2s[0];
                tmp.X -= mTool.X;
                tmp.Y -= mTool.Y;
                tmp = tmp.ToolUndo(m1.TransformCoord(ptTmps[0]));
                var mOutput = RotateRobList[0].CalcTool(tmp);

                tool1 = mOutput;
            }

            //将tool工具整合进矩阵中
            m1 = tool1.ToMatrix().Multiply(m1);

            //保存数据
            _mcalib.MatCamera = m1;
            _mcalib.MatTool = m1.TransformCoord(RotateImgList[2]);
            _mcalib.Save();

            splitContainer1.Panel1.Invoke(new Action(() => {
                lb_mat.Text = m1.ToString();
                lb_c.ToString();
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var imgpt = RunVpp();
            var robpt = Device.EolLoadPlc.GetPlcCurPosCoord;
            var img2robpt = robpt.ToolUsed(_mcalib.MatCamera.TransformCoord(imgpt));
            tb_teach_imgpt.Text = imgpt.ToString();
            tb_teach_robpt.Text = robpt.ToString();
            tb_teach_img2rob.Text = img2robpt.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var robpt = Device.EolLoadPlc.GetPlcCurPosCoord;
            tb_teach_downpt.Text = robpt.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ECoord tool = new ECoord(tb_teach_downpt.Text).CalcTool(new ECoord(tb_teach_img2rob.Text));
            tb_teach_tool.Text = tool.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var imgpt = RunVpp();
            var robpt = Device.EolLoadPlc.GetPlcCurPosCoord;
            var img2robpt = robpt.ToolUsed(_mcalib.MatCamera.TransformCoord(imgpt));
            tb_run_img2rob.Text = img2robpt.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ECoord target = new ECoord(tb_run_img2rob.Text).ToolUndo(new ECoord(tb_teach_tool.Text));
            tb_run_movetarget.Text = target.ToString();
            Device.EolLoadPlc.MovePlcPosCoord = target;
        }

        void Verify(double limitr, double dr, int delaytme)
        {
            //参数
            double C_START = -limitr;
            double C_END = limitr;
            double C_STEP = dr;

            //检测目标点
            List<ECoord> testToolPts = new List<ECoord>();
            List<double> testToolAngles = new List<double>();

            //当前位置
            var backupPos_rob_origin = Device.EolLoadPlc.GetPlcCurPosCoord;
            var backupPos_img_origin = RunVpp();
            var tool = _mcalib.MatTool;

            for (double angle = C_START; angle <= C_END; angle += C_STEP)
            {
                var posTool1_new = backupPos_img_origin.Clone();
                posTool1_new.R += angle;
                posTool1_new = backupPos_rob_origin.ToolUsed(_mcalib.MatCamera.TransformCoord(posTool1_new));
                var posTool0_new = posTool1_new.ToolUndo(tool);

                testToolPts.Add(posTool0_new);
                testToolAngles.Add(angle);
            }


            //精度检测
            testRotateResult.Clear();
            diff_rxs.Clear();
            diff_rys.Clear();

            for (int i = 0; i < testToolPts.Count; i++)
            {
                Device.EolLoadPlc.MovePlcPosCoord = testToolPts[i];
                Thread.Sleep(delaytme); //延迟拍照
                double diff_x, diff_y;

                var imgpt = RunVpp();
                var img2rot = testToolPts[i].ToolUsed(_mcalib.MatCamera.TransformCoord(imgpt));
                var testpt = testToolPts[i].ToolUsed(tool);

                diff_x = (testpt.X - img2rot.X) * 1000;
                diff_y = (testpt.Y - img2rot.Y) * 1000;
                diff_rxs.Add(diff_x);
                diff_rys.Add(diff_y);
                if (imgpt != null)
                {
                    testRotateResult.Add($"Rotate[{i+1}],{testpt.X},{testpt.Y},{testpt.R},{img2rot.X},{img2rot.Y},{img2rot.R},{diff_x},{diff_y}");
                }
            }
            Device.EolLoadPlc.MovePlcPosCoord = backupPos_rob_origin;
            Thread.Sleep(delaytme);
            RunVpp();
        }

        void SaveCalibResultData2CSV()
        {
            string folder = Application.StartupPath + "/CalibResultData/" + $"Cam{_mccdnum}/";
            if(!System.IO.Directory.Exists(folder))
                System.IO.Directory.CreateDirectory(folder);
            string filename = $"Cam{_mccdnum}{DateTime.Now:_yyyy_MM_dd_HH_mm_ss}.csv";

            System.IO.File.Delete(folder + filename);

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(folder + filename, true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("======================================================");
                sw.WriteLine("-> 标定原始数据");
                sw.WriteLine("点位,RobX,RobY,RobR,ImgX,ImgY,ImgR");
                sw.WriteLine("");
                for (int i = 0; i < MoveRobList.Count; i++)
                {
                    sw.WriteLine($"Move[{i + 1}],{MoveRobList[i].X},{MoveRobList[i].Y},{MoveRobList[i].R},{MoveImgList[i].X},{MoveImgList[i].Y},{MoveImgList[i].R}");
                }
                sw.WriteLine("");
                for (int i = 0; i < RotateRobList.Count; i++)
                {
                    sw.WriteLine($"Rotate[{i + 1}],{RotateRobList[i].X},{RotateRobList[i].Y},{RotateRobList[i].R},{RotateImgList[i].X},{RotateImgList[i].Y},{RotateImgList[i].R}");
                }
                sw.WriteLine("");

                sw.WriteLine("======================================================");
                sw.WriteLine("-> 标定结果");
                sw.WriteLine($"MatCamera,{_mcalib.MatCamera.ToString().Replace("(", "").Replace(")", "")}");
                sw.WriteLine($"MatTool,{_mcalib.MatTool.ToString().Replace("(", "").Replace(")", "")}");
                sw.WriteLine("");

                sw.WriteLine("======================================================");
                sw.WriteLine("-> 精度分析");
                sw.WriteLine("点位,RobToolX,RobToolY,RobToolR,Img2RobX,Img2RobY,Img2RobR,Diff_x(um),Diff_Y(um)");
                for (int i = 0; i < testRotateResult.Count; i++)
                {
                    sw.WriteLine(testRotateResult[i]);
                }
                sw.WriteLine($",,,,,,最小值(um/deg),{diff_rxs.Min()}, {diff_rys.Min()}");
                sw.WriteLine($",,,,,,最大值(um/deg),{diff_rxs.Max()}, {diff_rys.Max()}");
                sw.WriteLine($",,,,,,极差(um/deg),{diff_rxs.Max() - diff_rxs.Min()}, {diff_rys.Max() - diff_rys.Min()}");
                sw.Close();

            }
        }

        private void Tab_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sf = new StringFormat();

            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            e.Graphics.FillRectangle(Brushes.White, Tab.Location.X, Tab.Location.Y, Tab.Width, Tab.Height);


            for (int i = 0; i < Tab.TabCount; i++)
            {
                Rectangle rec = Tab.GetTabRect(i);
                if (i == Tab.SelectedIndex)
                {
                    e.Graphics.DrawString(Tab.TabPages[i].Text, new Font("微软雅黑", 9), new SolidBrush(Color.Black), rec, sf);
                    float strlength = e.Graphics.MeasureString(Tab.TabPages[i].Text, new Font("微软雅黑", 9)).Width;
                    float drawpx = (rec.Width - strlength) / 2 + rec.X;
                    e.Graphics.DrawLine(new Pen(Color.Red), drawpx, 19, drawpx + strlength, 19);
                }
                else
                {
                    e.Graphics.DrawString(Tab.TabPages[i].Text, new Font("微软雅黑", 9), new SolidBrush(Color.FromArgb(0, 68, 130)), rec, sf);
                }
            }
        }
    }
}
