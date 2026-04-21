namespace JxAlignVision
{
    partial class frmEolCalib
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEolCalib));
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label24 = new Sunny.UI.UILabel();
            this.nud_iteration = new System.Windows.Forms.NumericUpDown();
            this.label22 = new Sunny.UI.UILabel();
            this.nud_delay = new System.Windows.Forms.NumericUpDown();
            this.nud_pix = new System.Windows.Forms.NumericUpDown();
            this.label23 = new Sunny.UI.UILabel();
            this.lb_c = new Sunny.UI.UILabel();
            this.label19 = new Sunny.UI.UILabel();
            this.label16 = new Sunny.UI.UILabel();
            this.label17 = new Sunny.UI.UILabel();
            this.lb_img2robpos = new Sunny.UI.UILabel();
            this.lb_mat = new Sunny.UI.UILabel();
            this.label6 = new Sunny.UI.UILabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nud_verify_dr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new Sunny.UI.UILabel();
            this.nud_verify_limitr = new System.Windows.Forms.NumericUpDown();
            this.btn_Calib = new Sunny.UI.UIButton();
            this.label9 = new Sunny.UI.UILabel();
            this.label8 = new Sunny.UI.UILabel();
            this.btn_RunVpp = new Sunny.UI.UIButton();
            this.ckb_AutoGrabbing = new Sunny.UI.UICheckBox();
            this.label1 = new Sunny.UI.UILabel();
            this.lb_imagepos = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.label7 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.btn_EditVpp = new Sunny.UI.UIButton();
            this.nud_dx = new System.Windows.Forms.NumericUpDown();
            this.nud_dy = new System.Windows.Forms.NumericUpDown();
            this.nud_dr = new System.Windows.Forms.NumericUpDown();
            this.cogDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new Sunny.UI.UIButton();
            this.label18 = new Sunny.UI.UILabel();
            this.label15 = new Sunny.UI.UILabel();
            this.label20 = new Sunny.UI.UILabel();
            this.tb_run_movetarget = new Sunny.UI.UITextBox();
            this.label13 = new Sunny.UI.UILabel();
            this.button4 = new Sunny.UI.UIButton();
            this.label14 = new Sunny.UI.UILabel();
            this.tb_run_img2rob = new Sunny.UI.UITextBox();
            this.label12 = new Sunny.UI.UILabel();
            this.label11 = new Sunny.UI.UILabel();
            this.tb_teach_img2rob = new Sunny.UI.UITextBox();
            this.label10 = new Sunny.UI.UILabel();
            this.button1 = new Sunny.UI.UIButton();
            this.label5 = new Sunny.UI.UILabel();
            this.button2 = new Sunny.UI.UIButton();
            this.tb_teach_tool = new Sunny.UI.UITextBox();
            this.button3 = new Sunny.UI.UIButton();
            this.tb_teach_downpt = new Sunny.UI.UITextBox();
            this.tb_teach_imgpt = new Sunny.UI.UITextBox();
            this.tb_teach_robpt = new Sunny.UI.UITextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_iteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verify_dr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verify_limitr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(1069, 610);
            this.Tab.TabIndex = 0;
            this.Tab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Tab_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1061, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "标定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label24);
            this.splitContainer1.Panel1.Controls.Add(this.nud_iteration);
            this.splitContainer1.Panel1.Controls.Add(this.label22);
            this.splitContainer1.Panel1.Controls.Add(this.nud_delay);
            this.splitContainer1.Panel1.Controls.Add(this.nud_pix);
            this.splitContainer1.Panel1.Controls.Add(this.label23);
            this.splitContainer1.Panel1.Controls.Add(this.lb_c);
            this.splitContainer1.Panel1.Controls.Add(this.label19);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label17);
            this.splitContainer1.Panel1.Controls.Add(this.lb_img2robpos);
            this.splitContainer1.Panel1.Controls.Add(this.lb_mat);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.nud_verify_dr);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.nud_verify_limitr);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Calib);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.btn_RunVpp);
            this.splitContainer1.Panel1.Controls.Add(this.ckb_AutoGrabbing);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lb_imagepos);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btn_EditVpp);
            this.splitContainer1.Panel1.Controls.Add(this.nud_dx);
            this.splitContainer1.Panel1.Controls.Add(this.nud_dy);
            this.splitContainer1.Panel1.Controls.Add(this.nud_dr);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cogDisplay1);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 580);
            this.splitContainer1.SplitterDistance = 473;
            this.splitContainer1.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label24.Location = new System.Drawing.Point(162, 212);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(87, 16);
            this.label24.TabIndex = 56;
            this.label24.Text = "迭代次数：";
            // 
            // nud_iteration
            // 
            this.nud_iteration.Location = new System.Drawing.Point(255, 207);
            this.nud_iteration.Name = "nud_iteration";
            this.nud_iteration.Size = new System.Drawing.Size(55, 26);
            this.nud_iteration.TabIndex = 57;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label22.Location = new System.Drawing.Point(197, 179);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 16);
            this.label22.TabIndex = 48;
            this.label22.Text = "拍照延时(ms)：";
            // 
            // nud_delay
            // 
            this.nud_delay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_delay.Location = new System.Drawing.Point(319, 177);
            this.nud_delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_delay.Name = "nud_delay";
            this.nud_delay.Size = new System.Drawing.Size(72, 26);
            this.nud_delay.TabIndex = 49;
            this.nud_delay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nud_pix
            // 
            this.nud_pix.DecimalPlaces = 1;
            this.nud_pix.Location = new System.Drawing.Point(133, 177);
            this.nud_pix.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_pix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_pix.Name = "nud_pix";
            this.nud_pix.Size = new System.Drawing.Size(55, 26);
            this.nud_pix.TabIndex = 47;
            this.nud_pix.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label23.Location = new System.Drawing.Point(18, 179);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 16);
            this.label23.TabIndex = 46;
            this.label23.Text = "校验精度(um)：";
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_c.Location = new System.Drawing.Point(411, 212);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(31, 16);
            this.lb_c.TabIndex = 41;
            this.lb_c.Text = "###";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label19.Location = new System.Drawing.Point(318, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "iteration:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label16.Location = new System.Drawing.Point(9, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 12);
            this.label16.TabIndex = 33;
            this.label16.Text = "1.标定前准备";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label17.Location = new System.Drawing.Point(9, 212);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "2.标定";
            // 
            // lb_img2robpos
            // 
            this.lb_img2robpos.AutoSize = true;
            this.lb_img2robpos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_img2robpos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_img2robpos.Location = new System.Drawing.Point(111, 91);
            this.lb_img2robpos.Name = "lb_img2robpos";
            this.lb_img2robpos.Size = new System.Drawing.Size(31, 16);
            this.lb_img2robpos.TabIndex = 16;
            this.lb_img2robpos.Text = "###";
            // 
            // lb_mat
            // 
            this.lb_mat.AutoSize = true;
            this.lb_mat.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_mat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_mat.Location = new System.Drawing.Point(72, 244);
            this.lb_mat.Name = "lb_mat";
            this.lb_mat.Size = new System.Drawing.Size(31, 16);
            this.lb_mat.TabIndex = 4;
            this.lb_mat.Text = "###";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label6.Location = new System.Drawing.Point(20, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Img2RobPt:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column9,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(454, 305);
            this.dataGridView1.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RobX";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RobY";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "RobR";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ImgX";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ImgY";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ImgR";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nud_verify_dr
            // 
            this.nud_verify_dr.DecimalPlaces = 1;
            this.nud_verify_dr.Location = new System.Drawing.Point(317, 145);
            this.nud_verify_dr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_verify_dr.Name = "nud_verify_dr";
            this.nud_verify_dr.Size = new System.Drawing.Size(55, 26);
            this.nud_verify_dr.TabIndex = 14;
            this.nud_verify_dr.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label4.Location = new System.Drawing.Point(25, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mat:";
            // 
            // nud_verify_limitr
            // 
            this.nud_verify_limitr.DecimalPlaces = 1;
            this.nud_verify_limitr.Location = new System.Drawing.Point(133, 145);
            this.nud_verify_limitr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_verify_limitr.Name = "nud_verify_limitr";
            this.nud_verify_limitr.Size = new System.Drawing.Size(55, 26);
            this.nud_verify_limitr.TabIndex = 13;
            this.nud_verify_limitr.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_Calib
            // 
            this.btn_Calib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_Calib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Calib.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Calib.Location = new System.Drawing.Point(70, 207);
            this.btn_Calib.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Calib.Name = "btn_Calib";
            this.btn_Calib.Size = new System.Drawing.Size(75, 23);
            this.btn_Calib.TabIndex = 0;
            this.btn_Calib.Text = "标定";
            this.btn_Calib.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Calib.Click += new System.EventHandler(this.btn_Calib_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label9.Location = new System.Drawing.Point(194, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "校验角度间距：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label8.Location = new System.Drawing.Point(18, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "校验角度上限：";
            // 
            // btn_RunVpp
            // 
            this.btn_RunVpp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_RunVpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RunVpp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RunVpp.Location = new System.Drawing.Point(25, 35);
            this.btn_RunVpp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_RunVpp.Name = "btn_RunVpp";
            this.btn_RunVpp.Size = new System.Drawing.Size(75, 23);
            this.btn_RunVpp.TabIndex = 6;
            this.btn_RunVpp.Text = "运行vpp";
            this.btn_RunVpp.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_RunVpp.Click += new System.EventHandler(this.btn_RunVpp_Click);
            // 
            // ckb_AutoGrabbing
            // 
            this.ckb_AutoGrabbing.AutoSize = true;
            this.ckb_AutoGrabbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckb_AutoGrabbing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckb_AutoGrabbing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.ckb_AutoGrabbing.Location = new System.Drawing.Point(208, 39);
            this.ckb_AutoGrabbing.MinimumSize = new System.Drawing.Size(1, 1);
            this.ckb_AutoGrabbing.Name = "ckb_AutoGrabbing";
            this.ckb_AutoGrabbing.Size = new System.Drawing.Size(94, 21);
            this.ckb_AutoGrabbing.TabIndex = 10;
            this.ckb_AutoGrabbing.Text = "实时图像";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(19, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "移动间距x:";
            // 
            // lb_imagepos
            // 
            this.lb_imagepos.AutoSize = true;
            this.lb_imagepos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_imagepos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_imagepos.Location = new System.Drawing.Point(111, 67);
            this.lb_imagepos.Name = "lb_imagepos";
            this.lb_imagepos.Size = new System.Drawing.Size(31, 16);
            this.lb_imagepos.TabIndex = 9;
            this.lb_imagepos.Text = "###";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(170, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "移动间距y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label7.Location = new System.Drawing.Point(32, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "ImagePt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(318, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "旋转间距r:";
            // 
            // btn_EditVpp
            // 
            this.btn_EditVpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditVpp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_EditVpp.Location = new System.Drawing.Point(118, 35);
            this.btn_EditVpp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_EditVpp.Name = "btn_EditVpp";
            this.btn_EditVpp.Size = new System.Drawing.Size(75, 23);
            this.btn_EditVpp.TabIndex = 7;
            this.btn_EditVpp.Text = "修改vpp";
            this.btn_EditVpp.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_EditVpp.Click += new System.EventHandler(this.btn_EditVpp_Click);
            // 
            // nud_dx
            // 
            this.nud_dx.DecimalPlaces = 1;
            this.nud_dx.Location = new System.Drawing.Point(107, 114);
            this.nud_dx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_dx.Name = "nud_dx";
            this.nud_dx.Size = new System.Drawing.Size(55, 26);
            this.nud_dx.TabIndex = 3;
            this.nud_dx.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nud_dy
            // 
            this.nud_dy.DecimalPlaces = 1;
            this.nud_dy.Location = new System.Drawing.Point(257, 114);
            this.nud_dy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_dy.Name = "nud_dy";
            this.nud_dy.Size = new System.Drawing.Size(55, 26);
            this.nud_dy.TabIndex = 4;
            this.nud_dy.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nud_dr
            // 
            this.nud_dr.DecimalPlaces = 1;
            this.nud_dr.Location = new System.Drawing.Point(411, 114);
            this.nud_dr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_dr.Name = "nud_dr";
            this.nud_dr.Size = new System.Drawing.Size(55, 26);
            this.nud_dr.TabIndex = 5;
            this.nud_dr.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(584, 580);
            this.cogDisplay1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.tb_run_movetarget);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tb_run_img2rob);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tb_teach_img2rob);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.tb_teach_tool);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.tb_teach_downpt);
            this.tabPage2.Controls.Add(this.tb_teach_imgpt);
            this.tabPage2.Controls.Add(this.tb_teach_robpt);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1061, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "测试";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.button5.Location = new System.Drawing.Point(424, 313);
            this.button5.MinimumSize = new System.Drawing.Size(1, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "计算并移动";
            this.button5.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label18.Location = new System.Drawing.Point(17, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 12);
            this.label18.TabIndex = 39;
            this.label18.Text = "1.示教";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label15.Location = new System.Drawing.Point(23, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "target:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label20.Location = new System.Drawing.Point(17, 243);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 12);
            this.label20.TabIndex = 38;
            this.label20.Text = "2.验证";
            // 
            // tb_run_movetarget
            // 
            this.tb_run_movetarget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_run_movetarget.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_run_movetarget.Location = new System.Drawing.Point(87, 313);
            this.tb_run_movetarget.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_run_movetarget.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_run_movetarget.Name = "tb_run_movetarget";
            this.tb_run_movetarget.Padding = new System.Windows.Forms.Padding(5);
            this.tb_run_movetarget.ShowText = false;
            this.tb_run_movetarget.Size = new System.Drawing.Size(308, 21);
            this.tb_run_movetarget.TabIndex = 14;
            this.tb_run_movetarget.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_run_movetarget.Watermark = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label13.Location = new System.Drawing.Point(35, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "tool:";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.button4.Location = new System.Drawing.Point(424, 273);
            this.button4.MinimumSize = new System.Drawing.Size(1, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "拍照";
            this.button4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label14.Location = new System.Drawing.Point(19, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "img2rob:";
            // 
            // tb_run_img2rob
            // 
            this.tb_run_img2rob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_run_img2rob.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_run_img2rob.Location = new System.Drawing.Point(87, 275);
            this.tb_run_img2rob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_run_img2rob.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_run_img2rob.Name = "tb_run_img2rob";
            this.tb_run_img2rob.Padding = new System.Windows.Forms.Padding(5);
            this.tb_run_img2rob.ShowText = false;
            this.tb_run_img2rob.Size = new System.Drawing.Size(308, 21);
            this.tb_run_img2rob.TabIndex = 11;
            this.tb_run_img2rob.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_run_img2rob.Watermark = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label12.Location = new System.Drawing.Point(23, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "downpt:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label11.Location = new System.Drawing.Point(19, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "img2rob:";
            // 
            // tb_teach_img2rob
            // 
            this.tb_teach_img2rob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_teach_img2rob.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_teach_img2rob.Location = new System.Drawing.Point(87, 113);
            this.tb_teach_img2rob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_teach_img2rob.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_teach_img2rob.Name = "tb_teach_img2rob";
            this.tb_teach_img2rob.Padding = new System.Windows.Forms.Padding(5);
            this.tb_teach_img2rob.ShowText = false;
            this.tb_teach_img2rob.Size = new System.Drawing.Size(308, 21);
            this.tb_teach_img2rob.TabIndex = 5;
            this.tb_teach_img2rob.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_teach_img2rob.Watermark = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label10.Location = new System.Drawing.Point(29, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "robpt:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(424, 38);
            this.button1.MinimumSize = new System.Drawing.Size(1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "拍照示教";
            this.button1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label5.Location = new System.Drawing.Point(29, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "imgpt:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(424, 147);
            this.button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "下料点示教";
            this.button2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_teach_tool
            // 
            this.tb_teach_tool.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_teach_tool.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_teach_tool.Location = new System.Drawing.Point(87, 186);
            this.tb_teach_tool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_teach_tool.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_teach_tool.Name = "tb_teach_tool";
            this.tb_teach_tool.Padding = new System.Windows.Forms.Padding(5);
            this.tb_teach_tool.ShowText = false;
            this.tb_teach_tool.Size = new System.Drawing.Size(308, 21);
            this.tb_teach_tool.TabIndex = 7;
            this.tb_teach_tool.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_teach_tool.Watermark = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(424, 184);
            this.button3.MinimumSize = new System.Drawing.Size(1, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "计算";
            this.button3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_teach_downpt
            // 
            this.tb_teach_downpt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_teach_downpt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_teach_downpt.Location = new System.Drawing.Point(87, 149);
            this.tb_teach_downpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_teach_downpt.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_teach_downpt.Name = "tb_teach_downpt";
            this.tb_teach_downpt.Padding = new System.Windows.Forms.Padding(5);
            this.tb_teach_downpt.ShowText = false;
            this.tb_teach_downpt.Size = new System.Drawing.Size(308, 21);
            this.tb_teach_downpt.TabIndex = 6;
            this.tb_teach_downpt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_teach_downpt.Watermark = "";
            // 
            // tb_teach_imgpt
            // 
            this.tb_teach_imgpt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_teach_imgpt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_teach_imgpt.Location = new System.Drawing.Point(87, 40);
            this.tb_teach_imgpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_teach_imgpt.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_teach_imgpt.Name = "tb_teach_imgpt";
            this.tb_teach_imgpt.Padding = new System.Windows.Forms.Padding(5);
            this.tb_teach_imgpt.ShowText = false;
            this.tb_teach_imgpt.Size = new System.Drawing.Size(308, 21);
            this.tb_teach_imgpt.TabIndex = 3;
            this.tb_teach_imgpt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_teach_imgpt.Watermark = "";
            // 
            // tb_teach_robpt
            // 
            this.tb_teach_robpt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_teach_robpt.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_teach_robpt.Location = new System.Drawing.Point(87, 77);
            this.tb_teach_robpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_teach_robpt.MinimumSize = new System.Drawing.Size(1, 16);
            this.tb_teach_robpt.Name = "tb_teach_robpt";
            this.tb_teach_robpt.Padding = new System.Windows.Forms.Padding(5);
            this.tb_teach_robpt.ShowText = false;
            this.tb_teach_robpt.Size = new System.Drawing.Size(308, 21);
            this.tb_teach_robpt.TabIndex = 4;
            this.tb_teach_robpt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_teach_robpt.Watermark = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Tab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 610);
            this.panel1.TabIndex = 1;
            // 
            // Frm_CalibMove
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1069, 645);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_CalibMove";
            this.Text = "Frm_Calib";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1024, 600);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Calib_FormClosing);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_iteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verify_dr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_verify_limitr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Sunny.UI.UILabel lb_mat;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UIButton btn_Calib;
        private Sunny.UI.UILabel lb_img2robpos;
        private Sunny.UI.UILabel label6;
        private System.Windows.Forms.NumericUpDown nud_verify_dr;
        private System.Windows.Forms.NumericUpDown nud_verify_limitr;
        private Sunny.UI.UILabel label9;
        private Sunny.UI.UILabel label8;
        private Sunny.UI.UICheckBox ckb_AutoGrabbing;
        private Sunny.UI.UILabel lb_imagepos;
        private Sunny.UI.UILabel label7;
        private Sunny.UI.UIButton btn_EditVpp;
        private Sunny.UI.UIButton btn_RunVpp;
        private System.Windows.Forms.NumericUpDown nud_dr;
        private System.Windows.Forms.NumericUpDown nud_dy;
        private System.Windows.Forms.NumericUpDown nud_dx;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UILabel label1;
        private Cognex.VisionPro.CogRecordDisplay cogDisplay1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIButton button5;
        private Sunny.UI.UILabel label15;
        private Sunny.UI.UITextBox tb_run_movetarget;
        private Sunny.UI.UIButton button4;
        private Sunny.UI.UILabel label14;
        private Sunny.UI.UITextBox tb_run_img2rob;
        private Sunny.UI.UILabel label13;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UILabel label11;
        private Sunny.UI.UILabel label10;
        private Sunny.UI.UILabel label5;
        private Sunny.UI.UITextBox tb_teach_tool;
        private Sunny.UI.UITextBox tb_teach_downpt;
        private Sunny.UI.UITextBox tb_teach_img2rob;
        private Sunny.UI.UITextBox tb_teach_robpt;
        private Sunny.UI.UITextBox tb_teach_imgpt;
        private Sunny.UI.UIButton button3;
        private Sunny.UI.UIButton button2;
        private Sunny.UI.UIButton button1;
        private Sunny.UI.UILabel label16;
        private Sunny.UI.UILabel label17;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UILabel label18;
        private Sunny.UI.UILabel label20;
        private Sunny.UI.UILabel lb_c;
        private Sunny.UI.UILabel label19;
        private Sunny.UI.UILabel label22;
        private System.Windows.Forms.NumericUpDown nud_delay;
        private System.Windows.Forms.NumericUpDown nud_pix;
        private Sunny.UI.UILabel label23;
        private Sunny.UI.UILabel label24;
        private System.Windows.Forms.NumericUpDown nud_iteration;
    }
}
