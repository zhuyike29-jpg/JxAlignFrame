namespace JxAlignVision
{
    partial class frmEolDebug
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
            this.groupBox3 = new Sunny.UI.UIGroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTool2R = new Sunny.UI.UITextBox();
            this.txtTool2Y = new Sunny.UI.UITextBox();
            this.txtJigX = new Sunny.UI.UITextBox();
            this.txtJigY = new Sunny.UI.UITextBox();
            this.txtRobX = new Sunny.UI.UITextBox();
            this.label1 = new Sunny.UI.UILabel();
            this.label3 = new Sunny.UI.UILabel();
            this.label2 = new Sunny.UI.UILabel();
            this.btnCalcTool1 = new Sunny.UI.UIButton();
            this.txtProdX = new Sunny.UI.UITextBox();
            this.txtProdY = new Sunny.UI.UITextBox();
            this.txtRobY = new Sunny.UI.UITextBox();
            this.txtTool1X = new Sunny.UI.UITextBox();
            this.txtTool1Y = new Sunny.UI.UITextBox();
            this.txtTool1R = new Sunny.UI.UITextBox();
            this.txtProdR = new Sunny.UI.UITextBox();
            this.btnGetProdPos = new Sunny.UI.UIButton();
            this.btnGetRobPos = new Sunny.UI.UIButton();
            this.label4 = new Sunny.UI.UILabel();
            this.txtTargetHX = new Sunny.UI.UITextBox();
            this.txtTargetHY = new Sunny.UI.UITextBox();
            this.txtTargetHR = new Sunny.UI.UITextBox();
            this.txtRobR = new Sunny.UI.UITextBox();
            this.btnGetJigPos = new Sunny.UI.UIButton();
            this.txtJigR = new Sunny.UI.UITextBox();
            this.btnCalcTool2 = new Sunny.UI.UIButton();
            this.txtTool2X = new Sunny.UI.UITextBox();
            this.groupBox4 = new Sunny.UI.UIGroupBox();
            this.btn_Reset1 = new Sunny.UI.UIButton();
            this.btn_Apply1 = new Sunny.UI.UIButton();
            this.groupBox1 = new Sunny.UI.UIGroupBox();
            this.btn_run_vpp1 = new Sunny.UI.UIButton();
            this.btn_run_vpp2 = new Sunny.UI.UIButton();
            this.btn_edit_vpp1 = new Sunny.UI.UIButton();
            this.btn_edit_vpp2 = new Sunny.UI.UIButton();
            this.chkAutoCamProdGrabbing = new Sunny.UI.UICheckBox();
            this.chkAutoCamJigGrabbing = new Sunny.UI.UICheckBox();
            this.chkOfflineimgCamProd = new Sunny.UI.UICheckBox();
            this.chkOfflineImgCamJig = new Sunny.UI.UICheckBox();
            this.label17 = new Sunny.UI.UILabel();
            this.label18 = new Sunny.UI.UILabel();
            this.lb_imgpt1 = new Sunny.UI.UILabel();
            this.lb_img2robpt1 = new Sunny.UI.UILabel();
            this.label12 = new Sunny.UI.UILabel();
            this.label11 = new Sunny.UI.UILabel();
            this.lb_imgpt2 = new Sunny.UI.UILabel();
            this.lb_img2robpt2 = new Sunny.UI.UILabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.displayCCD1 = new Cognex.VisionPro.CogRecordDisplay();
            this.displayCCD2 = new Cognex.VisionPro.CogRecordDisplay();
            this.btnRobptPlace = new Sunny.UI.UIButton();
            this.txtRobptPlaceX = new Sunny.UI.UITextBox();
            this.txtRobptPlaceY = new Sunny.UI.UITextBox();
            this.txtRobptPlaceR = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1056, 707);
            this.splitContainer1.SplitterDistance = 534;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(0, 219);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox3.Size = new System.Drawing.Size(534, 392);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "示校操作";
            this.groupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.txtJigX, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtJigY, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtRobX, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCalcTool1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtProdX, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtProdY, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRobY, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTool1X, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTool1Y, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTool1R, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtProdR, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGetProdPos, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGetRobPos, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtRobR, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnGetJigPos, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtJigR, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtTargetHX, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtTargetHY, 2, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtTargetHR, 3, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnCalcTool2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtTool2X, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtTool2Y, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtTool2R, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnRobptPlace, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtRobptPlaceX, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtRobptPlaceY, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtRobptPlaceR, 3, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 360);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // txtTool2R
            // 
            this.txtTool2R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTool2R.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTool2R.Location = new System.Drawing.Point(403, 275);
            this.txtTool2R.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTool2R.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTool2R.Multiline = true;
            this.txtTool2R.Name = "txtTool2R";
            this.txtTool2R.Padding = new System.Windows.Forms.Padding(5);
            this.txtTool2R.ShowText = false;
            this.txtTool2R.Size = new System.Drawing.Size(127, 35);
            this.txtTool2R.TabIndex = 32;
            this.txtTool2R.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTool2R.Watermark = "";
            // 
            // txtTool2Y
            // 
            this.txtTool2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTool2Y.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTool2Y.Location = new System.Drawing.Point(270, 275);
            this.txtTool2Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTool2Y.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTool2Y.Multiline = true;
            this.txtTool2Y.Name = "txtTool2Y";
            this.txtTool2Y.Padding = new System.Windows.Forms.Padding(5);
            this.txtTool2Y.ShowText = false;
            this.txtTool2Y.Size = new System.Drawing.Size(125, 35);
            this.txtTool2Y.TabIndex = 32;
            this.txtTool2Y.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTool2Y.Watermark = "";
            // 
            // txtJigX
            // 
            this.txtJigX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJigX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJigX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJigX.Location = new System.Drawing.Point(137, 185);
            this.txtJigX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJigX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtJigX.Multiline = true;
            this.txtJigX.Name = "txtJigX";
            this.txtJigX.Padding = new System.Windows.Forms.Padding(5);
            this.txtJigX.ShowText = false;
            this.txtJigX.Size = new System.Drawing.Size(125, 35);
            this.txtJigX.TabIndex = 31;
            this.txtJigX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtJigX.Watermark = "";
            // 
            // txtJigY
            // 
            this.txtJigY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJigY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJigY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJigY.Location = new System.Drawing.Point(270, 185);
            this.txtJigY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJigY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtJigY.Multiline = true;
            this.txtJigY.Name = "txtJigY";
            this.txtJigY.Padding = new System.Windows.Forms.Padding(5);
            this.txtJigY.ShowText = false;
            this.txtJigY.Size = new System.Drawing.Size(125, 35);
            this.txtJigY.TabIndex = 32;
            this.txtJigY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtJigY.Watermark = "";
            // 
            // txtRobX
            // 
            this.txtRobX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRobX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobX.Location = new System.Drawing.Point(137, 95);
            this.txtRobX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobX.Multiline = true;
            this.txtRobX.Name = "txtRobX";
            this.txtRobX.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobX.ShowText = false;
            this.txtRobX.Size = new System.Drawing.Size(125, 35);
            this.txtRobX.TabIndex = 7;
            this.txtRobX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobX.Watermark = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(402, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "R";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(269, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcTool1
            // 
            this.btnCalcTool1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnCalcTool1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcTool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcTool1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalcTool1.Location = new System.Drawing.Point(3, 138);
            this.btnCalcTool1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCalcTool1.Name = "btnCalcTool1";
            this.btnCalcTool1.Size = new System.Drawing.Size(127, 39);
            this.btnCalcTool1.TabIndex = 5;
            this.btnCalcTool1.Text = "计算工具1";
            this.btnCalcTool1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalcTool1.Click += new System.EventHandler(this.btnCalcTool1_Click);
            // 
            // txtProdX
            // 
            this.txtProdX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProdX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProdX.Location = new System.Drawing.Point(137, 50);
            this.txtProdX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProdX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtProdX.Multiline = true;
            this.txtProdX.Name = "txtProdX";
            this.txtProdX.Padding = new System.Windows.Forms.Padding(5);
            this.txtProdX.ShowText = false;
            this.txtProdX.Size = new System.Drawing.Size(125, 35);
            this.txtProdX.TabIndex = 7;
            this.txtProdX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtProdX.Watermark = "";
            // 
            // txtProdY
            // 
            this.txtProdY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProdY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProdY.Location = new System.Drawing.Point(270, 50);
            this.txtProdY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProdY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtProdY.Multiline = true;
            this.txtProdY.Name = "txtProdY";
            this.txtProdY.Padding = new System.Windows.Forms.Padding(5);
            this.txtProdY.ShowText = false;
            this.txtProdY.Size = new System.Drawing.Size(125, 35);
            this.txtProdY.TabIndex = 8;
            this.txtProdY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtProdY.Watermark = "";
            // 
            // txtRobY
            // 
            this.txtRobY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRobY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobY.Location = new System.Drawing.Point(270, 95);
            this.txtRobY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobY.Multiline = true;
            this.txtRobY.Name = "txtRobY";
            this.txtRobY.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobY.ShowText = false;
            this.txtRobY.Size = new System.Drawing.Size(125, 35);
            this.txtRobY.TabIndex = 9;
            this.txtRobY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobY.Watermark = "";
            // 
            // txtTool1X
            // 
            this.txtTool1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTool1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTool1X.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTool1X.Location = new System.Drawing.Point(137, 140);
            this.txtTool1X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTool1X.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTool1X.Multiline = true;
            this.txtTool1X.Name = "txtTool1X";
            this.txtTool1X.Padding = new System.Windows.Forms.Padding(5);
            this.txtTool1X.ShowText = false;
            this.txtTool1X.Size = new System.Drawing.Size(125, 35);
            this.txtTool1X.TabIndex = 10;
            this.txtTool1X.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTool1X.Watermark = "";
            // 
            // txtTool1Y
            // 
            this.txtTool1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTool1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTool1Y.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTool1Y.Location = new System.Drawing.Point(270, 140);
            this.txtTool1Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTool1Y.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTool1Y.Multiline = true;
            this.txtTool1Y.Name = "txtTool1Y";
            this.txtTool1Y.Padding = new System.Windows.Forms.Padding(5);
            this.txtTool1Y.ShowText = false;
            this.txtTool1Y.Size = new System.Drawing.Size(125, 35);
            this.txtTool1Y.TabIndex = 11;
            this.txtTool1Y.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTool1Y.Watermark = "";
            // 
            // txtTool1R
            // 
            this.txtTool1R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTool1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTool1R.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTool1R.Location = new System.Drawing.Point(403, 140);
            this.txtTool1R.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTool1R.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTool1R.Multiline = true;
            this.txtTool1R.Name = "txtTool1R";
            this.txtTool1R.Padding = new System.Windows.Forms.Padding(5);
            this.txtTool1R.ShowText = false;
            this.txtTool1R.Size = new System.Drawing.Size(127, 35);
            this.txtTool1R.TabIndex = 12;
            this.txtTool1R.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTool1R.Watermark = "";
            // 
            // txtProdR
            // 
            this.txtProdR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProdR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProdR.Location = new System.Drawing.Point(403, 50);
            this.txtProdR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProdR.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtProdR.Multiline = true;
            this.txtProdR.Name = "txtProdR";
            this.txtProdR.Padding = new System.Windows.Forms.Padding(5);
            this.txtProdR.ShowText = false;
            this.txtProdR.Size = new System.Drawing.Size(127, 35);
            this.txtProdR.TabIndex = 25;
            this.txtProdR.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtProdR.Watermark = "";
            // 
            // btnGetProdPos
            // 
            this.btnGetProdPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnGetProdPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetProdPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetProdPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetProdPos.Location = new System.Drawing.Point(3, 48);
            this.btnGetProdPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetProdPos.Name = "btnGetProdPos";
            this.btnGetProdPos.Size = new System.Drawing.Size(127, 39);
            this.btnGetProdPos.TabIndex = 26;
            this.btnGetProdPos.Text = "产品特征位";
            this.btnGetProdPos.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetProdPos.Click += new System.EventHandler(this.btnGetProdPos_Click);
            // 
            // btnGetRobPos
            // 
            this.btnGetRobPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnGetRobPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetRobPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetRobPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetRobPos.Location = new System.Drawing.Point(3, 93);
            this.btnGetRobPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetRobPos.Name = "btnGetRobPos";
            this.btnGetRobPos.Size = new System.Drawing.Size(127, 39);
            this.btnGetRobPos.TabIndex = 27;
            this.btnGetRobPos.Text = "机械手位置";
            this.btnGetRobPos.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetRobPos.Click += new System.EventHandler(this.btnGetRobPos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.label4.Location = new System.Drawing.Point(3, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "补偿值";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTargetHX
            // 
            this.txtTargetHX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTargetHX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTargetHX.Location = new System.Drawing.Point(137, 320);
            this.txtTargetHX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTargetHX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTargetHX.Multiline = true;
            this.txtTargetHX.Name = "txtTargetHX";
            this.txtTargetHX.Padding = new System.Windows.Forms.Padding(5);
            this.txtTargetHX.ShowText = false;
            this.txtTargetHX.Size = new System.Drawing.Size(125, 35);
            this.txtTargetHX.TabIndex = 13;
            this.txtTargetHX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTargetHX.Watermark = "";
            // 
            // txtTargetHY
            // 
            this.txtTargetHY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTargetHY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTargetHY.Location = new System.Drawing.Point(270, 320);
            this.txtTargetHY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTargetHY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTargetHY.Multiline = true;
            this.txtTargetHY.Name = "txtTargetHY";
            this.txtTargetHY.Padding = new System.Windows.Forms.Padding(5);
            this.txtTargetHY.ShowText = false;
            this.txtTargetHY.Size = new System.Drawing.Size(125, 35);
            this.txtTargetHY.TabIndex = 14;
            this.txtTargetHY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTargetHY.Watermark = "";
            // 
            // txtTargetHR
            // 
            this.txtTargetHR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTargetHR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTargetHR.Location = new System.Drawing.Point(403, 320);
            this.txtTargetHR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTargetHR.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTargetHR.Multiline = true;
            this.txtTargetHR.Name = "txtTargetHR";
            this.txtTargetHR.Padding = new System.Windows.Forms.Padding(5);
            this.txtTargetHR.ShowText = false;
            this.txtTargetHR.Size = new System.Drawing.Size(127, 35);
            this.txtTargetHR.TabIndex = 15;
            this.txtTargetHR.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTargetHR.Watermark = "";
            // 
            // txtRobR
            // 
            this.txtRobR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRobR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobR.Location = new System.Drawing.Point(403, 95);
            this.txtRobR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobR.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobR.Multiline = true;
            this.txtRobR.Name = "txtRobR";
            this.txtRobR.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobR.ShowText = false;
            this.txtRobR.Size = new System.Drawing.Size(127, 35);
            this.txtRobR.TabIndex = 28;
            this.txtRobR.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobR.Watermark = "";
            // 
            // btnGetJigPos
            // 
            this.btnGetJigPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnGetJigPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetJigPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetJigPos.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetJigPos.Location = new System.Drawing.Point(3, 183);
            this.btnGetJigPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetJigPos.Name = "btnGetJigPos";
            this.btnGetJigPos.Size = new System.Drawing.Size(127, 39);
            this.btnGetJigPos.TabIndex = 29;
            this.btnGetJigPos.Text = "治具特征位";
            this.btnGetJigPos.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetJigPos.Click += new System.EventHandler(this.btnGetJigPos_Click);
            // 
            // txtJigR
            // 
            this.txtJigR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJigR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtJigR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJigR.Location = new System.Drawing.Point(403, 185);
            this.txtJigR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJigR.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtJigR.Multiline = true;
            this.txtJigR.Name = "txtJigR";
            this.txtJigR.Padding = new System.Windows.Forms.Padding(5);
            this.txtJigR.ShowText = false;
            this.txtJigR.Size = new System.Drawing.Size(127, 35);
            this.txtJigR.TabIndex = 30;
            this.txtJigR.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtJigR.Watermark = "";
            // 
            // btnCalcTool2
            // 
            this.btnCalcTool2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnCalcTool2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcTool2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalcTool2.Location = new System.Drawing.Point(3, 273);
            this.btnCalcTool2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCalcTool2.Name = "btnCalcTool2";
            this.btnCalcTool2.Size = new System.Drawing.Size(127, 39);
            this.btnCalcTool2.TabIndex = 33;
            this.btnCalcTool2.Text = "计算工具2";
            this.btnCalcTool2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalcTool2.Click += new System.EventHandler(this.btnCalcTool2_Click);
            // 
            // txtTool2X
            // 
            this.txtTool2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTool2X.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTool2X.Location = new System.Drawing.Point(137, 275);
            this.txtTool2X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTool2X.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTool2X.Multiline = true;
            this.txtTool2X.Name = "txtTool2X";
            this.txtTool2X.Padding = new System.Windows.Forms.Padding(5);
            this.txtTool2X.ShowText = false;
            this.txtTool2X.Size = new System.Drawing.Size(125, 35);
            this.txtTool2X.TabIndex = 34;
            this.txtTool2X.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTool2X.Watermark = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Reset1);
            this.groupBox4.Controls.Add(this.btn_Apply1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(0, 611);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox4.Size = new System.Drawing.Size(534, 96);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = null;
            this.groupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Reset1
            // 
            this.btn_Reset1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset1.Location = new System.Drawing.Point(344, 35);
            this.btn_Reset1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Reset1.Name = "btn_Reset1";
            this.btn_Reset1.Size = new System.Drawing.Size(75, 43);
            this.btn_Reset1.TabIndex = 3;
            this.btn_Reset1.Text = "重置";
            this.btn_Reset1.TipsFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset1.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Apply1
            // 
            this.btn_Apply1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Apply1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Apply1.Location = new System.Drawing.Point(444, 35);
            this.btn_Apply1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Apply1.Name = "btn_Apply1";
            this.btn_Apply1.Size = new System.Drawing.Size(75, 43);
            this.btn_Apply1.TabIndex = 4;
            this.btn_Apply1.Text = "应用";
            this.btn_Apply1.TipsFont = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Apply1.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_run_vpp1);
            this.groupBox1.Controls.Add(this.btn_run_vpp2);
            this.groupBox1.Controls.Add(this.btn_edit_vpp1);
            this.groupBox1.Controls.Add(this.btn_edit_vpp2);
            this.groupBox1.Controls.Add(this.chkAutoCamProdGrabbing);
            this.groupBox1.Controls.Add(this.chkAutoCamJigGrabbing);
            this.groupBox1.Controls.Add(this.chkOfflineimgCamProd);
            this.groupBox1.Controls.Add(this.chkOfflineImgCamJig);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lb_imgpt1);
            this.groupBox1.Controls.Add(this.lb_img2robpt1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lb_imgpt2);
            this.groupBox1.Controls.Add(this.lb_img2robpt2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(534, 219);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像操作";
            this.groupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_run_vpp1
            // 
            this.btn_run_vpp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_run_vpp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_run_vpp1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run_vpp1.Location = new System.Drawing.Point(6, 34);
            this.btn_run_vpp1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_run_vpp1.Name = "btn_run_vpp1";
            this.btn_run_vpp1.Size = new System.Drawing.Size(75, 36);
            this.btn_run_vpp1.TabIndex = 0;
            this.btn_run_vpp1.Text = "运行vpp1";
            this.btn_run_vpp1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_run_vpp2
            // 
            this.btn_run_vpp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btn_run_vpp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_run_vpp2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_run_vpp2.Location = new System.Drawing.Point(9, 123);
            this.btn_run_vpp2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_run_vpp2.Name = "btn_run_vpp2";
            this.btn_run_vpp2.Size = new System.Drawing.Size(75, 36);
            this.btn_run_vpp2.TabIndex = 1;
            this.btn_run_vpp2.Text = "运行vpp2";
            this.btn_run_vpp2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_edit_vpp1
            // 
            this.btn_edit_vpp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_vpp1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit_vpp1.Location = new System.Drawing.Point(105, 34);
            this.btn_edit_vpp1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_edit_vpp1.Name = "btn_edit_vpp1";
            this.btn_edit_vpp1.Size = new System.Drawing.Size(75, 36);
            this.btn_edit_vpp1.TabIndex = 2;
            this.btn_edit_vpp1.Text = "修改vpp1";
            this.btn_edit_vpp1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btn_edit_vpp2
            // 
            this.btn_edit_vpp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_vpp2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_edit_vpp2.Location = new System.Drawing.Point(111, 123);
            this.btn_edit_vpp2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_edit_vpp2.Name = "btn_edit_vpp2";
            this.btn_edit_vpp2.Size = new System.Drawing.Size(75, 36);
            this.btn_edit_vpp2.TabIndex = 3;
            this.btn_edit_vpp2.Text = "修改vpp2";
            this.btn_edit_vpp2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // chkAutoCamProdGrabbing
            // 
            this.chkAutoCamProdGrabbing.AutoSize = true;
            this.chkAutoCamProdGrabbing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.chkAutoCamProdGrabbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoCamProdGrabbing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAutoCamProdGrabbing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.chkAutoCamProdGrabbing.Location = new System.Drawing.Point(208, 42);
            this.chkAutoCamProdGrabbing.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAutoCamProdGrabbing.Name = "chkAutoCamProdGrabbing";
            this.chkAutoCamProdGrabbing.Size = new System.Drawing.Size(126, 21);
            this.chkAutoCamProdGrabbing.TabIndex = 4;
            this.chkAutoCamProdGrabbing.Text = "产品实时图像";
            // 
            // chkAutoCamJigGrabbing
            // 
            this.chkAutoCamJigGrabbing.AutoSize = true;
            this.chkAutoCamJigGrabbing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.chkAutoCamJigGrabbing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoCamJigGrabbing.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAutoCamJigGrabbing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.chkAutoCamJigGrabbing.Location = new System.Drawing.Point(208, 131);
            this.chkAutoCamJigGrabbing.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkAutoCamJigGrabbing.Name = "chkAutoCamJigGrabbing";
            this.chkAutoCamJigGrabbing.Size = new System.Drawing.Size(126, 21);
            this.chkAutoCamJigGrabbing.TabIndex = 5;
            this.chkAutoCamJigGrabbing.Text = "治具实时图像";
            // 
            // chkOfflineimgCamProd
            // 
            this.chkOfflineimgCamProd.AutoSize = true;
            this.chkOfflineimgCamProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.chkOfflineimgCamProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOfflineimgCamProd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkOfflineimgCamProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.chkOfflineimgCamProd.Location = new System.Drawing.Point(348, 42);
            this.chkOfflineimgCamProd.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkOfflineimgCamProd.Name = "chkOfflineimgCamProd";
            this.chkOfflineimgCamProd.Size = new System.Drawing.Size(126, 21);
            this.chkOfflineimgCamProd.TabIndex = 6;
            this.chkOfflineimgCamProd.Text = "产品离线图像";
            // 
            // chkOfflineImgCamJig
            // 
            this.chkOfflineImgCamJig.AutoSize = true;
            this.chkOfflineImgCamJig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.chkOfflineImgCamJig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOfflineImgCamJig.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkOfflineImgCamJig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.chkOfflineImgCamJig.Location = new System.Drawing.Point(351, 131);
            this.chkOfflineImgCamJig.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkOfflineImgCamJig.Name = "chkOfflineImgCamJig";
            this.chkOfflineImgCamJig.Size = new System.Drawing.Size(126, 21);
            this.chkOfflineImgCamJig.TabIndex = 7;
            this.chkOfflineImgCamJig.Text = "治具离线图像";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label17.Location = new System.Drawing.Point(16, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "imgpt:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label18.Location = new System.Drawing.Point(16, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = "img2robpt:";
            // 
            // lb_imgpt1
            // 
            this.lb_imgpt1.AutoSize = true;
            this.lb_imgpt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_imgpt1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_imgpt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_imgpt1.Location = new System.Drawing.Point(76, 75);
            this.lb_imgpt1.Name = "lb_imgpt1";
            this.lb_imgpt1.Size = new System.Drawing.Size(31, 16);
            this.lb_imgpt1.TabIndex = 19;
            this.lb_imgpt1.Text = "###";
            // 
            // lb_img2robpt1
            // 
            this.lb_img2robpt1.AutoSize = true;
            this.lb_img2robpt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_img2robpt1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_img2robpt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_img2robpt1.Location = new System.Drawing.Point(102, 100);
            this.lb_img2robpt1.Name = "lb_img2robpt1";
            this.lb_img2robpt1.Size = new System.Drawing.Size(31, 16);
            this.lb_img2robpt1.TabIndex = 20;
            this.lb_img2robpt1.Text = "###";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label12.Location = new System.Drawing.Point(16, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "imgpt:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label11.Location = new System.Drawing.Point(16, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "img2robpt:";
            // 
            // lb_imgpt2
            // 
            this.lb_imgpt2.AutoSize = true;
            this.lb_imgpt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_imgpt2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_imgpt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_imgpt2.Location = new System.Drawing.Point(76, 165);
            this.lb_imgpt2.Name = "lb_imgpt2";
            this.lb_imgpt2.Size = new System.Drawing.Size(31, 16);
            this.lb_imgpt2.TabIndex = 23;
            this.lb_imgpt2.Text = "###";
            // 
            // lb_img2robpt2
            // 
            this.lb_img2robpt2.AutoSize = true;
            this.lb_img2robpt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lb_img2robpt2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_img2robpt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_img2robpt2.Location = new System.Drawing.Point(105, 193);
            this.lb_img2robpt2.Name = "lb_img2robpt2";
            this.lb_img2robpt2.Size = new System.Drawing.Size(31, 16);
            this.lb_img2robpt2.TabIndex = 24;
            this.lb_img2robpt2.Text = "###";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.displayCCD1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.displayCCD2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(518, 707);
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
            this.displayCCD1.Size = new System.Drawing.Size(512, 347);
            this.displayCCD1.TabIndex = 1;
            // 
            // displayCCD2
            // 
            this.displayCCD2.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.displayCCD2.ColorMapLowerRoiLimit = 0D;
            this.displayCCD2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.displayCCD2.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.displayCCD2.ColorMapUpperRoiLimit = 1D;
            this.displayCCD2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayCCD2.DoubleTapZoomCycleLength = 2;
            this.displayCCD2.DoubleTapZoomSensitivity = 2.5D;
            this.displayCCD2.Location = new System.Drawing.Point(3, 356);
            this.displayCCD2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.displayCCD2.MouseWheelSensitivity = 1D;
            this.displayCCD2.Name = "displayCCD2";
            this.displayCCD2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("displayCCD2.OcxState")));
            this.displayCCD2.Size = new System.Drawing.Size(512, 348);
            this.displayCCD2.TabIndex = 2;
            // 
            // btnRobptPlace
            // 
            this.btnRobptPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(139)))));
            this.btnRobptPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRobptPlace.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRobptPlace.Location = new System.Drawing.Point(3, 228);
            this.btnRobptPlace.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRobptPlace.Name = "btnRobptPlace";
            this.btnRobptPlace.Size = new System.Drawing.Size(127, 39);
            this.btnRobptPlace.TabIndex = 33;
            this.btnRobptPlace.Text = "机械手放料位";
            this.btnRobptPlace.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRobptPlace.Click += new System.EventHandler(this.btnRobptPlace_Click);
            // 
            // txtRobptPlaceX
            // 
            this.txtRobptPlaceX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobptPlaceX.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobptPlaceX.Location = new System.Drawing.Point(137, 230);
            this.txtRobptPlaceX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobptPlaceX.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobptPlaceX.Multiline = true;
            this.txtRobptPlaceX.Name = "txtRobptPlaceX";
            this.txtRobptPlaceX.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobptPlaceX.ShowText = false;
            this.txtRobptPlaceX.Size = new System.Drawing.Size(125, 35);
            this.txtRobptPlaceX.TabIndex = 34;
            this.txtRobptPlaceX.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobptPlaceX.Watermark = "";
            // 
            // txtRobptPlaceY
            // 
            this.txtRobptPlaceY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobptPlaceY.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobptPlaceY.Location = new System.Drawing.Point(270, 230);
            this.txtRobptPlaceY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobptPlaceY.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobptPlaceY.Multiline = true;
            this.txtRobptPlaceY.Name = "txtRobptPlaceY";
            this.txtRobptPlaceY.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobptPlaceY.ShowText = false;
            this.txtRobptPlaceY.Size = new System.Drawing.Size(125, 35);
            this.txtRobptPlaceY.TabIndex = 32;
            this.txtRobptPlaceY.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobptPlaceY.Watermark = "";
            // 
            // txtRobptPlaceR
            // 
            this.txtRobptPlaceR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRobptPlaceR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRobptPlaceR.Location = new System.Drawing.Point(403, 230);
            this.txtRobptPlaceR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRobptPlaceR.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtRobptPlaceR.Multiline = true;
            this.txtRobptPlaceR.Name = "txtRobptPlaceR";
            this.txtRobptPlaceR.Padding = new System.Windows.Forms.Padding(5);
            this.txtRobptPlaceR.ShowText = false;
            this.txtRobptPlaceR.Size = new System.Drawing.Size(127, 35);
            this.txtRobptPlaceR.TabIndex = 32;
            this.txtRobptPlaceR.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtRobptPlaceR.Watermark = "";
            // 
            // Frm_Debug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1056, 742);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_Debug";
            this.Text = "Eol  模板调试";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 903, 616);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Debug_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Debug_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayCCD2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Sunny.UI.UIButton btn_Apply1;
        private Sunny.UI.UIButton btn_Reset1;
        private Sunny.UI.UIButton btn_edit_vpp2;
        private Sunny.UI.UIButton btn_edit_vpp1;
        private Sunny.UI.UIButton btn_run_vpp2;
        private Sunny.UI.UIButton btn_run_vpp1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Cognex.VisionPro.CogRecordDisplay displayCCD1;
        private Cognex.VisionPro.CogRecordDisplay displayCCD2;
        private Sunny.UI.UICheckBox chkOfflineImgCamJig;
        private Sunny.UI.UICheckBox chkOfflineimgCamProd;
        private Sunny.UI.UICheckBox chkAutoCamJigGrabbing;
        private Sunny.UI.UICheckBox chkAutoCamProdGrabbing;
        private Sunny.UI.UILabel lb_img2robpt2;
        private Sunny.UI.UILabel lb_imgpt2;
        private Sunny.UI.UILabel label11;
        private Sunny.UI.UILabel label12;
        private Sunny.UI.UILabel lb_img2robpt1;
        private Sunny.UI.UILabel lb_imgpt1;
        private Sunny.UI.UILabel label18;
        private Sunny.UI.UILabel label17;
        private Sunny.UI.UIGroupBox groupBox1;
        private Sunny.UI.UIGroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Sunny.UI.UITextBox txtRobX;
        private Sunny.UI.UILabel label1;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UIButton btnCalcTool1;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UITextBox txtProdX;
        private Sunny.UI.UITextBox txtProdY;
        private Sunny.UI.UITextBox txtRobY;
        private Sunny.UI.UITextBox txtTool1X;
        private Sunny.UI.UITextBox txtTool1Y;
        private Sunny.UI.UITextBox txtTool1R;
        private Sunny.UI.UITextBox txtTargetHX;
        private Sunny.UI.UITextBox txtTargetHY;
        private Sunny.UI.UITextBox txtTargetHR;
        private Sunny.UI.UIGroupBox groupBox4;
        private Sunny.UI.UITextBox txtProdR;
        private Sunny.UI.UIButton btnGetProdPos;
        private Sunny.UI.UIButton btnGetRobPos;
        private Sunny.UI.UITextBox txtTool2R;
        private Sunny.UI.UITextBox txtTool2Y;
        private Sunny.UI.UITextBox txtJigX;
        private Sunny.UI.UITextBox txtJigY;
        private Sunny.UI.UITextBox txtRobR;
        private Sunny.UI.UIButton btnGetJigPos;
        private Sunny.UI.UITextBox txtJigR;
        private Sunny.UI.UIButton btnCalcTool2;
        private Sunny.UI.UITextBox txtTool2X;
        private Sunny.UI.UIButton btnRobptPlace;
        private Sunny.UI.UITextBox txtRobptPlaceX;
        private Sunny.UI.UITextBox txtRobptPlaceY;
        private Sunny.UI.UITextBox txtRobptPlaceR;
    }
}
