using Sunny.UI;

namespace JxAlignVision
{
    partial class frmEolCSDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEolCSDebug));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnRunVppCode = new Sunny.UI.UIButton();
            this.btnEditVppCode = new Sunny.UI.UIButton();
            this.rtxtLog = new Sunny.UI.UIRichTextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnApply = new Sunny.UI.UIButton();
            this.btnReset = new Sunny.UI.UIButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtRegionCnt = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.label4 = new Sunny.UI.UILabel();
            this.txtMinGray = new Sunny.UI.UITextBox();
            this.label5 = new Sunny.UI.UILabel();
            this.ckbOfflineImgCam1 = new Sunny.UI.UICheckBox();
            this.ckbAutoCam1Grabbing = new Sunny.UI.UICheckBox();
            this.btnRunVppSign = new Sunny.UI.UIButton();
            this.btnEditVppSign = new Sunny.UI.UIButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.displayCCD1 = new Cognex.VisionPro.CogRecordDisplay();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtModToolHR21 = new Sunny.UI.UITextBox();
            this.txtModToolPickR21 = new Sunny.UI.UITextBox();
            this.txtModToolPickR22 = new Sunny.UI.UITextBox();
            this.txtModToolPickY22 = new Sunny.UI.UITextBox();
            this.txtModToolPickX22 = new Sunny.UI.UITextBox();
            this.txtModPlcTargetPickR22 = new Sunny.UI.UITextBox();
            this.txtModPlcTargetPickR21 = new Sunny.UI.UITextBox();
            this.txtModPlcTargetPickY22 = new Sunny.UI.UITextBox();
            this.txtModPlcTargetPickY21 = new Sunny.UI.UITextBox();
            this.txtModPlcTargetPickX22 = new Sunny.UI.UITextBox();
            this.txtModPlcTargetPickX21 = new Sunny.UI.UITextBox();
            this.txtModToolHR22 = new Sunny.UI.UITextBox();
            this.txtModToolHY22 = new Sunny.UI.UITextBox();
            this.txtModToolHX22 = new Sunny.UI.UITextBox();
            this.txtModTargetPickR21 = new Sunny.UI.UITextBox();
            this.txtModTargetPickY21 = new Sunny.UI.UITextBox();
            this.txtModTargetPickX21 = new Sunny.UI.UITextBox();
            this.txtModToolPickY21 = new Sunny.UI.UITextBox();
            this.txtModToolPickX21 = new Sunny.UI.UITextBox();
            this.txtModToolHY21 = new Sunny.UI.UITextBox();
            this.txtModToolHX21 = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uiLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.uiLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnRunVppCode);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditVppCode);
            this.splitContainer1.Panel1.Controls.Add(this.rtxtLog);
            this.splitContainer1.Panel1.Controls.Add(this.uiPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.ckbOfflineImgCam1);
            this.splitContainer1.Panel1.Controls.Add(this.ckbAutoCam1Grabbing);
            this.splitContainer1.Panel1.Controls.Add(this.btnRunVppSign);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditVppSign);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1552, 1058);
            this.splitContainer1.SplitterDistance = 606;
            this.splitContainer1.TabIndex = 0;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(24, 130);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(49, 20);
            this.uiLabel2.TabIndex = 17;
            this.uiLabel2.Text = "读码";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(24, 61);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(49, 20);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "点亮";
            // 
            // btnRunVppCode
            // 
            this.btnRunVppCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnRunVppCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunVppCode.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRunVppCode.Location = new System.Drawing.Point(89, 118);
            this.btnRunVppCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRunVppCode.Name = "btnRunVppCode";
            this.btnRunVppCode.Size = new System.Drawing.Size(86, 41);
            this.btnRunVppCode.TabIndex = 15;
            this.btnRunVppCode.Text = "运行vpp";
            this.btnRunVppCode.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRunVppCode.Click += new System.EventHandler(this.btnRunVppCode_Click);
            // 
            // btnEditVppCode
            // 
            this.btnEditVppCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditVppCode.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditVppCode.Location = new System.Drawing.Point(189, 118);
            this.btnEditVppCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditVppCode.Name = "btnEditVppCode";
            this.btnEditVppCode.Size = new System.Drawing.Size(91, 41);
            this.btnEditVppCode.TabIndex = 14;
            this.btnEditVppCode.Text = "修改vpp";
            this.btnEditVppCode.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditVppCode.Click += new System.EventHandler(this.btnEditVppCode_Click);
            // 
            // rtxtLog
            // 
            this.rtxtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtLog.FillColor = System.Drawing.Color.White;
            this.rtxtLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxtLog.Location = new System.Drawing.Point(0, 770);
            this.rtxtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtxtLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Padding = new System.Windows.Forms.Padding(2);
            this.rtxtLog.ShowText = false;
            this.rtxtLog.Size = new System.Drawing.Size(606, 180);
            this.rtxtLog.TabIndex = 13;
            this.rtxtLog.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnApply);
            this.uiPanel1.Controls.Add(this.btnReset);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 950);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(606, 108);
            this.uiPanel1.TabIndex = 12;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApply.Location = new System.Drawing.Point(498, 15);
            this.btnApply.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(87, 41);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "应用";
            this.btnApply.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(386, 15);
            this.btnReset.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 41);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重置";
            this.btnReset.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtRegionCnt, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.uiLabel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtMinGray, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 224);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(563, 98);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // txtRegionCnt
            // 
            this.txtRegionCnt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegionCnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegionCnt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRegionCnt.Location = new System.Drawing.Point(285, 54);
            this.txtRegionCnt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegionCnt.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRegionCnt.Multiline = true;
            this.txtRegionCnt.Name = "txtRegionCnt";
            this.txtRegionCnt.Padding = new System.Windows.Forms.Padding(5);
            this.txtRegionCnt.ShowText = false;
            this.txtRegionCnt.Size = new System.Drawing.Size(274, 39);
            this.txtRegionCnt.TabIndex = 13;
            this.txtRegionCnt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRegionCnt.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel3.Location = new System.Drawing.Point(3, 49);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(275, 49);
            this.uiLabel3.TabIndex = 12;
            this.uiLabel3.Text = "区域数量";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 49);
            this.label4.TabIndex = 7;
            this.label4.Text = "点亮最低灰度";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMinGray
            // 
            this.txtMinGray.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinGray.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMinGray.Location = new System.Drawing.Point(285, 5);
            this.txtMinGray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinGray.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMinGray.Multiline = true;
            this.txtMinGray.Name = "txtMinGray";
            this.txtMinGray.Padding = new System.Windows.Forms.Padding(5);
            this.txtMinGray.ShowText = false;
            this.txtMinGray.Size = new System.Drawing.Size(274, 39);
            this.txtMinGray.TabIndex = 11;
            this.txtMinGray.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMinGray.Watermark = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "图像操作：";
            // 
            // ckbOfflineImgCam1
            // 
            this.ckbOfflineImgCam1.AutoSize = true;
            this.ckbOfflineImgCam1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbOfflineImgCam1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbOfflineImgCam1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ckbOfflineImgCam1.Location = new System.Drawing.Point(452, 61);
            this.ckbOfflineImgCam1.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckbOfflineImgCam1.Name = "ckbOfflineImgCam1";
            this.ckbOfflineImgCam1.Size = new System.Drawing.Size(152, 25);
            this.ckbOfflineImgCam1.TabIndex = 6;
            this.ckbOfflineImgCam1.Text = "相机离线图像";
            // 
            // ckbAutoCam1Grabbing
            // 
            this.ckbAutoCam1Grabbing.AutoSize = true;
            this.ckbAutoCam1Grabbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoCam1Grabbing.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbAutoCam1Grabbing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ckbAutoCam1Grabbing.Location = new System.Drawing.Point(291, 61);
            this.ckbAutoCam1Grabbing.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckbAutoCam1Grabbing.Name = "ckbAutoCam1Grabbing";
            this.ckbAutoCam1Grabbing.Size = new System.Drawing.Size(152, 25);
            this.ckbAutoCam1Grabbing.TabIndex = 4;
            this.ckbAutoCam1Grabbing.Text = "相机实时图像";
            // 
            // btnRunVppSign
            // 
            this.btnRunVppSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnRunVppSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRunVppSign.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRunVppSign.Location = new System.Drawing.Point(90, 50);
            this.btnRunVppSign.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRunVppSign.Name = "btnRunVppSign";
            this.btnRunVppSign.Size = new System.Drawing.Size(86, 41);
            this.btnRunVppSign.TabIndex = 0;
            this.btnRunVppSign.Text = "运行vpp";
            this.btnRunVppSign.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRunVppSign.Click += new System.EventHandler(this.btnRunVppSign_Click);
            // 
            // btnEditVppSign
            // 
            this.btnEditVppSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditVppSign.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEditVppSign.Location = new System.Drawing.Point(191, 50);
            this.btnEditVppSign.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEditVppSign.Name = "btnEditVppSign";
            this.btnEditVppSign.Size = new System.Drawing.Size(91, 41);
            this.btnEditVppSign.TabIndex = 2;
            this.btnEditVppSign.Text = "修改vpp";
            this.btnEditVppSign.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditVppSign.Click += new System.EventHandler(this.btnEditVppSign_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.displayCCD1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(942, 1058);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // displayCCD1
            // 
            this.displayCCD1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.displayCCD1.ColorMapLowerRoiLimit = 0D;
            this.displayCCD1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.displayCCD1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.displayCCD1.ColorMapUpperRoiLimit = 1D;
            this.displayCCD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayCCD1.DoubleTapZoomCycleLength = 2;
            this.displayCCD1.DoubleTapZoomSensitivity = 2.5D;
            this.displayCCD1.Location = new System.Drawing.Point(3, 3);
            this.displayCCD1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.displayCCD1.MouseWheelSensitivity = 1D;
            this.displayCCD1.Name = "displayCCD1";
            this.displayCCD1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("displayCCD1.OcxState")));
            this.displayCCD1.Size = new System.Drawing.Size(936, 1052);
            this.displayCCD1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 1058);
            this.panel1.TabIndex = 1;
            // 
            // txtModToolHR21
            // 
            this.txtModToolHR21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolHR21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolHR21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolHR21.Location = new System.Drawing.Point(427, 185);
            this.txtModToolHR21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolHR21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolHR21.Multiline = true;
            this.txtModToolHR21.Name = "txtModToolHR21";
            this.txtModToolHR21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolHR21.ShowText = false;
            this.txtModToolHR21.Size = new System.Drawing.Size(136, 35);
            this.txtModToolHR21.TabIndex = 41;
            this.txtModToolHR21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolHR21.Watermark = "";
            // 
            // txtModToolPickR21
            // 
            this.txtModToolPickR21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolPickR21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolPickR21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolPickR21.Location = new System.Drawing.Point(427, 140);
            this.txtModToolPickR21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolPickR21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolPickR21.Multiline = true;
            this.txtModToolPickR21.Name = "txtModToolPickR21";
            this.txtModToolPickR21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolPickR21.ShowText = false;
            this.txtModToolPickR21.Size = new System.Drawing.Size(136, 35);
            this.txtModToolPickR21.TabIndex = 36;
            this.txtModToolPickR21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolPickR21.Watermark = "";
            // 
            // txtModToolPickR22
            // 
            this.txtModToolPickR22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolPickR22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolPickR22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolPickR22.Location = new System.Drawing.Point(427, 275);
            this.txtModToolPickR22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolPickR22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolPickR22.Multiline = true;
            this.txtModToolPickR22.Name = "txtModToolPickR22";
            this.txtModToolPickR22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolPickR22.ShowText = false;
            this.txtModToolPickR22.Size = new System.Drawing.Size(136, 35);
            this.txtModToolPickR22.TabIndex = 26;
            this.txtModToolPickR22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolPickR22.Watermark = "";
            // 
            // txtModToolPickY22
            // 
            this.txtModToolPickY22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolPickY22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolPickY22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolPickY22.Location = new System.Drawing.Point(286, 275);
            this.txtModToolPickY22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolPickY22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolPickY22.Multiline = true;
            this.txtModToolPickY22.Name = "txtModToolPickY22";
            this.txtModToolPickY22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolPickY22.ShowText = false;
            this.txtModToolPickY22.Size = new System.Drawing.Size(133, 35);
            this.txtModToolPickY22.TabIndex = 25;
            this.txtModToolPickY22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolPickY22.Watermark = "";
            // 
            // txtModToolPickX22
            // 
            this.txtModToolPickX22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolPickX22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolPickX22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolPickX22.Location = new System.Drawing.Point(145, 275);
            this.txtModToolPickX22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolPickX22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolPickX22.Multiline = true;
            this.txtModToolPickX22.Name = "txtModToolPickX22";
            this.txtModToolPickX22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolPickX22.ShowText = false;
            this.txtModToolPickX22.Size = new System.Drawing.Size(133, 35);
            this.txtModToolPickX22.TabIndex = 24;
            this.txtModToolPickX22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolPickX22.Watermark = "";
            // 
            // txtModPlcTargetPickR22
            // 
            this.txtModPlcTargetPickR22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModPlcTargetPickR22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModPlcTargetPickR22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModPlcTargetPickR22.Location = new System.Drawing.Point(427, 230);
            this.txtModPlcTargetPickR22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModPlcTargetPickR22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModPlcTargetPickR22.Multiline = true;
            this.txtModPlcTargetPickR22.Name = "txtModPlcTargetPickR22";
            this.txtModPlcTargetPickR22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModPlcTargetPickR22.ShowText = false;
            this.txtModPlcTargetPickR22.Size = new System.Drawing.Size(136, 35);
            this.txtModPlcTargetPickR22.TabIndex = 22;
            this.txtModPlcTargetPickR22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModPlcTargetPickR22.Watermark = "";
            // 
            // txtModPlcTargetPickR21
            // 
            this.txtModPlcTargetPickR21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModPlcTargetPickR21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModPlcTargetPickR21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModPlcTargetPickR21.Location = new System.Drawing.Point(427, 95);
            this.txtModPlcTargetPickR21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModPlcTargetPickR21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModPlcTargetPickR21.Multiline = true;
            this.txtModPlcTargetPickR21.Name = "txtModPlcTargetPickR21";
            this.txtModPlcTargetPickR21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModPlcTargetPickR21.ShowText = false;
            this.txtModPlcTargetPickR21.Size = new System.Drawing.Size(136, 35);
            this.txtModPlcTargetPickR21.TabIndex = 21;
            this.txtModPlcTargetPickR21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModPlcTargetPickR21.Watermark = "";
            // 
            // txtModPlcTargetPickY22
            // 
            this.txtModPlcTargetPickY22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModPlcTargetPickY22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModPlcTargetPickY22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModPlcTargetPickY22.Location = new System.Drawing.Point(286, 230);
            this.txtModPlcTargetPickY22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModPlcTargetPickY22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModPlcTargetPickY22.Multiline = true;
            this.txtModPlcTargetPickY22.Name = "txtModPlcTargetPickY22";
            this.txtModPlcTargetPickY22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModPlcTargetPickY22.ShowText = false;
            this.txtModPlcTargetPickY22.Size = new System.Drawing.Size(133, 35);
            this.txtModPlcTargetPickY22.TabIndex = 20;
            this.txtModPlcTargetPickY22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModPlcTargetPickY22.Watermark = "";
            // 
            // txtModPlcTargetPickY21
            // 
            this.txtModPlcTargetPickY21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModPlcTargetPickY21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModPlcTargetPickY21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModPlcTargetPickY21.Location = new System.Drawing.Point(286, 95);
            this.txtModPlcTargetPickY21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModPlcTargetPickY21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModPlcTargetPickY21.Multiline = true;
            this.txtModPlcTargetPickY21.Name = "txtModPlcTargetPickY21";
            this.txtModPlcTargetPickY21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModPlcTargetPickY21.ShowText = false;
            this.txtModPlcTargetPickY21.Size = new System.Drawing.Size(133, 35);
            this.txtModPlcTargetPickY21.TabIndex = 19;
            this.txtModPlcTargetPickY21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModPlcTargetPickY21.Watermark = "";
            // 
            // txtModPlcTargetPickX22
            // 
            this.txtModPlcTargetPickX22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModPlcTargetPickX22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModPlcTargetPickX22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModPlcTargetPickX22.Location = new System.Drawing.Point(145, 230);
            this.txtModPlcTargetPickX22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModPlcTargetPickX22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModPlcTargetPickX22.Multiline = true;
            this.txtModPlcTargetPickX22.Name = "txtModPlcTargetPickX22";
            this.txtModPlcTargetPickX22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModPlcTargetPickX22.ShowText = false;
            this.txtModPlcTargetPickX22.Size = new System.Drawing.Size(133, 35);
            this.txtModPlcTargetPickX22.TabIndex = 18;
            this.txtModPlcTargetPickX22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModPlcTargetPickX22.Watermark = "";
            // 
            // txtModPlcTargetPickX21
            // 
            this.txtModPlcTargetPickX21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModPlcTargetPickX21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModPlcTargetPickX21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModPlcTargetPickX21.Location = new System.Drawing.Point(145, 95);
            this.txtModPlcTargetPickX21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModPlcTargetPickX21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModPlcTargetPickX21.Multiline = true;
            this.txtModPlcTargetPickX21.Name = "txtModPlcTargetPickX21";
            this.txtModPlcTargetPickX21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModPlcTargetPickX21.ShowText = false;
            this.txtModPlcTargetPickX21.Size = new System.Drawing.Size(133, 35);
            this.txtModPlcTargetPickX21.TabIndex = 17;
            this.txtModPlcTargetPickX21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModPlcTargetPickX21.Watermark = "";
            // 
            // txtModToolHR22
            // 
            this.txtModToolHR22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolHR22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolHR22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolHR22.Location = new System.Drawing.Point(427, 320);
            this.txtModToolHR22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolHR22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolHR22.Multiline = true;
            this.txtModToolHR22.Name = "txtModToolHR22";
            this.txtModToolHR22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolHR22.ShowText = false;
            this.txtModToolHR22.Size = new System.Drawing.Size(136, 36);
            this.txtModToolHR22.TabIndex = 15;
            this.txtModToolHR22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolHR22.Watermark = "";
            // 
            // txtModToolHY22
            // 
            this.txtModToolHY22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolHY22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolHY22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolHY22.Location = new System.Drawing.Point(286, 320);
            this.txtModToolHY22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolHY22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolHY22.Multiline = true;
            this.txtModToolHY22.Name = "txtModToolHY22";
            this.txtModToolHY22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolHY22.ShowText = false;
            this.txtModToolHY22.Size = new System.Drawing.Size(133, 36);
            this.txtModToolHY22.TabIndex = 14;
            this.txtModToolHY22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolHY22.Watermark = "";
            // 
            // txtModToolHX22
            // 
            this.txtModToolHX22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolHX22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolHX22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolHX22.Location = new System.Drawing.Point(145, 320);
            this.txtModToolHX22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolHX22.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolHX22.Multiline = true;
            this.txtModToolHX22.Name = "txtModToolHX22";
            this.txtModToolHX22.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolHX22.ShowText = false;
            this.txtModToolHX22.Size = new System.Drawing.Size(133, 36);
            this.txtModToolHX22.TabIndex = 13;
            this.txtModToolHX22.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolHX22.Watermark = "";
            // 
            // txtModTargetPickR21
            // 
            this.txtModTargetPickR21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModTargetPickR21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModTargetPickR21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModTargetPickR21.Location = new System.Drawing.Point(427, 50);
            this.txtModTargetPickR21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModTargetPickR21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModTargetPickR21.Multiline = true;
            this.txtModTargetPickR21.Name = "txtModTargetPickR21";
            this.txtModTargetPickR21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModTargetPickR21.ShowText = false;
            this.txtModTargetPickR21.Size = new System.Drawing.Size(136, 35);
            this.txtModTargetPickR21.TabIndex = 12;
            this.txtModTargetPickR21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModTargetPickR21.Watermark = "";
            // 
            // txtModTargetPickY21
            // 
            this.txtModTargetPickY21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModTargetPickY21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModTargetPickY21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModTargetPickY21.Location = new System.Drawing.Point(286, 50);
            this.txtModTargetPickY21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModTargetPickY21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModTargetPickY21.Multiline = true;
            this.txtModTargetPickY21.Name = "txtModTargetPickY21";
            this.txtModTargetPickY21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModTargetPickY21.ShowText = false;
            this.txtModTargetPickY21.Size = new System.Drawing.Size(133, 35);
            this.txtModTargetPickY21.TabIndex = 11;
            this.txtModTargetPickY21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModTargetPickY21.Watermark = "";
            // 
            // txtModTargetPickX21
            // 
            this.txtModTargetPickX21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModTargetPickX21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModTargetPickX21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModTargetPickX21.Location = new System.Drawing.Point(145, 50);
            this.txtModTargetPickX21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModTargetPickX21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModTargetPickX21.Multiline = true;
            this.txtModTargetPickX21.Name = "txtModTargetPickX21";
            this.txtModTargetPickX21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModTargetPickX21.ShowText = false;
            this.txtModTargetPickX21.Size = new System.Drawing.Size(133, 35);
            this.txtModTargetPickX21.TabIndex = 10;
            this.txtModTargetPickX21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModTargetPickX21.Watermark = "";
            // 
            // txtModToolPickY21
            // 
            this.txtModToolPickY21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolPickY21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolPickY21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolPickY21.Location = new System.Drawing.Point(286, 140);
            this.txtModToolPickY21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolPickY21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolPickY21.Multiline = true;
            this.txtModToolPickY21.Name = "txtModToolPickY21";
            this.txtModToolPickY21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolPickY21.ShowText = false;
            this.txtModToolPickY21.Size = new System.Drawing.Size(133, 35);
            this.txtModToolPickY21.TabIndex = 38;
            this.txtModToolPickY21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolPickY21.Watermark = "";
            // 
            // txtModToolPickX21
            // 
            this.txtModToolPickX21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolPickX21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolPickX21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolPickX21.Location = new System.Drawing.Point(145, 140);
            this.txtModToolPickX21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolPickX21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolPickX21.Multiline = true;
            this.txtModToolPickX21.Name = "txtModToolPickX21";
            this.txtModToolPickX21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolPickX21.ShowText = false;
            this.txtModToolPickX21.Size = new System.Drawing.Size(133, 35);
            this.txtModToolPickX21.TabIndex = 37;
            this.txtModToolPickX21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolPickX21.Watermark = "";
            // 
            // txtModToolHY21
            // 
            this.txtModToolHY21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolHY21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolHY21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolHY21.Location = new System.Drawing.Point(286, 185);
            this.txtModToolHY21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolHY21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolHY21.Multiline = true;
            this.txtModToolHY21.Name = "txtModToolHY21";
            this.txtModToolHY21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolHY21.ShowText = false;
            this.txtModToolHY21.Size = new System.Drawing.Size(133, 35);
            this.txtModToolHY21.TabIndex = 40;
            this.txtModToolHY21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolHY21.Watermark = "";
            // 
            // txtModToolHX21
            // 
            this.txtModToolHX21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModToolHX21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModToolHX21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModToolHX21.Location = new System.Drawing.Point(145, 185);
            this.txtModToolHX21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModToolHX21.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtModToolHX21.Multiline = true;
            this.txtModToolHX21.Name = "txtModToolHX21";
            this.txtModToolHX21.Padding = new System.Windows.Forms.Padding(5);
            this.txtModToolHX21.ShowText = false;
            this.txtModToolHX21.Size = new System.Drawing.Size(133, 35);
            this.txtModToolHX21.TabIndex = 42;
            this.txtModToolHX21.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtModToolHX21.Watermark = "";
            // 
            // frmEolCSDebug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1552, 1093);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEolCSDebug";
            this.Text = "EOL读码&点亮 模板调试";
            this.TitleFont = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1564, 1064);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Debug_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Debug_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Sunny.UI.UIButton btnApply;
        private Sunny.UI.UIButton btnReset;
        private Sunny.UI.UIButton btnEditVppSign;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Cognex.VisionPro.CogRecordDisplay displayCCD1;
        private Sunny.UI.UICheckBox ckbOfflineImgCam1;
        private Sunny.UI.UICheckBox ckbAutoCam1Grabbing;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UITextBox txtMinGray;
        private Sunny.UI.UITextBox txtModToolHR21;
        private Sunny.UI.UITextBox txtModToolPickR21;
        private Sunny.UI.UITextBox txtModToolPickR22;
        private Sunny.UI.UITextBox txtModToolPickY22;
        private Sunny.UI.UITextBox txtModToolPickX22;
        private Sunny.UI.UITextBox txtModPlcTargetPickR22;
        private Sunny.UI.UITextBox txtModPlcTargetPickR21;
        private Sunny.UI.UITextBox txtModPlcTargetPickY22;
        private Sunny.UI.UITextBox txtModPlcTargetPickY21;
        private Sunny.UI.UITextBox txtModPlcTargetPickX22;
        private Sunny.UI.UITextBox txtModPlcTargetPickX21;
        private Sunny.UI.UITextBox txtModToolHR22;
        private Sunny.UI.UITextBox txtModToolHY22;
        private Sunny.UI.UITextBox txtModToolHX22;
        private Sunny.UI.UITextBox txtModTargetPickR21;
        private Sunny.UI.UITextBox txtModTargetPickY21;
        private Sunny.UI.UITextBox txtModTargetPickX21;
        private Sunny.UI.UITextBox txtModToolPickY21;
        private Sunny.UI.UITextBox txtModToolPickX21;
        private Sunny.UI.UITextBox txtModToolHY21;
        private Sunny.UI.UITextBox txtModToolHX21;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIRichTextBox rtxtLog;
        private UIButton btnEditVppCode;
        private UIButton btnRunVppSign;
        private UILabel uiLabel2;
        private UILabel uiLabel1;
        private UIButton btnRunVppCode;
        private UITextBox txtRegionCnt;
        private UILabel uiLabel3;
    }
}