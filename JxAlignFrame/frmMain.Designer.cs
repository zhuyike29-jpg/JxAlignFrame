using System.Windows.Forms;

namespace JxAlignVision
{
    partial class frmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.uiStatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_Plc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCam1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel13 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel14 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel16 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel15 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status_User = new System.Windows.Forms.ToolStripStatusLabel();
            this.uiMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenu_Login = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Recipe = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Dubug = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Debug_Device = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Debug_Template = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWpcCam1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWpcCam2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eOL上料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Debug_Calib = new System.Windows.Forms.ToolStripMenuItem();
            this.eOL产品位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eOL治具位标定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu_Param = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new Sunny.UI.UIGroupBox();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new Sunny.UI.UIGroupBox();
            this.ckbAutoGrabbing = new Sunny.UI.UICheckBox();
            this.label4 = new Sunny.UI.UILabel();
            this.btnStop = new Sunny.UI.UIButton();
            this.lb_IsRunning = new Sunny.UI.UILabel();
            this.btnStart = new Sunny.UI.UIButton();
            this.lb_recipe = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label1 = new Sunny.UI.UILabel();
            this.lb_vision = new Sunny.UI.UILabel();
            this.ucDisWpc1 = new JxAlignVision.ucDisplay();
            this.ucDisWpc2 = new JxAlignVision.ucDisplay();
            this.ucDisEolProd = new JxAlignVision.ucDisplay();
            this.ucDisEolJig = new JxAlignVision.ucDisplay();
            this.ucDisEolCs = new JxAlignVision.ucDisplay();
            this.uiStatusStrip1.SuspendLayout();
            this.uiMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiStatusStrip1
            // 
            this.uiStatusStrip1.AutoSize = false;
            this.uiStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.uiStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel1,
            this.status_Plc,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel7,
            this.statusCam1,
            this.toolStripStatusLabel11,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel13,
            this.toolStripStatusLabel14,
            this.toolStripStatusLabel16,
            this.toolStripStatusLabel12,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel15,
            this.toolStripStatusLabel4,
            this.Status_User});
            this.uiStatusStrip1.Location = new System.Drawing.Point(0, 706);
            this.uiStatusStrip1.Name = "uiStatusStrip1";
            this.uiStatusStrip1.Size = new System.Drawing.Size(1221, 32);
            this.uiStatusStrip1.TabIndex = 0;
            this.uiStatusStrip1.Text = "uiStatusStrip1";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(12, 27);
            this.toolStripStatusLabel6.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(55, 27);
            this.toolStripStatusLabel2.Text = "WPC Plc";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(24, 27);
            this.toolStripStatusLabel8.Text = "●";
            this.toolStripStatusLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 27);
            this.toolStripStatusLabel1.Text = "EOL Plc";
            // 
            // status_Plc
            // 
            this.status_Plc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.status_Plc.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.status_Plc.Name = "status_Plc";
            this.status_Plc.Size = new System.Drawing.Size(24, 27);
            this.status_Plc.Text = "●";
            this.status_Plc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(75, 27);
            this.toolStripStatusLabel10.Text = "EOL圆盘 Plc";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.toolStripStatusLabel9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(24, 27);
            this.toolStripStatusLabel9.Text = "●";
            this.toolStripStatusLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(70, 27);
            this.toolStripStatusLabel7.Text = "WPC1 相机";
            // 
            // statusCam1
            // 
            this.statusCam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.statusCam1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusCam1.Name = "statusCam1";
            this.statusCam1.Size = new System.Drawing.Size(24, 27);
            this.statusCam1.Text = "●";
            this.statusCam1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(70, 27);
            this.toolStripStatusLabel11.Text = "WPC2 相机";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(24, 27);
            this.toolStripStatusLabel5.Text = "●";
            this.toolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel13
            // 
            this.toolStripStatusLabel13.Name = "toolStripStatusLabel13";
            this.toolStripStatusLabel13.Size = new System.Drawing.Size(83, 27);
            this.toolStripStatusLabel13.Text = "EOL产品 相机";
            // 
            // toolStripStatusLabel14
            // 
            this.toolStripStatusLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.toolStripStatusLabel14.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel14.Name = "toolStripStatusLabel14";
            this.toolStripStatusLabel14.Size = new System.Drawing.Size(24, 27);
            this.toolStripStatusLabel14.Text = "●";
            this.toolStripStatusLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel16
            // 
            this.toolStripStatusLabel16.Name = "toolStripStatusLabel16";
            this.toolStripStatusLabel16.Size = new System.Drawing.Size(83, 27);
            this.toolStripStatusLabel16.Text = "EOL治具 相机";
            // 
            // toolStripStatusLabel12
            // 
            this.toolStripStatusLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.toolStripStatusLabel12.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel12.Name = "toolStripStatusLabel12";
            this.toolStripStatusLabel12.Size = new System.Drawing.Size(24, 27);
            this.toolStripStatusLabel12.Text = "●";
            this.toolStripStatusLabel12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(83, 27);
            this.toolStripStatusLabel3.Text = "EOL读码 相机";
            // 
            // toolStripStatusLabel15
            // 
            this.toolStripStatusLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.toolStripStatusLabel15.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabel15.Name = "toolStripStatusLabel15";
            this.toolStripStatusLabel15.Size = new System.Drawing.Size(24, 27);
            this.toolStripStatusLabel15.Text = "●";
            this.toolStripStatusLabel15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(68, 27);
            this.toolStripStatusLabel4.Text = "当前用户：";
            // 
            // Status_User
            // 
            this.Status_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.Status_User.Name = "Status_User";
            this.Status_User.Size = new System.Drawing.Size(28, 27);
            this.Status_User.Text = "null";
            // 
            // uiMenuStrip1
            // 
            this.uiMenuStrip1.AutoSize = false;
            this.uiMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.uiMenuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_Login,
            this.StripMenu_Recipe,
            this.StripMenu_Dubug,
            this.StripMenu_Param});
            this.uiMenuStrip1.Location = new System.Drawing.Point(0, 35);
            this.uiMenuStrip1.Name = "uiMenuStrip1";
            this.uiMenuStrip1.Size = new System.Drawing.Size(1221, 37);
            this.uiMenuStrip1.TabIndex = 1;
            this.uiMenuStrip1.Text = "uiMenuStrip1";
            // 
            // StripMenu_Login
            // 
            this.StripMenu_Login.ForeColor = System.Drawing.Color.White;
            this.StripMenu_Login.Name = "StripMenu_Login";
            this.StripMenu_Login.Size = new System.Drawing.Size(64, 33);
            this.StripMenu_Login.Text = "登入";
            this.StripMenu_Login.Click += new System.EventHandler(this.StripMenu_Login_Click);
            // 
            // StripMenu_Recipe
            // 
            this.StripMenu_Recipe.ForeColor = System.Drawing.Color.White;
            this.StripMenu_Recipe.Name = "StripMenu_Recipe";
            this.StripMenu_Recipe.Size = new System.Drawing.Size(104, 33);
            this.StripMenu_Recipe.Text = "配方管理";
            this.StripMenu_Recipe.Click += new System.EventHandler(this.StripMenu_Recipe_Click);
            // 
            // StripMenu_Dubug
            // 
            this.StripMenu_Dubug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu_Debug_Device,
            this.StripMenu_Debug_Template,
            this.StripMenu_Debug_Calib});
            this.StripMenu_Dubug.ForeColor = System.Drawing.Color.White;
            this.StripMenu_Dubug.Name = "StripMenu_Dubug";
            this.StripMenu_Dubug.Size = new System.Drawing.Size(104, 33);
            this.StripMenu_Dubug.Text = "设备调试";
            // 
            // StripMenu_Debug_Device
            // 
            this.StripMenu_Debug_Device.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.StripMenu_Debug_Device.ForeColor = System.Drawing.Color.White;
            this.StripMenu_Debug_Device.Name = "StripMenu_Debug_Device";
            this.StripMenu_Debug_Device.Size = new System.Drawing.Size(164, 32);
            this.StripMenu_Debug_Device.Text = "设备点检";
            this.StripMenu_Debug_Device.Click += new System.EventHandler(this.StripMenu_Debug_Device_Click);
            // 
            // StripMenu_Debug_Template
            // 
            this.StripMenu_Debug_Template.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.StripMenu_Debug_Template.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWpcCam1,
            this.tsmiWpcCam2,
            this.eOL上料ToolStripMenuItem,
            this.eOLToolStripMenuItem});
            this.StripMenu_Debug_Template.ForeColor = System.Drawing.Color.White;
            this.StripMenu_Debug_Template.Name = "StripMenu_Debug_Template";
            this.StripMenu_Debug_Template.Size = new System.Drawing.Size(164, 32);
            this.StripMenu_Debug_Template.Text = "模板调试";
            // 
            // tsmiWpcCam1
            // 
            this.tsmiWpcCam1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.tsmiWpcCam1.ForeColor = System.Drawing.Color.White;
            this.tsmiWpcCam1.Name = "tsmiWpcCam1";
            this.tsmiWpcCam1.Size = new System.Drawing.Size(201, 32);
            this.tsmiWpcCam1.Text = "WPC 1";
            this.tsmiWpcCam1.Click += new System.EventHandler(this.tsmiWpcCam1_Click);
            // 
            // tsmiWpcCam2
            // 
            this.tsmiWpcCam2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.tsmiWpcCam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsmiWpcCam2.ForeColor = System.Drawing.Color.White;
            this.tsmiWpcCam2.Name = "tsmiWpcCam2";
            this.tsmiWpcCam2.Size = new System.Drawing.Size(201, 32);
            this.tsmiWpcCam2.Text = "WPC 2";
            this.tsmiWpcCam2.Click += new System.EventHandler(this.tsmiWpcCam2_Click);
            // 
            // eOL上料ToolStripMenuItem
            // 
            this.eOL上料ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.eOL上料ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eOL上料ToolStripMenuItem.Name = "eOL上料ToolStripMenuItem";
            this.eOL上料ToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.eOL上料ToolStripMenuItem.Text = "EOL上料";
            this.eOL上料ToolStripMenuItem.Click += new System.EventHandler(this.eOL上料ToolStripMenuItem_Click);
            // 
            // eOLToolStripMenuItem
            // 
            this.eOLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.eOLToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eOLToolStripMenuItem.Name = "eOLToolStripMenuItem";
            this.eOLToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.eOLToolStripMenuItem.Text = "EOL读码点亮";
            this.eOLToolStripMenuItem.Click += new System.EventHandler(this.eOLToolStripMenuItem_Click);
            // 
            // StripMenu_Debug_Calib
            // 
            this.StripMenu_Debug_Calib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.StripMenu_Debug_Calib.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eOL产品位ToolStripMenuItem,
            this.eOL治具位标定ToolStripMenuItem});
            this.StripMenu_Debug_Calib.ForeColor = System.Drawing.Color.White;
            this.StripMenu_Debug_Calib.Name = "StripMenu_Debug_Calib";
            this.StripMenu_Debug_Calib.Size = new System.Drawing.Size(164, 32);
            this.StripMenu_Debug_Calib.Text = "相机标定";
            // 
            // eOL产品位ToolStripMenuItem
            // 
            this.eOL产品位ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.eOL产品位ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eOL产品位ToolStripMenuItem.Name = "eOL产品位ToolStripMenuItem";
            this.eOL产品位ToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.eOL产品位ToolStripMenuItem.Text = "EOL产品位标定";
            this.eOL产品位ToolStripMenuItem.Click += new System.EventHandler(this.eOL产品位ToolStripMenuItem_Click);
            // 
            // eOL治具位标定ToolStripMenuItem
            // 
            this.eOL治具位标定ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.eOL治具位标定ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eOL治具位标定ToolStripMenuItem.Name = "eOL治具位标定ToolStripMenuItem";
            this.eOL治具位标定ToolStripMenuItem.Size = new System.Drawing.Size(221, 32);
            this.eOL治具位标定ToolStripMenuItem.Text = "EOL治具位标定";
            this.eOL治具位标定ToolStripMenuItem.Click += new System.EventHandler(this.eOL治具位标定ToolStripMenuItem_Click);
            // 
            // StripMenu_Param
            // 
            this.StripMenu_Param.ForeColor = System.Drawing.Color.White;
            this.StripMenu_Param.Name = "StripMenu_Param";
            this.StripMenu_Param.Size = new System.Drawing.Size(104, 33);
            this.StripMenu_Param.Text = "系统参数";
            this.StripMenu_Param.Click += new System.EventHandler(this.StripMenu_Param_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1221, 634);
            this.splitContainer1.SplitterDistance = 861;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.ucDisWpc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucDisWpc2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucDisEolProd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ucDisEolJig, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ucDisEolCs, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(861, 634);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rtxtLog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox3.Size = new System.Drawing.Size(356, 444);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "实时信息";
            this.groupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtLog.Location = new System.Drawing.Point(0, 32);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(356, 412);
            this.rtxtLog.TabIndex = 0;
            this.rtxtLog.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.ckbAutoGrabbing);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.lb_IsRunning);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.lb_recipe);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lb_vision);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox4.Size = new System.Drawing.Size(356, 190);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "程序信息";
            this.groupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ckbAutoGrabbing
            // 
            this.ckbAutoGrabbing.AutoSize = true;
            this.ckbAutoGrabbing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ckbAutoGrabbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbAutoGrabbing.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckbAutoGrabbing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ckbAutoGrabbing.Location = new System.Drawing.Point(233, 132);
            this.ckbAutoGrabbing.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckbAutoGrabbing.Name = "ckbAutoGrabbing";
            this.ckbAutoGrabbing.Size = new System.Drawing.Size(115, 32);
            this.ckbAutoGrabbing.TabIndex = 27;
            this.ckbAutoGrabbing.Text = "实时图像";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "操作：";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(136, 124);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 48);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lb_IsRunning
            // 
            this.lb_IsRunning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_IsRunning.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_IsRunning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_IsRunning.Location = new System.Drawing.Point(95, 81);
            this.lb_IsRunning.Name = "lb_IsRunning";
            this.lb_IsRunning.Size = new System.Drawing.Size(74, 32);
            this.lb_IsRunning.TabIndex = 26;
            this.lb_IsRunning.Text = "已停止";
            this.lb_IsRunning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(40, 124);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 48);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启动";
            this.btnStart.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lb_recipe
            // 
            this.lb_recipe.AutoSize = true;
            this.lb_recipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_recipe.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_recipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_recipe.Location = new System.Drawing.Point(109, 57);
            this.lb_recipe.Name = "lb_recipe";
            this.lb_recipe.Size = new System.Drawing.Size(60, 21);
            this.lb_recipe.TabIndex = 3;
            this.lb_recipe.Text = "#####";
            this.lb_recipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "配方信息：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "版本信息：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_vision
            // 
            this.lb_vision.AutoSize = true;
            this.lb_vision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_vision.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_vision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_vision.Location = new System.Drawing.Point(109, 32);
            this.lb_vision.Name = "lb_vision";
            this.lb_vision.Size = new System.Drawing.Size(60, 21);
            this.lb_vision.TabIndex = 2;
            this.lb_vision.Text = "#####";
            this.lb_vision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucDisWpc1
            // 
            this.ucDisWpc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisWpc1.Location = new System.Drawing.Point(4, 4);
            this.ucDisWpc1.Name = "ucDisWpc1";
            this.ucDisWpc1.Size = new System.Drawing.Size(279, 309);
            this.ucDisWpc1.TabIndex = 1;
            this.ucDisWpc1.Title = "WPC 读码 点亮 1";
            // 
            // ucDisWpc2
            // 
            this.ucDisWpc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisWpc2.Location = new System.Drawing.Point(290, 4);
            this.ucDisWpc2.Name = "ucDisWpc2";
            this.ucDisWpc2.Size = new System.Drawing.Size(279, 309);
            this.ucDisWpc2.TabIndex = 2;
            this.ucDisWpc2.Title = "WPC 读码 点亮 2";
            // 
            // ucDisEolProd
            // 
            this.ucDisEolProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisEolProd.Location = new System.Drawing.Point(4, 320);
            this.ucDisEolProd.Name = "ucDisEolProd";
            this.ucDisEolProd.Size = new System.Drawing.Size(279, 310);
            this.ucDisEolProd.TabIndex = 3;
            this.ucDisEolProd.Title = "EOL 产品对位";
            // 
            // ucDisEolJig
            // 
            this.ucDisEolJig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisEolJig.Location = new System.Drawing.Point(290, 320);
            this.ucDisEolJig.Name = "ucDisEolJig";
            this.ucDisEolJig.Size = new System.Drawing.Size(279, 310);
            this.ucDisEolJig.TabIndex = 4;
            this.ucDisEolJig.Title = "EOL 治具";
            // 
            // ucDisEolCs
            // 
            this.ucDisEolCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDisEolCs.Location = new System.Drawing.Point(576, 320);
            this.ucDisEolCs.Name = "ucDisEolCs";
            this.ucDisEolCs.Size = new System.Drawing.Size(281, 310);
            this.ucDisEolCs.TabIndex = 5;
            this.ucDisEolCs.Title = "EOL 读码 点亮";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1221, 738);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.uiStatusStrip1);
            this.Controls.Add(this.uiMenuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.uiMenuStrip1;
            this.Name = "frmMain";
            this.Text = "视觉软件";
            this.TitleFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1221, 738);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.uiStatusStrip1.ResumeLayout(false);
            this.uiStatusStrip1.PerformLayout();
            this.uiMenuStrip1.ResumeLayout(false);
            this.uiMenuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip uiStatusStrip1;
        private System.Windows.Forms.MenuStrip uiMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_Login;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_Recipe;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_Dubug;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_Debug_Device;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_Debug_Template;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_Debug_Calib;
        private System.Windows.Forms.ToolStripMenuItem StripMenu_Param;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel status_Plc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel Status_User;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private Sunny.UI.UIGroupBox groupBox4;
        private Sunny.UI.UICheckBox ckbAutoGrabbing;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UIButton btnStop;
        private Sunny.UI.UILabel lb_IsRunning;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UILabel lb_recipe;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label1;
        private Sunny.UI.UILabel lb_vision;
        private Sunny.UI.UIGroupBox groupBox3;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ucDisplay ucDisWpc1;
        private ucDisplay ucDisWpc2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel statusCam1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private ucDisplay ucDisEolProd;
        private ucDisplay ucDisEolJig;
        private ucDisplay ucDisEolCs;
        private ToolStripMenuItem tsmiWpcCam1;
        private ToolStripMenuItem tsmiWpcCam2;
        private ToolStripMenuItem eOL产品位ToolStripMenuItem;
        private ToolStripMenuItem eOL治具位标定ToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripStatusLabel toolStripStatusLabel10;
        private ToolStripStatusLabel toolStripStatusLabel9;
        private ToolStripStatusLabel toolStripStatusLabel11;
        private ToolStripStatusLabel toolStripStatusLabel13;
        private ToolStripStatusLabel toolStripStatusLabel14;
        private ToolStripStatusLabel toolStripStatusLabel12;
        private ToolStripStatusLabel toolStripStatusLabel16;
        private ToolStripStatusLabel toolStripStatusLabel15;
        private ToolStripMenuItem eOL上料ToolStripMenuItem;
        private ToolStripMenuItem eOLToolStripMenuItem;
    }
}

