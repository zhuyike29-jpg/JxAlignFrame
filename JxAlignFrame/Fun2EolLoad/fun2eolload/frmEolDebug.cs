using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modules;
using Alignlib;
using Sunny.UI;
using static JxAlignVision.Static;

namespace JxAlignVision
{
    public partial class frmEolDebug : UIForm
    {
        public frmEolDebug()
        {
            InitializeComponent();
        }
        ModBindEditValue BindEditValue = new ModBindEditValue();

        private void Frm_Debug_Load(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                Device.EolCsCam.OnNewImage += Cam1_OnNewImage;
                Device.EolJigCam.OnNewImage += Cam2_OnNewImage;

                var obj = Recipe.TrainEolLoad;

                //1.产品位置P1,机械手位置R1  Tool1=R1.CalcTool(P1)
                BindEditValue.Bind(txtTool1X, obj, nameof(obj.modTool1X));
                BindEditValue.Bind(txtTool1Y, obj, nameof(obj.modTool1Y));
                BindEditValue.Bind(txtTool1R, obj, nameof(obj.modTool1R));

                //治具位置P2,机械手放料位R2 Tool2=R2.ToolUsed(Tool1).CalcTool(P2)
                BindEditValue.Bind(txtTool2X, obj, nameof(obj.modTool2X));
                BindEditValue.Bind(txtTool2Y, obj, nameof(obj.modTool2Y));
                BindEditValue.Bind(txtTool2R, obj, nameof(obj.modTool2R));

                //补偿值
                BindEditValue.Bind(txtTargetHX, obj, nameof(obj.modTargetHX));
                BindEditValue.Bind(txtTargetHY, obj, nameof(obj.modTargetHY));
                BindEditValue.Bind(txtTargetHR, obj, nameof(obj.modTargetHR));

            });
        }

        private void Frm_Debug_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModLogger.Record(() => {
                if (BindEditValue.Apply(true))
                {
                    chkAutoCamProdGrabbing.Checked = false;
                    chkAutoCamJigGrabbing.Checked = false;
                    Recipe.TrainEolLoad.Save();
                    Device.EolProdCam.OnNewImage -= Cam1_OnNewImage;
                    Device.EolJigCam.OnNewImage -= Cam2_OnNewImage;
                }
                else
                {
                    e.Cancel = true;
                }
            });
        }
        private void Cam1_OnNewImage(Cognex.VisionPro.CogImage8Grey obj)
        {
            if (chkAutoCamProdGrabbing.Checked)
            {
                displayCCD1.Image = obj;
            }
        }
        private void Cam2_OnNewImage(Cognex.VisionPro.CogImage8Grey obj)
        {
            if (chkAutoCamJigGrabbing.Checked)
            {
                displayCCD2.Image = obj;
            }
        }
        

        ECoord RunVppTool(int camnum, MyVision tool, UICheckBox ckb_offlineimage, Cognex.VisionPro.CogRecordDisplay display)
        {
            //获取图像
            Cognex.VisionPro.CogImage8Grey img = null;
            if (ckb_offlineimage.Checked == true)
            {
                //离线读图
                using (var ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() != DialogResult.OK)
                        throw new Exception("用户取消");

                    using (var bmp = new Bitmap(ofd.FileName))
                    {
                        img = new Cognex.VisionPro.CogImage8Grey(bmp);
                    }
                }
            }

            if (img == null)
            {
                //相机读图
                switch (camnum)
                {
                    case 1:
                        img = Device.EolProdCam.GetNewImage();
                        break;
                    case 2:
                        img = Device.EolJigCam.GetNewImage();
                        break;
                }
            }

            //图像处理
            display.Image = null;
            display.Record = null;
            display.Image = img;
            var imgpos = tool.GetAlignPos(img);
            display.Record = tool.GetRecord();
            return imgpos;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            BindEditValue.Reset(true);
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            BindEditValue.Apply(true);
        }


        private void btnGetProdPos_Click(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                chkAutoCamProdGrabbing.Checked = false;
                chkOfflineimgCamProd.Checked = false;
                var imgpt = RunVppTool(1, Recipe.VisEolProd, chkOfflineimgCamProd, displayCCD1);
                var img2robpt = Config.EolProdCalib.MatCamera.TransformCoord(imgpt);

                txtProdX.Text = img2robpt.X.ToString("0.000");
                txtProdY.Text = img2robpt.Y.ToString("0.000");
                txtProdR.Text = img2robpt.R.ToString("0.000");
            });
        }

        private void btnGetRobPos_Click(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                var robpt = Device.EolLoadPlc.GetPlcCurPosCoord;
                txtRobX.Text = robpt.X.ToString("0.000");
                txtRobY.Text = robpt.Y.ToString("0.000");
                txtRobR.Text = robpt.R.ToString("0.000");
            });
        }

        private void btnCalcTool1_Click(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                var r1 = new ECoord(txtRobX.Text,txtRobY.Text,txtRobR.Text);
                var p1 = new ECoord(txtProdX.Text,txtProdY.Text,txtProdR.Text);
                var tool1 = r1.CalcTool(p1);

                txtTool1X.Text = tool1.X.ToString("0.000");
                txtTool1Y.Text = tool1.Y.ToString("0.000");
                txtTool1R.Text = tool1.R.ToString("0.000");
            });
        }

        private void btnGetJigPos_Click(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                chkAutoCamJigGrabbing.Checked = false;
                chkOfflineImgCamJig.Checked = false;
                var imgpt = RunVppTool(1, Recipe.VisEolJig, chkOfflineimgCamProd, displayCCD2);
                var img2robpt = Config.EolJigCalib.MatCamera.TransformCoord(imgpt);

                txtJigX.Text = img2robpt.X.ToString("0.000");
                txtJigY.Text = img2robpt.Y.ToString("0.000");
                txtJigR.Text = img2robpt.R.ToString("0.000");
            });
        }

        private void btnRobptPlace_Click(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                var robpt = Device.EolLoadPlc.GetPlcCurPosCoord;
                txtRobptPlaceX.Text = robpt.X.ToString("0.000");
                txtRobptPlaceY.Text = robpt.Y.ToString("0.000");
                txtRobptPlaceR.Text = robpt.R.ToString("0.000");
            });

        }

        private void btnCalcTool2_Click(object sender, EventArgs e)
        {
            //治具位置P2,机械手放料位R2
            //Tool2=R2.ToolUsed(Tool1).CalcTool(P2)
            ModLogger.Operate("",()=>{
                var r2 = new ECoord(txtRobptPlaceX.Text, txtRobptPlaceY.Text, txtRobptPlaceR.Text);
                var p2 = new ECoord(txtJigX.Text, txtJigY.Text, txtJigR.Text);
                var Tool1 = new ECoord(txtTool1X.Text, txtTool1Y.Text, txtTool1R.Text);
                var Tool2 = r2.ToolUsed(Tool1).CalcTool(p2);
            });
        }


    }
}
