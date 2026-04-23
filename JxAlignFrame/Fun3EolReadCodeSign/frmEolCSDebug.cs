using Alignlib;
using Cognex.VisionPro;
using Modules;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JxAlignVision.Static;

namespace JxAlignVision
{
    public partial class frmEolCSDebug : UIForm
    {
        MyVision _readCode;
        MyVision _sign;
        CfgEolTrainSignReadCode _eolSignReadCode;
        BaseHikCamera _cam;


        public frmEolCSDebug(MyVision readCode, MyVision sign, CfgEolTrainSignReadCode eolSignReadCode,BaseHikCamera cam)
        {
            InitializeComponent();
            _readCode = readCode;
            _sign = sign;
            _eolSignReadCode = eolSignReadCode;
            _cam = cam;
        }
        ModBindEditValue BindEditValue = new ModBindEditValue();

        private void Frm_Debug_Load(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                _cam.OnNewImage += CamOnNewImage;

                var obj = _eolSignReadCode;
                BindEditValue.Bind(txtMinGray, obj, nameof(obj.minGray));
                BindEditValue.Bind(txtMinGray, obj, nameof(obj.regionCnt));
            });
        }

        private void Frm_Debug_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModLogger.Record(() => {
                if (BindEditValue.Apply(true))
                {
                    ckbAutoCam1Grabbing.Checked = false;
                    _eolSignReadCode.Save();
                    _cam.OnNewImage -= CamOnNewImage;
                }
                else
                {
                    e.Cancel = true;
                }
            });
        }

        private void CamOnNewImage(Cognex.VisionPro.CogImage8Grey obj)
        {
            if (ckbAutoCam1Grabbing.Checked)
            {
                displayCCD1.Image = obj;
            }
        }

        bool RunVppSignTool(int camnum, MyVision tool, UICheckBox ckb_offlineimage,Cognex.VisionPro.CogRecordDisplay display)
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
                img= _cam.GetNewImage();
            }

            //图像处理
            display.Image = null;
            display.Record = null;
            display.Image = img;
            var result =  tool.GetProdSign(img,Recipe.TrainWpcSignReadCode1.minGray,Recipe.TrainWpcSignReadCode1.regionCnt);
            display.Record = tool.GetRecord();
            return result;

        }

        string RunVppCodeTool(int camnum, MyVision tool, UICheckBox ckb_offlineimage, Cognex.VisionPro.CogRecordDisplay display)
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
                img = _cam.GetNewImage();
            }

            //图像处理
            display.Image = null;
            display.Record = null;
            display.Image = img;
            var result = tool.GetProdCode(img);
            display.Record = tool.GetRecord();
            return result;

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            BindEditValue.Reset(true);
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            BindEditValue.Apply(true);
        }

        private void btnRunVppSign_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("运行vpp 点亮", () => {
               var result =  RunVppSignTool(1, _sign, ckbOfflineImgCam1, displayCCD1);
                if (!result) { UpdateProcess("产品未点亮！", false); }
                else { UpdateProcess("产品点亮！"); }
            });
        }

        private void btnEditVppSign_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("修改vpp 点亮", () => {
                _sign.Edit();
            });
        }

        private void btnRunVppCode_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("运行vpp 读码", () => {
                var result = RunVppCodeTool(1, _readCode, ckbOfflineImgCam1, displayCCD1);
                if (result != "") UpdateProcess($"产品码：{result} ", false);
                else { UpdateProcess("识别失败",false); }
            });
        }

        private void btnEditVppCode_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("修改vpp 读码", () => {
                _readCode.Edit();
            });
        }

        ///更新界面交互
        void UpdateProcess(string text, bool isOk = true)
        {
            ModLogger.LogOperate.Info(text);
            ModLogger.FillRichTextBox(rtxtLog, text, isOk);
        }


    }
}
