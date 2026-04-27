using Modules;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JxAlignVision.Static;

namespace JxAlignVision
{
    public partial class frmDevice : UIForm
    {
        BaseHikCamera _cam;
        Thread _plcListenThread ;

        public frmDevice()
        {
            InitializeComponent();
        }

        private void Frm_Device_Load(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                if (Device.WpcCam1.IsOpen()) btnReadCamParam_Click(null, null);
                _plcListenThread = new Thread(PlcListenThread);
                _plcListenThread.Start();
                cboCam.SelectedIndex = 0;
                cboPlcSel.SelectedIndex = 0;
            });
        }

        private void Frm_Device_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModLogger.Record(() => {
                _plcListenThread.Abort();
                ckb_AutoCam1Grabbing.Checked = false;
                Thread.Sleep(100);
                _cam.OnNewImage -= Cam1_OnNewImage;
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ModLogger.Record(() => {

                //Plc打开状态
                int plcIndex = cboPlcSel.SelectedIndex;
                bool plcisopen = GetPlcStatus(plcIndex);
                lb_PlcIsOpen.Text = plcisopen ? "已连接" : "已断开";
                lb_PlcIsOpen.ForeColor = plcisopen ? Color.Green : Color.Red;
                btnPlcOpen.Enabled = !plcisopen;
                btnPlcClose.Enabled = plcisopen;

                //相机状态
                var isCamOpen = false;
                isCamOpen = _cam.IsOpen();
                SetCamStatus(isCamOpen, lb_Cam1IsOpen, btnCamOpen, btnCamClose, panel_Cam1Param, ckb_AutoCam1Grabbing);


            });
        }

        private bool GetPlcStatus(int index) {
            bool isOpen=false;
            switch (index) {
                case 0:
                    isOpen = Device.WpcReadCodeSignPlc.IsOpen();
                break;
                case 1:
                    isOpen = Device.EolLoadPlc.IsOpen();
                    break;
                case 2:
                    isOpen = Device.EolReadCodeSignPlc.IsOpen();
                    break;
            }
            return isOpen;
        }

        //相机打开状态
        private void SetCamStatus(bool isCamOpen, UILabel lbCameraIsOpen, UIButton btnCameraOpen, UIButton btnCameraClose, UIPanel panelCamParam, UICheckBox ckb) {
            lbCameraIsOpen.BeginInvoke(new Action(() => {
                lbCameraIsOpen.Text = isCamOpen ? "已连接" : "已断开";
                lbCameraIsOpen.ForeColor = isCamOpen ? Color.Green : Color.Red;
            }));
            btnCameraOpen.BeginInvoke(new Action(() => { btnCameraOpen.Enabled = !isCamOpen; }));
            btnCameraClose.BeginInvoke(new Action(() => { btnCameraClose.Enabled = isCamOpen; }));
            ckb.BeginInvoke(new Action(() => { ckb.Enabled = panelCamParam.Enabled = isCamOpen; })); 
        }

        void PlcListenThread()
        {
            while (true)
            {
                Thread.Sleep(100);
                //WPC PLC
                bool isWpcPlcOpen = Device.WpcReadCodeSignPlc.IsOpen();

                if (isWpcPlcOpen) 
                {
                    int codeTrigger1 = Device.WpcReadCodeSignPlc.WpcPlcProductCodeTrigger1;
                    int codeTrigger2 = Device.WpcReadCodeSignPlc.WpcPlcProductCodeTrigger2;
                    int signTrigger1 = Device.WpcReadCodeSignPlc.WpcPlcProductSignTrigger1;
                    int signTrigger2 = Device.WpcReadCodeSignPlc.WpcPlcProductSignTrigger2;

                    WPCIOStatus(codeTrigger1, codeTrigger2, signTrigger1, signTrigger2);
                }
                //EOL 上下料PLC
                bool isEolLoadPlcOpen = Device.EolLoadPlc.IsOpen();

                if (isEolLoadPlcOpen) 
                { 
                    int eolLoadProd = Device.EolLoadPlc.EolProdAlignTrigger;
                    int eolLoadJig = Device.EolLoadPlc.EolJigAlignTrigger;

                    EolLoadIOStatus(eolLoadProd, eolLoadJig);
                }

                //EOL
                bool isEolPlcOpen = Device.EolReadCodeSignPlc.IsOpen();
                if (isEolPlcOpen) 
                {
                    int eolCode = Device.EolReadCodeSignPlc.EolPlcProductCodeTrigger;
                    int eolSign = Device.EolReadCodeSignPlc.EolPlcProductSignTrigger;

                    EolIOStatus(eolCode,eolSign);
                }
            }
        }

        /// <summary>
        /// PLC触发状态
        /// </summary>
        private void EolLoadIOStatus(int eolLoadProd, int eolLoadJig) 
        {
            lblEolProdTrigger.BeginInvoke(new Action(() => { lblEolProdTrigger.ForeColor = eolLoadProd > 0 ? Color.Red : Color.Black; }));
            lblWpcCodeTrigger2.BeginInvoke(new Action(() => { lblWpcCodeTrigger2.ForeColor = eolLoadJig > 0 ? Color.Red : Color.Black; }));
        }

        private void EolIOStatus(int eolCode, int eolSign)
        {
            lblEolCodeTrigger.BeginInvoke(new Action(() => { lblEolCodeTrigger.ForeColor = eolCode > 0 ? Color.Red : Color.Black; }));
            lblEolSignTrigger.BeginInvoke(new Action(() => { lblEolSignTrigger.ForeColor = eolSign > 0 ? Color.Red : Color.Black; }));
        }


        private void WPCIOStatus(int codeTrigger1,int codeTrigger2,int signTrigger1,int signTrigger2) 
        {
            lblWpcCodeTrigger1.BeginInvoke(new Action(() => { lblWpcCodeTrigger1.ForeColor = codeTrigger1 > 0 ? Color.Red : Color.Black; }));
            lblWpcCodeTrigger2.BeginInvoke(new Action(() => { lblWpcCodeTrigger2.ForeColor = codeTrigger2 > 0 ? Color.Red : Color.Black; }));
            lblWpcSignTrigger1.BeginInvoke(new Action(() => { lblWpcSignTrigger1.ForeColor = signTrigger1 > 0 ? Color.Red : Color.Black; }));
            lblWpcSignTrigger2.BeginInvoke(new Action(() => { lblWpcSignTrigger2.ForeColor = signTrigger2 > 0 ? Color.Red : Color.Black; }));
        }

        private void Cam1_OnNewImage(Cognex.VisionPro.CogImage8Grey obj)
        {
            if (ckb_AutoCam1Grabbing.Checked)
            {
                cogdispccd1.Image = obj;
            }
        }

        #region Plc

        private void btnPlcOpen_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("打开Plc", () => {
                switch (cboPlcSel.SelectedIndex) {
                    case 0:
                        if (!Device.WpcReadCodeSignPlc.IsOpen()) 
                        {
                            Device.WpcReadCodeSignPlc.Open();
                        }
                    break;
                    case 1:
                        if (!Device.EolLoadPlc.IsOpen()) 
                        {
                            Device.EolLoadPlc.Open();
                        }
                    break;
                    case 2:
                        if (!Device.EolReadCodeSignPlc.IsOpen())
                        {
                            Device.EolReadCodeSignPlc.Open();
                        }
                     break;  
                }
               
            });
        }

        private void btnPlcClose_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("关闭Plc", () => {
                switch (cboPlcSel.SelectedIndex)
                {
                    case 0:
                            Device.WpcReadCodeSignPlc.Close();
                        break;
                    case 1:
                            Device.EolLoadPlc.Close();
                        break;
                    case 2:
                            Device.EolReadCodeSignPlc.Close();
                        break;
                }
            });
        }

        #endregion

        #region Cam1

        private void btnCamOpen_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("打开相机1", () => {
                _cam.Open(Config.App.WpcCam2);
                switch(cboCam.SelectedIndex) {
                    case 0:
                        _cam.Open(Config.App.WpcCam1);
                    break;
                    case 1:
                        _cam.Open(Config.App.WpcCam2);
                    break;
                    case 2:
                        _cam.Open(Config.App.EolPordCam);
                        break;
                    case 3:
                        _cam.Open(Config.App.EolJigCam);
                        break;
                    case 4:
                        _cam.Open(Config.App.EolCodeSignCam);
                        break;
                }
                tbCamExposureTime.Text = $"{_cam.CamExposureTime}";
                tbCamGain.Text = $"{_cam.CamGain}";
            });
        }

        private void btnCamClose_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("关闭相机1", () => {
                ckb_AutoCam1Grabbing.Checked = false;
                //Device.WpcCam1.Close();
                switch(cboCam.SelectedIndex) {
                    case 0:
                        Device.WpcCam1.Close();
                    break;
                    case 1:
                        Device.WpcCam2.Close();
                    break;
                    case 2:
                        Device.EolProdCam.Close();
                        break;
                    case 3:
                        Device.EolJigCam.Close();
                        break;
                    case 4:
                        Device.EolCsCam.Close();
                        break;
                }
            });
        }

        private void btnReadCamParam_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("读取相机参数", () => {
                tbCamExposureTime.Text = $"{_cam.CamExposureTime}";
                tbCamGain.Text = $"{_cam.CamGain}";
            });
        }

        private void btnWriteCamParam_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("写入相机参数", () => {
                _cam.CamExposureTime = Convert.ToDouble(tbCamExposureTime.Text);
                _cam.CamGain = Convert.ToDouble(tbCamGain.Text);
            });
        }

        private void btnSaveCamParam_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("保存相机1参数", () => {
                _cam.CamExposureTime = Convert.ToDouble(tbCamExposureTime.Text);
                _cam.CamGain = Convert.ToDouble(tbCamGain.Text);
                _cam.UserSetSave();
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

        private void cboCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_cam!=null) _cam.OnNewImage -=Cam1_OnNewImage;
            switch (cboCam.SelectedIndex) {
                case 0:
                    _cam= Device.WpcCam1;
                    break;
                case 1:
                    _cam = Device.WpcCam2;
                    break;
                case 2:
                    _cam = Device.EolProdCam;
                    break;
                case 3:
                    _cam = Device.EolJigCam; ;
                    break;
                case 4:
                    _cam = Device.EolCsCam;
                    break;
            }
            _cam.OnNewImage += Cam1_OnNewImage;
        }

        private void cboPlcSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool plcisopen = GetPlcStatus(cboPlcSel.SelectedIndex);
            lb_PlcIsOpen.Text = plcisopen ? "已连接" : "已断开";
            lb_PlcIsOpen.ForeColor = plcisopen ? Color.Green : Color.Red;
            btnPlcOpen.Enabled = !plcisopen;
            btnPlcClose.Enabled = plcisopen;
        }

        private void btn_MovePlcXYR_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("移动机械臂", () => {
                double x, y, r;
                double.TryParse(txtPlcX.Text, out x);
                double.TryParse(txtPlcY.Text, out y);
                double.TryParse(txtPlcR.Text, out r);
                Device.EolLoadPlc.MovePlcPos(x, y, r);
            });
        }
    }
}
