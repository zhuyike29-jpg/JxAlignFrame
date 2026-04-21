namespace JxAlignVision
{
    partial class frmDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevice));
            this.Tab = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.lblEolSignTrigger = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.lblEolCodeTrigger = new Sunny.UI.UILabel();
            this.panel_Plc_XYR = new Sunny.UI.UIPanel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.lblEolCalcTrigger = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.lblEolJigTrigger = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.lblEolProdTrigger = new Sunny.UI.UILabel();
            this.label9 = new Sunny.UI.UILabel();
            this.btn_MovePlcXYR = new Sunny.UI.UIButton();
            this.txtPlcR = new Sunny.UI.UITextBox();
            this.label5 = new Sunny.UI.UILabel();
            this.label4 = new Sunny.UI.UILabel();
            this.lblPlcR = new Sunny.UI.UILabel();
            this.txtPlcY = new Sunny.UI.UITextBox();
            this.lblPlcY = new Sunny.UI.UILabel();
            this.lblPlcX = new Sunny.UI.UILabel();
            this.txtPlcX = new Sunny.UI.UITextBox();
            this.label3 = new Sunny.UI.UILabel();
            this.cboPlcSel = new Sunny.UI.UIComboBox();
            this.panel_Plc_ProductAlign = new Sunny.UI.UIPanel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.lblWpcSignTrigger2 = new Sunny.UI.UILabel();
            this.lblSignTrigger1111 = new Sunny.UI.UILabel();
            this.lblWpcSignTrigger1 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lblWpcCodeTrigger2 = new Sunny.UI.UILabel();
            this.label6 = new Sunny.UI.UILabel();
            this.lblWpcCodeTrigger1 = new Sunny.UI.UILabel();
            this.btnPlcClose = new Sunny.UI.UIButton();
            this.btnPlcOpen = new Sunny.UI.UIButton();
            this.label8 = new Sunny.UI.UILabel();
            this.lb_PlcIsOpen = new Sunny.UI.UILabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new Sunny.UI.UISplitContainer();
            this.cboCam = new Sunny.UI.UIComboBox();
            this.panel_Cam1Param = new Sunny.UI.UIPanel();
            this.btnSaveCamParam = new Sunny.UI.UIButton();
            this.label12 = new Sunny.UI.UILabel();
            this.btnWriteCamParam = new Sunny.UI.UIButton();
            this.btnReadCamParam = new Sunny.UI.UIButton();
            this.tbCamExposureTime = new Sunny.UI.UITextBox();
            this.tbCamGain = new Sunny.UI.UITextBox();
            this.label1 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.btnCamClose = new Sunny.UI.UIButton();
            this.btnCamOpen = new Sunny.UI.UIButton();
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
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.panel_Plc_XYR.SuspendLayout();
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
            this.panel1.Controls.Add(this.uiPanel1);
            this.panel1.Controls.Add(this.panel_Plc_XYR);
            this.panel1.Controls.Add(this.cboPlcSel);
            this.panel1.Controls.Add(this.panel_Plc_ProductAlign);
            this.panel1.Controls.Add(this.btnPlcClose);
            this.panel1.Controls.Add(this.btnPlcOpen);
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
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel12);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.lblEolSignTrigger);
            this.uiPanel1.Controls.Add(this.uiLabel9);
            this.uiPanel1.Controls.Add(this.lblEolCodeTrigger);
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(3, 360);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1082, 82);
            this.uiPanel1.TabIndex = 77;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.Visible = false;
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel12.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(14, 11);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(70, 14);
            this.uiLabel12.TabIndex = 73;
            this.uiLabel12.Text = "EOL触发：";
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel5.Location = new System.Drawing.Point(148, 38);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(64, 24);
            this.uiLabel5.TabIndex = 32;
            this.uiLabel5.Text = "点亮";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEolSignTrigger
            // 
            this.lblEolSignTrigger.AutoSize = true;
            this.lblEolSignTrigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEolSignTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblEolSignTrigger.Location = new System.Drawing.Point(220, 44);
            this.lblEolSignTrigger.Name = "lblEolSignTrigger";
            this.lblEolSignTrigger.Size = new System.Drawing.Size(17, 12);
            this.lblEolSignTrigger.TabIndex = 31;
            this.lblEolSignTrigger.Text = "●";
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel9.Location = new System.Drawing.Point(27, 38);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(64, 24);
            this.uiLabel9.TabIndex = 28;
            this.uiLabel9.Text = "读码";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEolCodeTrigger
            // 
            this.lblEolCodeTrigger.AutoSize = true;
            this.lblEolCodeTrigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEolCodeTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblEolCodeTrigger.Location = new System.Drawing.Point(105, 44);
            this.lblEolCodeTrigger.Name = "lblEolCodeTrigger";
            this.lblEolCodeTrigger.Size = new System.Drawing.Size(17, 12);
            this.lblEolCodeTrigger.TabIndex = 3;
            this.lblEolCodeTrigger.Text = "●";
            // 
            // panel_Plc_XYR
            // 
            this.panel_Plc_XYR.Controls.Add(this.uiLabel13);
            this.panel_Plc_XYR.Controls.Add(this.lblEolCalcTrigger);
            this.panel_Plc_XYR.Controls.Add(this.uiLabel3);
            this.panel_Plc_XYR.Controls.Add(this.lblEolJigTrigger);
            this.panel_Plc_XYR.Controls.Add(this.uiLabel7);
            this.panel_Plc_XYR.Controls.Add(this.lblEolProdTrigger);
            this.panel_Plc_XYR.Controls.Add(this.label9);
            this.panel_Plc_XYR.Controls.Add(this.btn_MovePlcXYR);
            this.panel_Plc_XYR.Controls.Add(this.txtPlcR);
            this.panel_Plc_XYR.Controls.Add(this.label5);
            this.panel_Plc_XYR.Controls.Add(this.label4);
            this.panel_Plc_XYR.Controls.Add(this.lblPlcR);
            this.panel_Plc_XYR.Controls.Add(this.txtPlcY);
            this.panel_Plc_XYR.Controls.Add(this.lblPlcY);
            this.panel_Plc_XYR.Controls.Add(this.lblPlcX);
            this.panel_Plc_XYR.Controls.Add(this.txtPlcX);
            this.panel_Plc_XYR.Controls.Add(this.label3);
            this.panel_Plc_XYR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Plc_XYR.Location = new System.Drawing.Point(3, 222);
            this.panel_Plc_XYR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Plc_XYR.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_Plc_XYR.Name = "panel_Plc_XYR";
            this.panel_Plc_XYR.Size = new System.Drawing.Size(1082, 112);
            this.panel_Plc_XYR.TabIndex = 76;
            this.panel_Plc_XYR.Text = null;
            this.panel_Plc_XYR.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel13
            // 
            this.uiLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel13.Location = new System.Drawing.Point(278, 70);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(64, 24);
            this.uiLabel13.TabIndex = 77;
            this.uiLabel13.Text = "联合计算";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEolCalcTrigger
            // 
            this.lblEolCalcTrigger.AutoSize = true;
            this.lblEolCalcTrigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEolCalcTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblEolCalcTrigger.Location = new System.Drawing.Point(356, 76);
            this.lblEolCalcTrigger.Name = "lblEolCalcTrigger";
            this.lblEolCalcTrigger.Size = new System.Drawing.Size(17, 12);
            this.lblEolCalcTrigger.TabIndex = 76;
            this.lblEolCalcTrigger.Text = "●";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel3.Location = new System.Drawing.Point(156, 70);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(64, 24);
            this.uiLabel3.TabIndex = 75;
            this.uiLabel3.Text = "治具触发";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEolJigTrigger
            // 
            this.lblEolJigTrigger.AutoSize = true;
            this.lblEolJigTrigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEolJigTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblEolJigTrigger.Location = new System.Drawing.Point(234, 76);
            this.lblEolJigTrigger.Name = "lblEolJigTrigger";
            this.lblEolJigTrigger.Size = new System.Drawing.Size(17, 12);
            this.lblEolJigTrigger.TabIndex = 74;
            this.lblEolJigTrigger.Text = "●";
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel7.Location = new System.Drawing.Point(41, 70);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(64, 24);
            this.uiLabel7.TabIndex = 73;
            this.uiLabel7.Text = "产品触发";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEolProdTrigger
            // 
            this.lblEolProdTrigger.AutoSize = true;
            this.lblEolProdTrigger.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEolProdTrigger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblEolProdTrigger.Location = new System.Drawing.Point(119, 76);
            this.lblEolProdTrigger.Name = "lblEolProdTrigger";
            this.lblEolProdTrigger.Size = new System.Drawing.Size(17, 12);
            this.lblEolProdTrigger.TabIndex = 72;
            this.lblEolProdTrigger.Text = "●";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label9.Location = new System.Drawing.Point(20, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 71;
            this.label9.Text = "机械臂轴动：";
            // 
            // btn_MovePlcXYR
            // 
            this.btn_MovePlcXYR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_MovePlcXYR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MovePlcXYR.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MovePlcXYR.Location = new System.Drawing.Point(702, 35);
            this.btn_MovePlcXYR.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_MovePlcXYR.Name = "btn_MovePlcXYR";
            this.btn_MovePlcXYR.Size = new System.Drawing.Size(63, 26);
            this.btn_MovePlcXYR.TabIndex = 40;
            this.btn_MovePlcXYR.Text = "移动";
            this.btn_MovePlcXYR.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MovePlcXYR.Click += new System.EventHandler(this.btn_MovePlcXYR_Click);
            // 
            // txtPlcR
            // 
            this.txtPlcR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlcR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlcR.Location = new System.Drawing.Point(604, 36);
            this.txtPlcR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlcR.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPlcR.Name = "txtPlcR";
            this.txtPlcR.Padding = new System.Windows.Forms.Padding(5);
            this.txtPlcR.ShowText = false;
            this.txtPlcR.Size = new System.Drawing.Size(64, 25);
            this.txtPlcR.TabIndex = 30;
            this.txtPlcR.Text = "0.000";
            this.txtPlcR.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPlcR.Watermark = "";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label5.Location = new System.Drawing.Point(35, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "机械手X轴";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label4.Location = new System.Drawing.Point(247, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "机械手Y轴";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlcR
            // 
            this.lblPlcR.BackColor = System.Drawing.Color.LightGray;
            this.lblPlcR.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlcR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPlcR.Location = new System.Drawing.Point(539, 35);
            this.lblPlcR.Name = "lblPlcR";
            this.lblPlcR.Size = new System.Drawing.Size(58, 24);
            this.lblPlcR.TabIndex = 32;
            this.lblPlcR.Text = "0.000";
            this.lblPlcR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlcY
            // 
            this.txtPlcY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlcY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlcY.Location = new System.Drawing.Point(393, 36);
            this.txtPlcY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlcY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPlcY.Name = "txtPlcY";
            this.txtPlcY.Padding = new System.Windows.Forms.Padding(5);
            this.txtPlcY.ShowText = false;
            this.txtPlcY.Size = new System.Drawing.Size(64, 25);
            this.txtPlcY.TabIndex = 20;
            this.txtPlcY.Text = "0.000";
            this.txtPlcY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPlcY.Watermark = "";
            // 
            // lblPlcY
            // 
            this.lblPlcY.BackColor = System.Drawing.Color.LightGray;
            this.lblPlcY.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlcY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPlcY.Location = new System.Drawing.Point(328, 35);
            this.lblPlcY.Name = "lblPlcY";
            this.lblPlcY.Size = new System.Drawing.Size(58, 24);
            this.lblPlcY.TabIndex = 30;
            this.lblPlcY.Text = "0.000";
            this.lblPlcY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlcX
            // 
            this.lblPlcX.BackColor = System.Drawing.Color.LightGray;
            this.lblPlcX.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPlcX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPlcX.Location = new System.Drawing.Point(114, 35);
            this.lblPlcX.Name = "lblPlcX";
            this.lblPlcX.Size = new System.Drawing.Size(58, 24);
            this.lblPlcX.TabIndex = 28;
            this.lblPlcX.Text = "0.000";
            this.lblPlcX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPlcX
            // 
            this.txtPlcX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlcX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPlcX.Location = new System.Drawing.Point(179, 36);
            this.txtPlcX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlcX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPlcX.Name = "txtPlcX";
            this.txtPlcX.Padding = new System.Windows.Forms.Padding(5);
            this.txtPlcX.ShowText = false;
            this.txtPlcX.Size = new System.Drawing.Size(64, 25);
            this.txtPlcX.TabIndex = 10;
            this.txtPlcX.Text = "0.000";
            this.txtPlcX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPlcX.Watermark = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(460, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "机械手R轴";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPlcSel
            // 
            this.cboPlcSel.DataSource = null;
            this.cboPlcSel.FillColor = System.Drawing.Color.White;
            this.cboPlcSel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPlcSel.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboPlcSel.Items.AddRange(new object[] {
            "WPC",
            "EOL上料",
            "EOL"});
            this.cboPlcSel.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboPlcSel.Location = new System.Drawing.Point(96, 14);
            this.cboPlcSel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPlcSel.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboPlcSel.Name = "cboPlcSel";
            this.cboPlcSel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboPlcSel.Size = new System.Drawing.Size(119, 29);
            this.cboPlcSel.SymbolSize = 24;
            this.cboPlcSel.TabIndex = 75;
            this.cboPlcSel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboPlcSel.Watermark = "";
            this.cboPlcSel.SelectedIndexChanged += new System.EventHandler(this.cboPlcSel_SelectedIndexChanged);
            // 
            // panel_Plc_ProductAlign
            // 
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel11);
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel2);
            this.panel_Plc_ProductAlign.Controls.Add(this.lblWpcSignTrigger2);
            this.panel_Plc_ProductAlign.Controls.Add(this.lblSignTrigger1111);
            this.panel_Plc_ProductAlign.Controls.Add(this.lblWpcSignTrigger1);
            this.panel_Plc_ProductAlign.Controls.Add(this.uiLabel1);
            this.panel_Plc_ProductAlign.Controls.Add(this.lblWpcCodeTrigger2);
            this.panel_Plc_ProductAlign.Controls.Add(this.label6);
            this.panel_Plc_ProductAlign.Controls.Add(this.lblWpcCodeTrigger1);
            this.panel_Plc_ProductAlign.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Plc_ProductAlign.Location = new System.Drawing.Point(7, 111);
            this.panel_Plc_ProductAlign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Plc_ProductAlign.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_Plc_ProductAlign.Name = "panel_Plc_ProductAlign";
            this.panel_Plc_ProductAlign.Size = new System.Drawing.Size(1078, 101);
            this.panel_Plc_ProductAlign.TabIndex = 71;
            this.panel_Plc_ProductAlign.Text = null;
            this.panel_Plc_ProductAlign.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.panel_Plc_ProductAlign.Visible = false;
            // 
            // uiLabel11
            // 
            this.uiLabel11.AutoSize = true;
            this.uiLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.Location = new System.Drawing.Point(11, 9);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(77, 14);
            this.uiLabel11.TabIndex = 72;
            this.uiLabel11.Text = "WPC 触发：";
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel2.Location = new System.Drawing.Point(146, 62);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(64, 24);
            this.uiLabel2.TabIndex = 34;
            this.uiLabel2.Text = "工位2点亮";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWpcSignTrigger2
            // 
            this.lblWpcSignTrigger2.AutoSize = true;
            this.lblWpcSignTrigger2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWpcSignTrigger2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblWpcSignTrigger2.Location = new System.Drawing.Point(224, 68);
            this.lblWpcSignTrigger2.Name = "lblWpcSignTrigger2";
            this.lblWpcSignTrigger2.Size = new System.Drawing.Size(17, 12);
            this.lblWpcSignTrigger2.TabIndex = 33;
            this.lblWpcSignTrigger2.Text = "●";
            // 
            // lblSignTrigger1111
            // 
            this.lblSignTrigger1111.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lblSignTrigger1111.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSignTrigger1111.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.lblSignTrigger1111.Location = new System.Drawing.Point(146, 29);
            this.lblSignTrigger1111.Name = "lblSignTrigger1111";
            this.lblSignTrigger1111.Size = new System.Drawing.Size(64, 24);
            this.lblSignTrigger1111.TabIndex = 32;
            this.lblSignTrigger1111.Text = "工位1点亮";
            this.lblSignTrigger1111.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWpcSignTrigger1
            // 
            this.lblWpcSignTrigger1.AutoSize = true;
            this.lblWpcSignTrigger1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWpcSignTrigger1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblWpcSignTrigger1.Location = new System.Drawing.Point(224, 35);
            this.lblWpcSignTrigger1.Name = "lblWpcSignTrigger1";
            this.lblWpcSignTrigger1.Size = new System.Drawing.Size(17, 12);
            this.lblWpcSignTrigger1.TabIndex = 31;
            this.lblWpcSignTrigger1.Text = "●";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.uiLabel1.Location = new System.Drawing.Point(31, 62);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(64, 24);
            this.uiLabel1.TabIndex = 30;
            this.uiLabel1.Text = "工位2读码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWpcCodeTrigger2
            // 
            this.lblWpcCodeTrigger2.AutoSize = true;
            this.lblWpcCodeTrigger2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWpcCodeTrigger2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblWpcCodeTrigger2.Location = new System.Drawing.Point(109, 68);
            this.lblWpcCodeTrigger2.Name = "lblWpcCodeTrigger2";
            this.lblWpcCodeTrigger2.Size = new System.Drawing.Size(17, 12);
            this.lblWpcCodeTrigger2.TabIndex = 29;
            this.lblWpcCodeTrigger2.Text = "●";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label6.Location = new System.Drawing.Point(31, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "工位1读码";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWpcCodeTrigger1
            // 
            this.lblWpcCodeTrigger1.AutoSize = true;
            this.lblWpcCodeTrigger1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWpcCodeTrigger1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblWpcCodeTrigger1.Location = new System.Drawing.Point(109, 35);
            this.lblWpcCodeTrigger1.Name = "lblWpcCodeTrigger1";
            this.lblWpcCodeTrigger1.Size = new System.Drawing.Size(17, 12);
            this.lblWpcCodeTrigger1.TabIndex = 3;
            this.lblWpcCodeTrigger1.Text = "●";
            // 
            // btnPlcClose
            // 
            this.btnPlcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnPlcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlcClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlcClose.Location = new System.Drawing.Point(135, 60);
            this.btnPlcClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPlcClose.Name = "btnPlcClose";
            this.btnPlcClose.Size = new System.Drawing.Size(64, 29);
            this.btnPlcClose.TabIndex = 25;
            this.btnPlcClose.Text = "断开";
            this.btnPlcClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlcClose.Click += new System.EventHandler(this.btnPlcClose_Click);
            // 
            // btnPlcOpen
            // 
            this.btnPlcOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnPlcOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlcOpen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlcOpen.Location = new System.Drawing.Point(48, 60);
            this.btnPlcOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPlcOpen.Name = "btnPlcOpen";
            this.btnPlcOpen.Size = new System.Drawing.Size(64, 29);
            this.btnPlcOpen.TabIndex = 24;
            this.btnPlcOpen.Text = "连接";
            this.btnPlcOpen.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlcOpen.Click += new System.EventHandler(this.btnPlcOpen_Click);
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
            this.lb_PlcIsOpen.Location = new System.Drawing.Point(211, 20);
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
            this.tabPage2.Text = "相机";
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
            this.splitContainer1.Panel1.Controls.Add(this.cboCam);
            this.splitContainer1.Panel1.Controls.Add(this.panel_Cam1Param);
            this.splitContainer1.Panel1.Controls.Add(this.btnCamClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnCamOpen);
            this.splitContainer1.Panel1.Controls.Add(this.ckb_AutoCam1Grabbing);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.lb_Cam1IsOpen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cogdispccd1);
            this.splitContainer1.Size = new System.Drawing.Size(1089, 535);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.SplitterWidth = 11;
            this.splitContainer1.TabIndex = 0;
            // 
            // cboCam
            // 
            this.cboCam.DataSource = null;
            this.cboCam.FillColor = System.Drawing.Color.White;
            this.cboCam.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboCam.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboCam.Items.AddRange(new object[] {
            "WPC 相机1",
            "WPC 相机2",
            "EOL 产品相机",
            "EOL 治具相机",
            "EOL 读码点亮相机"});
            this.cboCam.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboCam.Location = new System.Drawing.Point(98, 17);
            this.cboCam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCam.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboCam.Name = "cboCam";
            this.cboCam.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboCam.Size = new System.Drawing.Size(150, 29);
            this.cboCam.SymbolSize = 24;
            this.cboCam.TabIndex = 74;
            this.cboCam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboCam.Watermark = "";
            this.cboCam.SelectedIndexChanged += new System.EventHandler(this.cboCam_SelectedIndexChanged);
            // 
            // panel_Cam1Param
            // 
            this.panel_Cam1Param.Controls.Add(this.btnSaveCamParam);
            this.panel_Cam1Param.Controls.Add(this.label12);
            this.panel_Cam1Param.Controls.Add(this.btnWriteCamParam);
            this.panel_Cam1Param.Controls.Add(this.btnReadCamParam);
            this.panel_Cam1Param.Controls.Add(this.tbCamExposureTime);
            this.panel_Cam1Param.Controls.Add(this.tbCamGain);
            this.panel_Cam1Param.Controls.Add(this.label1);
            this.panel_Cam1Param.Controls.Add(this.label2);
            this.panel_Cam1Param.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_Cam1Param.Location = new System.Drawing.Point(3, 123);
            this.panel_Cam1Param.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Cam1Param.MinimumSize = new System.Drawing.Size(1, 1);
            this.panel_Cam1Param.Name = "panel_Cam1Param";
            this.panel_Cam1Param.Size = new System.Drawing.Size(337, 140);
            this.panel_Cam1Param.TabIndex = 73;
            this.panel_Cam1Param.Text = null;
            this.panel_Cam1Param.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveCamParam
            // 
            this.btnSaveCamParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnSaveCamParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCamParam.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveCamParam.Location = new System.Drawing.Point(226, 90);
            this.btnSaveCamParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSaveCamParam.Name = "btnSaveCamParam";
            this.btnSaveCamParam.Size = new System.Drawing.Size(87, 23);
            this.btnSaveCamParam.TabIndex = 7;
            this.btnSaveCamParam.Text = "保存参数";
            this.btnSaveCamParam.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveCamParam.Click += new System.EventHandler(this.btnSaveCamParam_Click);
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
            // btnWriteCamParam
            // 
            this.btnWriteCamParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnWriteCamParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWriteCamParam.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteCamParam.Location = new System.Drawing.Point(134, 90);
            this.btnWriteCamParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnWriteCamParam.Name = "btnWriteCamParam";
            this.btnWriteCamParam.Size = new System.Drawing.Size(64, 23);
            this.btnWriteCamParam.TabIndex = 1;
            this.btnWriteCamParam.Text = "写入";
            this.btnWriteCamParam.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWriteCamParam.Click += new System.EventHandler(this.btnWriteCamParam_Click);
            // 
            // btnReadCamParam
            // 
            this.btnReadCamParam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnReadCamParam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReadCamParam.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadCamParam.Location = new System.Drawing.Point(45, 90);
            this.btnReadCamParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnReadCamParam.Name = "btnReadCamParam";
            this.btnReadCamParam.Size = new System.Drawing.Size(64, 23);
            this.btnReadCamParam.TabIndex = 0;
            this.btnReadCamParam.Text = "读取";
            this.btnReadCamParam.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReadCamParam.Click += new System.EventHandler(this.btnReadCamParam_Click);
            // 
            // tbCamExposureTime
            // 
            this.tbCamExposureTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCamExposureTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCamExposureTime.Location = new System.Drawing.Point(81, 39);
            this.tbCamExposureTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCamExposureTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCamExposureTime.Name = "tbCamExposureTime";
            this.tbCamExposureTime.Padding = new System.Windows.Forms.Padding(5);
            this.tbCamExposureTime.ShowText = false;
            this.tbCamExposureTime.Size = new System.Drawing.Size(61, 25);
            this.tbCamExposureTime.TabIndex = 2;
            this.tbCamExposureTime.Text = "0";
            this.tbCamExposureTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCamExposureTime.Watermark = "";
            // 
            // tbCamGain
            // 
            this.tbCamGain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCamGain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCamGain.Location = new System.Drawing.Point(209, 39);
            this.tbCamGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCamGain.MinimumSize = new System.Drawing.Size(1, 16);
            this.tbCamGain.Name = "tbCamGain";
            this.tbCamGain.Padding = new System.Windows.Forms.Padding(5);
            this.tbCamGain.ShowText = false;
            this.tbCamGain.Size = new System.Drawing.Size(61, 25);
            this.tbCamGain.TabIndex = 3;
            this.tbCamGain.Text = "0";
            this.tbCamGain.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbCamGain.Watermark = "";
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
            // btnCamClose
            // 
            this.btnCamClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnCamClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCamClose.Location = new System.Drawing.Point(118, 60);
            this.btnCamClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCamClose.Name = "btnCamClose";
            this.btnCamClose.Size = new System.Drawing.Size(64, 29);
            this.btnCamClose.TabIndex = 72;
            this.btnCamClose.Text = "断开";
            this.btnCamClose.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCamClose.Click += new System.EventHandler(this.btnCamClose_Click);
            // 
            // btnCamOpen
            // 
            this.btnCamOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnCamOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCamOpen.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCamOpen.Location = new System.Drawing.Point(48, 60);
            this.btnCamOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCamOpen.Name = "btnCamOpen";
            this.btnCamOpen.Size = new System.Drawing.Size(64, 29);
            this.btnCamOpen.TabIndex = 71;
            this.btnCamOpen.Text = "连接";
            this.btnCamOpen.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCamOpen.Click += new System.EventHandler(this.btnCamOpen_Click);
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
            this.label11.Location = new System.Drawing.Point(23, 24);
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
            this.lb_Cam1IsOpen.Location = new System.Drawing.Point(255, 20);
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
            this.cogdispccd1.Size = new System.Drawing.Size(720, 535);
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
            // frmDevice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1089, 610);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevice";
            this.Text = "设备点检";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 880, 460);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Device_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Device_Load);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.panel_Plc_XYR.ResumeLayout(false);
            this.panel_Plc_XYR.PerformLayout();
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
        private Sunny.UI.UIButton btnPlcOpen;
        private Sunny.UI.UILabel lb_PlcIsOpen;
        private Sunny.UI.UIButton btnPlcClose;
        private Sunny.UI.UIPanel panel2;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UISplitContainer splitContainer1;
        private Sunny.UI.UIPanel panel_Cam1Param;
        private Sunny.UI.UIButton btnSaveCamParam;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UIButton btnWriteCamParam;
        private Sunny.UI.UIButton btnReadCamParam;
        private Sunny.UI.UITextBox tbCamExposureTime;
        private Sunny.UI.UITextBox tbCamGain;
        private Sunny.UI.UILabel label1;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UIButton btnCamClose;
        private Sunny.UI.UIButton btnCamOpen;
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
        private Sunny.UI.UILabel lblWpcCodeTrigger1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel lblWpcSignTrigger2;
        private Sunny.UI.UILabel lblSignTrigger1111;
        private Sunny.UI.UILabel lblWpcSignTrigger1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lblWpcCodeTrigger2;
        private Sunny.UI.UIComboBox cboCam;
        private Sunny.UI.UIComboBox cboPlcSel;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel lblEolSignTrigger;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel lblEolCodeTrigger;
        private Sunny.UI.UIPanel panel_Plc_XYR;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UIButton btn_MovePlcXYR;
        private Sunny.UI.UITextBox txtPlcR;
        private Sunny.UI.UILabel label5;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UILabel lblPlcR;
        private Sunny.UI.UITextBox txtPlcY;
        private Sunny.UI.UILabel lblPlcY;
        private Sunny.UI.UILabel lblPlcX;
        private Sunny.UI.UITextBox txtPlcX;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel lblEolJigTrigger;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel lblEolProdTrigger;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel lblEolCalcTrigger;
    }
}