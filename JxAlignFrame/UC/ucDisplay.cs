using Cognex.VisionPro;
using Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JxAlignVision
{
    public partial class ucDisplay : UserControl
    {

        public ucDisplay()
        {
            InitializeComponent();
        }



        public string Title
        {
            get { return lblCCd.Text; }
            set { lblCCd.Text=value; }
        }

        /// <summary>
        /// 设置标题
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title) 
        {
            ModLogger.BeginInvoke(lblCCd, () => { lblCCd.Text = title; });
        }

        /// <summary>
        ///  显示实时图片
        /// </summary>
        /// <param name="img"></param>
        public void ShowRealTimeImg(CogImage8Grey img) 
        {
            ModLogger.BeginInvoke(displayCCD, () => {
                displayCCD.Image = img;
            });
        }

        /// <summary>
        /// 处理前显示图片
        /// </summary>
        /// <param name="img"></param>
        public void ShowImg(CogImage8Grey img) 
        {
            ModLogger.BeginInvoke(displayCCD, () => { 
                displayCCD.Image = null;
                displayCCD.Record=null;
                displayCCD.Image = img;
            });

            ModLogger.BeginInvoke(lblCCd, () => {
                lblCCd.ForeColor = Color.Red;
            });
        }

        /// <summary>
        /// 图像处理成功后显示 Record
        /// </summary>
        /// <param name="record"></param>
        public void ShowRecord(ICogRecord record) {
            ModLogger.BeginInvoke(displayCCD, () => {
                displayCCD.Record = record;
            });

            ModLogger.BeginInvoke(lblCCd, () => {
                lblCCd.ForeColor = Color.Black;
            });
        }
    }
}
