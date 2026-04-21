namespace AlignVision
{
    partial class Frm_Device
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Device));
            this.Tab = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new Sunny.UI.UIPanel();
            this.panel_Plc_ProductAlign = new Sunny.UI.UIPanel();
            this.label6 = new Sunny.UI.UILabel();
            this.lblWpcSignTrigger1 = new Sunny.UI.UILabel();
            this.btn_PlcClose = new Sunny.UI.UIButton();
            this.btn_PlcOpen = new Sunny.UI.UIButton();
            this.label8 = new Sunny.UI.UILabel();
            this.lb_PlcIsOpen = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new Sunny.UI.UISplitContainer();
            this.panel_Cam1Param = new Sunny.UI.UIPanel();
            this.btn_SaveCam1Param = new Sunny.UI.UIButton();
            this.label12 = new Sunny.UI.UILabel();
            this.btn_WriteCam1Param = new Sunny.UI.UIButton();
            this.btn_ReadCam1Param = new Sunny.UI.UIButton();
            this.tb_Cam1ExposureTime = new Sunny.UI.UITextBox();
            this.tb_Cam1Gain = new Sunny.UI.UITextBox();
            this.label1 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.btn_Cam1Close = new Sunny.UI.UIButton();
            this.btn_Cam1Open = new Sunny.UI.UIButton();
            this.ckb_AutoCam1Grabbing = new Sunny.UI.UICheckBox();
            this.label11 = new Sunny.UI.UILabel();
            this.lb_Cam1IsOpen = new Sunny.UI.UILabel();
            this.cogdispccd1 = new Cognex.VisionPro.CogRecordDisplay();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new Sunny.UI.UIPanel();
            this.tbTrigger1 = new Sunny.UI.UITextBox();
            this.tbAlign1C = new Sunny.UI.UITextBox();
            this.tbAlign1B = new Sunny.UI.UITextBox();
            this.tbAlign1A = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lblWpcSignTrigger2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Plc_ProductAlign.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Cam1Param.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogdispccd1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Tab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tab.ItemSize = new System.Drawing.Size(150, 40);
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.MainPage = "";
            this.Tab.Margin = new System.Windows.Forms.Padding(0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1089, 575);
            this.Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tab.TabIndex = 0;
            this.Tab.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1089, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Plc_ProductAlign);
            this.panel1.Controls.Add(this.btn_PlcClose);
            this.panel1.Controls.Add(this.btn_PlcOpen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lb_PlcIsOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 535);
            this.panel1.TabIndex = 0;
            this.panel1.Text = null;
            this.panel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Plc_ProductAlign
            // 
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel3);
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel4);
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel5);
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel6);
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel1);
            this.panel_Plc_ProductAlign.Controls.Add(this.lblWpcSignTrigger2);
            this.panel_Plc_ProductAlign.Controls.Add(this.label6);
            this.panel_Plc_ProductAlign.Controls.Add(this.lblWpcSignTrigger1);
            this.panel_Plc_ProductAlign.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Plc_ProductAlign.Location = new System.Drawing.Point(7, 115);
            this.panel_Plc_ProductAlign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Plc_ProductAlign.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_Plc_ProductAlign.Name = "panel_Plc_ProductAlign";
            this.panel_Plc_ProductAlign.Size = new System.Drawing.Size(1078, 86);
            this.panel_Plc_ProductAlign.TabIndex = 71;
            this.panel_Plc_ProductAlign.Text = null;
            this.panel_Plc_ProductAlign.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panel_Plc_ProductAlign.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label6.Location = new System.Drawing.Point(17, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "点亮触发1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWpcSignTrigger1
            // 
            this.lblWpcSignTrigger1.AutoSize = true;
            this.lblWpcSignTrigger1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWpcSignTrigger1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblWpcSignTrigger1.Location = new System.Drawing.Point(99, 17);
            this.lblWpcSignTrigger1.Name = "lblWpcSignTrigger1";
            this.lblWpcSignTrigger1.Size = new System.Drawing.Size(17, 12);
            this.lblWpcSignTrigger1.TabIndex = 3;
            this.lblWpcSignTrigger1.Text = "●";
            // 
            // btn_PlcClose
            // 
            this.btn_PlcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_PlcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlcClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PlcClose.Location = new System.Drawing.Point(135, 60);
            this.btn_PlcClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_PlcClose.Name = "btn_PlcClose";
            this.btn_PlcClose.Size = new System.Drawing.Size(64, 29);
            this.btn_PlcClose.TabIndex = 25;
            this.btn_PlcClose.Text = "断开";
            this.btn_PlcClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PlcClose.Click += new System.EventHandler(this.btn_PlcClose_Click);
            // 
            // btn_PlcOpen
            // 
            this.btn_PlcOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_PlcOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlcOpen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PlcOpen.Location = new System.Drawing.Point(48, 60);
            this.btn_PlcOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_PlcOpen.Name = "btn_PlcOpen";
            this.btn_PlcOpen.Size = new System.Drawing.Size(64, 29);
            this.btn_PlcOpen.TabIndex = 24;
            this.btn_PlcOpen.Text = "连接";
            this.btn_PlcOpen.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PlcOpen.Click += new System.EventHandler(this.btn_PlcOpen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label8.Location = new System.Drawing.Point(23, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 69;
            this.label8.Text = "设备控制：";
            // 
            // lb_PlcIsOpen
            // 
            this.lb_PlcIsOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_PlcIsOpen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_PlcIsOpen.ForeColor = System.Drawing.Color.Red;
            this.lb_PlcIsOpen.Location = new System.Drawing.Point(106, 20);
            this.lb_PlcIsOpen.Name = "lb_PlcIsOpen";
            this.lb_PlcIsOpen.Size = new System.Drawing.Size(75, 23);
            this.lb_PlcIsOpen.TabIndex = 23;
            this.lb_PlcIsOpen.Text = "已断开";
            this.lb_PlcIsOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1089, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cam1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel_Cam1Param);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Cam1Close);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Cam1Open);
            this.splitContainer1.Panel1.Controls.Add(this.ckb_AutoCam1Grabbing);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Cam1IsOpen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cogdispccd1);
            this.splitContainer1.Size = new System.Drawing.Size(1089, 535);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.SplitterWidth = 11;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel_Cam1Param
            // 
            this.panel_Cam1Param.Controls.Add(this.btn_SaveCam1Param);
            this.panel_Cam1Param.Controls.Add(this.label12);
            this.panel_Cam1Param.Controls.Add(this.btn_WriteCam1Param);
            this.panel_Cam1Param.Controls.Add(this.btn_ReadCam1Param);
            this.panel_Cam1Param.Controls.Add(this.tb_Cam1ExposureTime);
            this.panel_Cam1Param.Controls.Add(this.tb_Cam1Gain);
            this.panel_Cam1Param.Controls.Add(this.label1);
            this.panel_Cam1Param.Controls.Add(this.label2);
            this.panel_Cam1Param.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Cam1Param.Location = new System.Drawing.Point(3, 123);
            this.panel_Cam1Param.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Cam1Param.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_Cam1Param.Name = "panel_Cam1Param";
            this.panel_Cam1Param.Size = new System.Drawing.Size(439, 140);
            this.panel_Cam1Param.TabIndex = 73;
            this.panel_Cam1Param.Text = null;
            this.panel_Cam1Param.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SaveCam1Param
            // 
            this.btn_SaveCam1Param.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_SaveCam1Param.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveCam1Param.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveCam1Param.Location = new System.Drawing.Point(226, 90);
            this.btn_SaveCam1Param.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_SaveCam1Param.Name = "btn_SaveCam1Param";
            this.btn_SaveCam1Param.Size = new System.Drawing.Size(87, 23);
            this.btn_SaveCam1Param.TabIndex = 7;
            this.btn_SaveCam1Param.Text = "保存参数";
            this.btn_SaveCam1Param.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SaveCam1Param.Click += new System.EventHandler(this.btn_SaveCam1Param_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label12.Location = new System.Drawing.Point(20, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 14);
            this.label12.TabIndex = 71;
            this.label12.Text = "相机参数：";
            // 
            // btn_WriteCam1Param
            // 
            this.btn_WriteCam1Param.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_WriteCam1Param.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WriteCam1Param.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WriteCam1Param.Location = new System.Drawing.Point(134, 90);
            this.btn_WriteCam1Param.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_WriteCam1Param.Name = "btn_WriteCam1Param";
            this.btn_WriteCam1Param.Size = new System.Drawing.Size(64, 23);
            this.btn_WriteCam1Param.TabIndex = 1;
            this.btn_WriteCam1Param.Text = "写入";
            this.btn_WriteCam1Param.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_WriteCam1Param.Click += new System.EventHandler(this.btn_WriteCam1Param_Click);
            // 
            // btn_ReadCam1Param
            // 
            this.btn_ReadCam1Param.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_ReadCam1Param.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ReadCam1Param.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadCam1Param.Location = new System.Drawing.Point(45, 90);
            this.btn_ReadCam1Param.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_ReadCam1Param.Name = "btn_ReadCam1Param";
            this.btn_ReadCam1Param.Size = new System.Drawing.Size(64, 23);
            this.btn_ReadCam1Param.TabIndex = 0;
            this.btn_ReadCam1Param.Text = "读取";
            this.btn_ReadCam1Param.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ReadCam1Param.Click += new System.EventHandler(this.btn_ReadCam1Param_Click);
            // 
            // tb_Cam1ExposureTime
            // 
            this.tb_Cam1ExposureTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1ExposureTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1ExposureTime.Location = new System.Drawing.Point(81, 39);
            this.tb_Cam1ExposureTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1ExposureTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_Cam1ExposureTime.Name = "tb_Cam1ExposureTime";
            this.tb_Cam1ExposureTime.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Cam1ExposureTime.ShowText = false;
            this.tb_Cam1ExposureTime.Size = new System.Drawing.Size(61, 25);
            this.tb_Cam1ExposureTime.TabIndex = 2;
            this.tb_Cam1ExposureTime.Text = "0";
            this.tb_Cam1ExposureTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_Cam1ExposureTime.Watermark = "";
            // 
            // tb_Cam1Gain
            // 
            this.tb_Cam1Gain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Gain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Gain.Location = new System.Drawing.Point(209, 39);
            this.tb_Cam1Gain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1Gain.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_Cam1Gain.Name = "tb_Cam1Gain";
            this.tb_Cam1Gain.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Cam1Gain.ShowText = false;
            this.tb_Cam1Gain.Size = new System.Drawing.Size(61, 25);
            this.tb_Cam1Gain.TabIndex = 3;
            this.tb_Cam1Gain.Text = "0";
            this.tb_Cam1Gain.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_Cam1Gain.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "曝光";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(174, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "增益";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cam1Close
            // 
            this.btn_Cam1Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_Cam1Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cam1Close.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam1Close.Location = new System.Drawing.Point(135, 60);
            this.btn_Cam1Close.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Cam1Close.Name = "btn_Cam1Close";
            this.btn_Cam1Close.Size = new System.Drawing.Size(64, 29);
            this.btn_Cam1Close.TabIndex = 72;
            this.btn_Cam1Close.Text = "断开";
            this.btn_Cam1Close.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam1Close.Click += new System.EventHandler(this.btn_Cam1Close_Click);
            // 
            // btn_Cam1Open
            // 
            this.btn_Cam1Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_Cam1Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cam1Open.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam1Open.Location = new System.Drawing.Point(48, 60);
            this.btn_Cam1Open.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Cam1Open.Name = "btn_Cam1Open";
            this.btn_Cam1Open.Size = new System.Drawing.Size(64, 29);
            this.btn_Cam1Open.TabIndex = 71;
            this.btn_Cam1Open.Text = "连接";
            this.btn_Cam1Open.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cam1Open.Click += new System.EventHandler(this.btn_Cam1Open_Click);
            // 
            // ckb_AutoCam1Grabbing
            // 
            this.ckb_AutoCam1Grabbing.AutoSize = true;
            this.ckb_AutoCam1Grabbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckb_AutoCam1Grabbing.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckb_AutoCam1Grabbing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ckb_AutoCam1Grabbing.Location = new System.Drawing.Point(242, 67);
            this.ckb_AutoCam1Grabbing.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckb_AutoCam1Grabbing.Name = "ckb_AutoCam1Grabbing";
            this.ckb_AutoCam1Grabbing.Size = new System.Drawing.Size(76, 21);
            this.ckb_AutoCam1Grabbing.TabIndex = 5;
            this.ckb_AutoCam1Grabbing.Text = "实时画面";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label11.Location = new System.Drawing.Point(23, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 70;
            this.label11.Text = "设备控制：";
            // 
            // lb_Cam1IsOpen
            // 
            this.lb_Cam1IsOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_Cam1IsOpen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1IsOpen.ForeColor = System.Drawing.Color.Red;
            this.lb_Cam1IsOpen.Location = new System.Drawing.Point(106, 20);
            this.lb_Cam1IsOpen.Name = "lb_Cam1IsOpen";
            this.lb_Cam1IsOpen.Size = new System.Drawing.Size(75, 23);
            this.lb_Cam1IsOpen.TabIndex = 23;
            this.lb_Cam1IsOpen.Text = "已断开";
            this.lb_Cam1IsOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cogdispccd1
            // 
            this.cogdispccd1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogdispccd1.ColorMapLowerRoiLimit = 0D;
            this.cogdispccd1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogdispccd1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogdispccd1.ColorMapUpperRoiLimit = 1D;
            this.cogdispccd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogdispccd1.DoubleTapZoomCycleLength = 2;
            this.cogdispccd1.DoubleTapZoomSensitivity = 2.5D;
            this.cogdispccd1.Location = new System.Drawing.Point(0, 0);
            this.cogdispccd1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogdispccd1.MouseWheelSensitivity = 1D;
            this.cogdispccd1.Name = "cogdispccd1";
            this.cogdispccd1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogdispccd1.OcxState")));
            this.cogdispccd1.Size = new System.Drawing.Size(734, 535);
            this.cogdispccd1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 575);
            this.panel2.TabIndex = 1;
            this.panel2.Text = null;
            this.panel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTrigger1
            // 
            this.tbTrigger1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTrigger1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTrigger1.Location = new System.Drawing.Point(150, 37);
            this.tbTrigger1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTrigger1.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbTrigger1.Name = "tbTrigger1";
            this.tbTrigger1.Padding = new System.Windows.Forms.Padding(5);
            this.tbTrigger1.ReadOnly = true;
            this.tbTrigger1.ShowText = false;
            this.tbTrigger1.Size = new System.Drawing.Size(44, 25);
            this.tbTrigger1.TabIndex = 5;
            this.tbTrigger1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbTrigger1.Watermark = "";
            // 
            // tbAlign1C
            // 
            this.tbAlign1C.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAlign1C.DoubleValue = 0.033D;
            this.tbAlign1C.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAlign1C.Location = new System.Drawing.Point(238, 76);
            this.tbAlign1C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAlign1C.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbAlign1C.Name = "tbAlign1C";
            this.tbAlign1C.Padding = new System.Windows.Forms.Padding(5);
            this.tbAlign1C.ShowText = false;
            this.tbAlign1C.Size = new System.Drawing.Size(66, 25);
            this.tbAlign1C.TabIndex = 7;
            this.tbAlign1C.Text = "0.033";
            this.tbAlign1C.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAlign1C.Watermark = "";
            // 
            // tbAlign1B
            // 
            this.tbAlign1B.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAlign1B.DoubleValue = -0.026D;
            this.tbAlign1B.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAlign1B.Location = new System.Drawing.Point(167, 76);
            this.tbAlign1B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAlign1B.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbAlign1B.Name = "tbAlign1B";
            this.tbAlign1B.Padding = new System.Windows.Forms.Padding(5);
            this.tbAlign1B.ShowText = false;
            this.tbAlign1B.Size = new System.Drawing.Size(66, 25);
            this.tbAlign1B.TabIndex = 6;
            this.tbAlign1B.Text = "-0.026";
            this.tbAlign1B.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAlign1B.Watermark = "";
            // 
            // tbAlign1A
            // 
            this.tbAlign1A.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAlign1A.DoubleValue = 0.012D;
            this.tbAlign1A.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbAlign1A.Location = new System.Drawing.Point(96, 76);
            this.tbAlign1A.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAlign1A.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbAlign1A.Name = "tbAlign1A";
            this.tbAlign1A.Padding = new System.Windows.Forms.Padding(5);
            this.tbAlign1A.ShowText = false;
            this.tbAlign1A.Size = new System.Drawing.Size(66, 25);
            this.tbAlign1A.TabIndex = 3;
            this.tbAlign1A.Text = "0.012";
            this.tbAlign1A.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbAlign1A.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel1.Location = new System.Drawing.Point(17, 44);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(64, 24);
            this.uiLabel1.TabIndex = 30;
            this.uiLabel1.Text = "点亮触发2";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWpcSignTrigger2
            // 
            this.lblWpcSignTrigger2.AutoSize = true;
            this.lblWpcSignTrigger2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWpcSignTrigger2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblWpcSignTrigger2.Location = new System.Drawing.Point(99, 50);
            this.lblWpcSignTrigger2.Name = "lblWpcSignTrigger2";
            this.lblWpcSignTrigger2.Size = new System.Drawing.Size(17, 12);
            this.lblWpcSignTrigger2.TabIndex = 29;
            this.lblWpcSignTrigger2.Text = "●";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel3.Location = new System.Drawing.Point(140, 44);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(64, 24);
            this.uiLabel3.TabIndex = 34;
            this.uiLabel3.Text = "读码触发2";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(222, 50);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(17, 12);
            this.uiLabel4.TabIndex = 33;
            this.uiLabel4.Text = "●";
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel5.Location = new System.Drawing.Point(140, 11);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(64, 24);
            this.uiLabel5.TabIndex = 32;
            this.uiLabel5.Text = "读码触发1";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(222, 17);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(17, 12);
            this.uiLabel6.TabIndex = 31;
            this.uiLabel6.Text = "●";
            // 
            // Frm_Device
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1089, 610);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Device";
            this.Text = "设备点检";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 880, 460);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Device_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Device_Load);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Plc_ProductAlign.ResumeLayout(false);
            this.panel_Plc_ProductAlign.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Cam1Param.ResumeLayout(false);
            this.panel_Cam1Param.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogdispccd1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIPanel panel1;
        private Sunny.UI.UIButton btn_PlcOpen;
        private Sunny.UI.UILabel lb_PlcIsOpen;
        private Sunny.UI.UIButton btn_PlcClose;
        private Sunny.UI.UIPanel panel2;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UISplitContainer splitContainer1;
        private Sunny.UI.UIPanel panel_Cam1Param;
        private Sunny.UI.UIButton btn_SaveCam1Param;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UIButton btn_WriteCam1Param;
        private Sunny.UI.UIButton btn_ReadCam1Param;
        private Sunny.UI.UITextBox tb_Cam1ExposureTime;
        private Sunny.UI.UITextBox tb_Cam1Gain;
        private Sunny.UI.UILabel label1;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UIButton btn_Cam1Close;
        private Sunny.UI.UIButton btn_Cam1Open;
        private Sunny.UI.UICheckBox ckb_AutoCam1Grabbing;
        private Sunny.UI.UILabel label11;
        private Sunny.UI.UILabel lb_Cam1IsOpen;
        private Cognex.VisionPro.CogRecordDisplay cogdispccd1;
        private Sunny.UI.UITextBox tbTrigger1;
        private Sunny.UI.UITextBox tbAlign1C;
        private Sunny.UI.UITextBox tbAlign1B;
        private Sunny.UI.UITextBox tbAlign1A;
        private Sunny.UI.UIPanel panel_Plc_ProductAlign;
        private Sunny.UI.UILabel label6;
        private Sunny.UI.UILabel lblWpcSignTrigger1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lblWpcSignTrigger2;
    }
}