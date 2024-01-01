namespace Auto_parking
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_CarOut = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.text_PlateOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_PlateOut = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLience = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picMan = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.capCameraBtn = new System.Windows.Forms.Button();
            this.pictureBox_WC = new System.Windows.Forms.PictureBox();
            this.regonizeBtn = new System.Windows.Forms.Button();
            this.debug_btn = new System.Windows.Forms.Button();
            this.butUserInfo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tmrUART = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.butOpen = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarOut)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlateOut)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WC)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_CarOut
            // 
            this.pictureBox_CarOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_CarOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CarOut.Image = global::Auto_parking.Properties.Resources._543px_Logo_hcmut_svg;
            this.pictureBox_CarOut.Location = new System.Drawing.Point(418, 3);
            this.pictureBox_CarOut.Name = "pictureBox_CarOut";
            this.pictureBox_CarOut.Size = new System.Drawing.Size(444, 407);
            this.pictureBox_CarOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CarOut.TabIndex = 2;
            this.pictureBox_CarOut.TabStop = false;
            this.pictureBox_CarOut.Click += new System.EventHandler(this.pictureBox_CarOut_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(418, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox_PlateOut, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 24);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(438, 171);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.text_PlateOut, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(213, 165);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // text_PlateOut
            // 
            this.text_PlateOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text_PlateOut.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PlateOut.Location = new System.Drawing.Point(3, 28);
            this.text_PlateOut.Multiline = true;
            this.text_PlateOut.Name = "text_PlateOut";
            this.text_PlateOut.ReadOnly = true;
            this.text_PlateOut.Size = new System.Drawing.Size(154, 81);
            this.text_PlateOut.TabIndex = 10;
            this.text_PlateOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Plate:";
            // 
            // pictureBox_PlateOut
            // 
            this.pictureBox_PlateOut.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_PlateOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_PlateOut.Location = new System.Drawing.Point(222, 3);
            this.pictureBox_PlateOut.Name = "pictureBox_PlateOut";
            this.pictureBox_PlateOut.Size = new System.Drawing.Size(213, 165);
            this.pictureBox_PlateOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PlateOut.TabIndex = 4;
            this.pictureBox_PlateOut.TabStop = false;
            this.pictureBox_PlateOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1065, 623);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.97688F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.02312F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox_CarOut, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.picMan, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.93679F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.06321F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(865, 617);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLience);
            this.groupBox1.Controls.Add(this.lbPhone);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 198);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin người dùng";
            // 
            // lbLience
            // 
            this.lbLience.AutoSize = true;
            this.lbLience.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLience.Location = new System.Drawing.Point(131, 138);
            this.lbLience.Name = "lbLience";
            this.lbLience.Size = new System.Drawing.Size(103, 29);
            this.lbLience.TabIndex = 7;
            this.lbLience.Text = "unknown";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(131, 102);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(103, 29);
            this.lbPhone.TabIndex = 6;
            this.lbPhone.Text = "unknown";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(131, 69);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(103, 29);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "unknown";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(131, 38);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(103, 29);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "unknown";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Biển số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // picMan
            // 
            this.picMan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMan.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMan.InitialImage")));
            this.picMan.Location = new System.Drawing.Point(3, 3);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(409, 407);
            this.picMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMan.TabIndex = 7;
            this.picMan.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.capCameraBtn, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox_WC, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.regonizeBtn, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.debug_btn, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.butUserInfo, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 11);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(874, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(188, 617);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(3, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(3, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số dư: 200.000";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(3, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 35);
            this.label4.TabIndex = 18;
            this.label4.Text = "Trạng thái ";
            // 
            // capCameraBtn
            // 
            this.capCameraBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.capCameraBtn.BackColor = System.Drawing.Color.Silver;
            this.capCameraBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.capCameraBtn.FlatAppearance.BorderSize = 2;
            this.capCameraBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.capCameraBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.capCameraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capCameraBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.capCameraBtn.Location = new System.Drawing.Point(3, 173);
            this.capCameraBtn.Name = "capCameraBtn";
            this.capCameraBtn.Size = new System.Drawing.Size(182, 33);
            this.capCameraBtn.TabIndex = 0;
            this.capCameraBtn.Text = "Capture";
            this.capCameraBtn.UseVisualStyleBackColor = false;
            this.capCameraBtn.Click += new System.EventHandler(this.capCameraBtn_Click);
            // 
            // pictureBox_WC
            // 
            this.pictureBox_WC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_WC.BackColor = System.Drawing.Color.Snow;
            this.pictureBox_WC.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_WC.Name = "pictureBox_WC";
            this.pictureBox_WC.Size = new System.Drawing.Size(182, 164);
            this.pictureBox_WC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_WC.TabIndex = 6;
            this.pictureBox_WC.TabStop = false;
            this.pictureBox_WC.Click += new System.EventHandler(this.pictureBox_WC_Click);
            // 
            // regonizeBtn
            // 
            this.regonizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regonizeBtn.BackColor = System.Drawing.Color.Silver;
            this.regonizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.regonizeBtn.FlatAppearance.BorderSize = 2;
            this.regonizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.regonizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regonizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regonizeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.regonizeBtn.ImageKey = "(none)";
            this.regonizeBtn.Location = new System.Drawing.Point(3, 212);
            this.regonizeBtn.Name = "regonizeBtn";
            this.regonizeBtn.Size = new System.Drawing.Size(182, 25);
            this.regonizeBtn.TabIndex = 1;
            this.regonizeBtn.Text = "Regonize file";
            this.regonizeBtn.UseVisualStyleBackColor = false;
            this.regonizeBtn.Click += new System.EventHandler(this.regonizeBtn_Click);
            // 
            // debug_btn
            // 
            this.debug_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debug_btn.BackColor = System.Drawing.Color.Silver;
            this.debug_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.debug_btn.FlatAppearance.BorderSize = 2;
            this.debug_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.debug_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.debug_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debug_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.debug_btn.Location = new System.Drawing.Point(3, 243);
            this.debug_btn.Name = "debug_btn";
            this.debug_btn.Size = new System.Drawing.Size(182, 1);
            this.debug_btn.TabIndex = 2;
            this.debug_btn.Text = "Debugging";
            this.debug_btn.UseVisualStyleBackColor = false;
            this.debug_btn.Click += new System.EventHandler(this.debug_btn_Click);
            // 
            // butUserInfo
            // 
            this.butUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butUserInfo.BackColor = System.Drawing.Color.Silver;
            this.butUserInfo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butUserInfo.FlatAppearance.BorderSize = 2;
            this.butUserInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.butUserInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.butUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.butUserInfo.Location = new System.Drawing.Point(3, 243);
            this.butUserInfo.Name = "butUserInfo";
            this.butUserInfo.Size = new System.Drawing.Size(182, 37);
            this.butUserInfo.TabIndex = 7;
            this.butUserInfo.Text = "Thông tin người dùng";
            this.butUserInfo.UseVisualStyleBackColor = false;
            this.butUserInfo.Click += new System.EventHandler(this.butUserInfo_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(3, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 44);
            this.label8.TabIndex = 21;
            this.label8.Text = "Không hợp lệ";
            // 
            // tmrUART
            // 
            this.tmrUART.Enabled = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbCom, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbBaud, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 447);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(182, 59);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "COM";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "BAU";
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(55, 3);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(124, 27);
            this.cbCom.TabIndex = 2;
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(55, 31);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(124, 27);
            this.cbBaud.TabIndex = 3;
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(0, 0);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(85, 34);
            this.butOpen.TabIndex = 0;
            this.butOpen.Text = "Open";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(91, 0);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(91, 34);
            this.butClose.TabIndex = 1;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-3, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(185, 45);
            this.progressBar1.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butClose);
            this.groupBox3.Controls.Add(this.butOpen);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(3, 512);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 76);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1065, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto_Parking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CarOut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlateOut)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WC)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_CarOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_PlateOut;
        private System.Windows.Forms.PictureBox pictureBox_PlateOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button butUserInfo;
        private System.Windows.Forms.Button debug_btn;
        private System.Windows.Forms.Button regonizeBtn;
        private System.Windows.Forms.Button capCameraBtn;
        private System.Windows.Forms.PictureBox pictureBox_WC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picMan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLience;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer tmrUART;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

