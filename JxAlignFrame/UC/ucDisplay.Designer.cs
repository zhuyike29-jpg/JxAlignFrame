namespace JxAlignVision
{
    partial class ucDisplay
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDisplay));
            this.lblCCd = new Sunny.UI.UILabel();
            this.displayCCD = new Cognex.VisionPro.CogRecordDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCCd
            // 
            this.lblCCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.lblCCd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCCd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCCd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblCCd.Location = new System.Drawing.Point(0, 0);
            this.lblCCd.Name = "lblCCd";
            this.lblCCd.Size = new System.Drawing.Size(309, 13);
            this.lblCCd.TabIndex = 1;
            this.lblCCd.Text = "对位相机";
            this.lblCCd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayCCD
            // 
            this.displayCCD.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.displayCCD.ColorMapLowerRoiLimit = 0D;
            this.displayCCD.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.displayCCD.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.displayCCD.ColorMapUpperRoiLimit = 1D;
            this.displayCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayCCD.DoubleTapZoomCycleLength = 2;
            this.displayCCD.DoubleTapZoomSensitivity = 2.5D;
            this.displayCCD.Location = new System.Drawing.Point(0, 13);
            this.displayCCD.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.displayCCD.MouseWheelSensitivity = 1D;
            this.displayCCD.Name = "displayCCD";
            this.displayCCD.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("displayCCD.OcxState")));
            this.displayCCD.Size = new System.Drawing.Size(309, 329);
            this.displayCCD.TabIndex = 2;
            // 
            // ucDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayCCD);
            this.Controls.Add(this.lblCCd);
            this.Name = "ucDisplay";
            this.Size = new System.Drawing.Size(309, 342);
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel lblCCd;
        private Cognex.VisionPro.CogRecordDisplay displayCCD;
    }
}
