using Modules;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AlignVision.Static;

namespace AlignVision
{
    public partial class Frm_Device : UIForm
    {
        bool thread_run = true;
        public Frm_Device()
        {
            InitializeComponent();
        }

        private void Frm_Device_Load(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                if (Device.WpcCam1.IsOpen()) btn_ReadCam1Param_Click(null, null);
                Device.WpcCam1.OnNewImage += Cam1_OnNewImage;
                thread_run = true;
                ModLogger.RecordThread(() => { thread_plc(); });
            });
        }

        private void Frm_Device_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModLogger.Record(() => {
                thread_run = false;
                ckb_AutoCam1Grabbing.Checked = false;
                Thread.Sleep(100);
                Device.WpcCam1.OnNewImage -= Cam1_OnNewImage;
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ModLogger.Record(() => {

                //Plc打开状态
                bool plcisopen = Device.wpcReadCodeSignPlc.IsOpen();
                lb_PlcIsOpen.Text = plcisopen ? "已连接" : "已断开";
                lb_PlcIsOpen.ForeColor = plcisopen ? Color.Green : Color.Red;
                btn_PlcOpen.Enabled = !plcisopen;
                btn_PlcClose.Enabled = plcisopen;
                //panel_Plc_XYR.Enabled = panel_Plc_ProductAlign.Enabled = plcisopen;
                
                //相机打开状态
                Action<bool, UILabel, UIButton, UIButton, UIPanel, UICheckBox> SetCamStatu = (cameraIsOpen, lbCameraIsOpen, btnCameraOpen, btnCameraClose, panelCamParam, ckb) => {
                    lbCameraIsOpen.Text = cameraIsOpen ? "已连接" : "已断开";
                    lbCameraIsOpen.ForeColor = cameraIsOpen ? Color.Green : Color.Red;
                    btnCameraOpen.Enabled = !cameraIsOpen;
                    btnCameraClose.Enabled = cameraIsOpen;
                    ckb.Enabled = panelCamParam.Enabled = cameraIsOpen;
                };
                SetCamStatu(Device.WpcCam1.IsOpen(), lb_Cam1IsOpen, btn_Cam1Open, btn_Cam1Close, panel_Cam1Param, ckb_AutoCam1Grabbing);
                GC.Collect();
            });
        }
        void thread_plc()
        {
            while (thread_run)
            {
                Thread.Sleep(100);
                bool plcisopen = Device.wpcReadCodeSignPlc.IsOpen();
                if (!plcisopen) continue;
             
             }

                Action<Label, UITextBox, Label, int, int> SetIOStatu = (lb, tb, lbcomment, flag, flag2) => {
                    panel_Plc_ProductAlign.Invoke(new Action(() => {
                        lb.ForeColor = flag > 0 ? Color.Red : Color.Black;
                        tb.Text = $"{flag}-{flag2}";
                        switch (flag2)
                        {
                            default: lbcomment.Text = "(未知状态)"; break;
                            case 3: lbcomment.Text = "[VPP错误]"; break;
                            case 2: lbcomment.Text = "[NG]"; break;
                            case 1: lbcomment.Text = "[OK]"; break;
                        }
                    }));
                };

                var plc = Device.wpcReadCodeSignPlc;
                SetIOStatu(lblWpcSignTrigger1, tbTrigger1, lbTrigger1Comment, plc.ProductAlignTrigger, plc.ProductAlignResult);
          }

        private void Cam1_OnNewImage(Cognex.VisionPro.CogImage8Grey obj)
        {
            if (ckb_AutoCam1Grabbing.Checked)
            {
                cogdispccd1.Image = obj;
            }
        }

        #region Plc

        private void btn_PlcOpen_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("打开Plc", () => {
                Device.wpcReadCodeSignPlc.Open();
            });
        }

        private void btn_PlcClose_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("关闭Plc", () => {
                Device.wpcReadCodeSignPlc.Close();
            });
        }

        private void btnAlign1_R1_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("回复对位成功", () => {
                double x, y, r;
                double.TryParse(tbAlign1A.Text, out x);
                double.TryParse(tbAlign1B.Text, out y);
                double.TryParse(tbAlign1C.Text, out r);

                //Device.Plc.WriteProductAlignPos(x);
                Device.wpcReadCodeSignPlc.ProductAlignTrigger = 0;
                Device.wpcReadCodeSignPlc.ProductAlignResult = 1;
            });
        }

        private void btnAlign1_R2_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("回复对位失败", () => {
                double x, y, r;
                double.TryParse(tbAlign1A.Text, out x);
                double.TryParse(tbAlign1B.Text, out y);
                double.TryParse(tbAlign1C.Text, out r);
                //Device.Plc.WriteProductAlignPos(x, y, r);
                Device.wpcReadCodeSignPlc.ProductAlignTrigger = 0;
                Device.wpcReadCodeSignPlc.ProductAlignResult = 2;
            });
        }

        private void btnAlign1_R3_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("回复Vpp异常", () => {
                Device.wpcReadCodeSignPlc.ProductAlignTrigger = 0;
                Device.wpcReadCodeSignPlc.ProductAlignResult = 2;
            });
        }

        #endregion

        #region Cam1

        private void btn_Cam1Open_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("打开相机1", () => {
                Device.WpcCam1.Open(Config.App.WpcCam2);
                tb_Cam1ExposureTime.Text = $"{Device.WpcCam1.CamExposureTime}";
                tb_Cam1Gain.Text = $"{Device.WpcCam1.CamGain}";
            });
        }

        private void btn_Cam1Close_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("关闭相机1", () => {
                ckb_AutoCam1Grabbing.Checked = false;
                Device.WpcCam1.Close();
            });
        }

        private void btn_ReadCam1Param_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("读取相机1参数", () => {
                tb_Cam1ExposureTime.Text = $"{Device.WpcCam1.CamExposureTime}";
                tb_Cam1Gain.Text = $"{Device.WpcCam1.CamGain}";
            });
        }

        private void btn_WriteCam1Param_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("写入相机1参数", () => {
                Device.WpcCam1.CamExposureTime = Convert.ToDouble(tb_Cam1ExposureTime.Text);
                Device.WpcCam1.CamGain = Convert.ToDouble(tb_Cam1Gain.Text);
            });
        }

        private void btn_SaveCam1Param_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("保存相机1参数", () => {
                Device.WpcCam1.CamExposureTime = Convert.ToDouble(tb_Cam1ExposureTime.Text);
                Device.WpcCam1.CamGain = Convert.ToDouble(tb_Cam1Gain.Text);
                Device.WpcCam1.UserSetSave();
            });
        }

        #endregion
        
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
