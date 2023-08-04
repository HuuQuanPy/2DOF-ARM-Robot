namespace RobotCongNghiep
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.CbxCom = new System.Windows.Forms.ComboBox();
            this.CbxBaudRate = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSetPoint = new System.Windows.Forms.Button();
            this.txtPy = new System.Windows.Forms.TextBox();
            this.txtPx = new System.Windows.Forms.TextBox();
            this.BtnRobotForward = new System.Windows.Forms.Button();
            this.BtnRobotInverse = new System.Windows.Forms.Button();
            this.lblPy = new System.Windows.Forms.Label();
            this.lblPx = new System.Windows.Forms.Label();
            this.lblTheta2 = new System.Windows.Forms.Label();
            this.lblTheta1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TrbTheta2 = new System.Windows.Forms.TrackBar();
            this.TrbTheta1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MyPorts = new System.IO.Ports.SerialPort(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtSetB_Px = new System.Windows.Forms.TextBox();
            this.TxtSetA_Px = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.TxtSetB_Py = new System.Windows.Forms.TextBox();
            this.TxtSetA_Py = new System.Windows.Forms.TextBox();
            this.BtnRUN_Random = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.BtnRunTwoPoint = new System.Windows.Forms.Button();
            this.BtnRun_Line = new System.Windows.Forms.Button();
            this.BtnSetP = new System.Windows.Forms.Button();
            this.TimerAVR = new System.Windows.Forms.Timer(this.components);
            this.txtModbusStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbTheta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbTheta1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROBOT Công Nghiệp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "GVHD : ThS.Đặng Anh Việt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "COM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Baud Rate";
            // 
            // BtnConnect
            // 
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.Location = new System.Drawing.Point(52, 204);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(88, 30);
            this.BtnConnect.TabIndex = 4;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // CbxCom
            // 
            this.CbxCom.FormattingEnabled = true;
            this.CbxCom.Location = new System.Drawing.Point(108, 128);
            this.CbxCom.Name = "CbxCom";
            this.CbxCom.Size = new System.Drawing.Size(84, 21);
            this.CbxCom.TabIndex = 5;
            // 
            // CbxBaudRate
            // 
            this.CbxBaudRate.FormattingEnabled = true;
            this.CbxBaudRate.Location = new System.Drawing.Point(108, 163);
            this.CbxBaudRate.Name = "CbxBaudRate";
            this.CbxBaudRate.Size = new System.Drawing.Size(84, 21);
            this.CbxBaudRate.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(48, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(118, 22);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "...";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSetPoint);
            this.groupBox1.Controls.Add(this.txtPy);
            this.groupBox1.Controls.Add(this.txtPx);
            this.groupBox1.Controls.Add(this.BtnRobotForward);
            this.groupBox1.Controls.Add(this.BtnRobotInverse);
            this.groupBox1.Controls.Add(this.lblPy);
            this.groupBox1.Controls.Add(this.lblPx);
            this.groupBox1.Controls.Add(this.lblTheta2);
            this.groupBox1.Controls.Add(this.lblTheta1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TrbTheta2);
            this.groupBox1.Controls.Add(this.TrbTheta1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(212, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnSetPoint
            // 
            this.BtnSetPoint.Enabled = false;
            this.BtnSetPoint.Location = new System.Drawing.Point(411, 134);
            this.BtnSetPoint.Name = "BtnSetPoint";
            this.BtnSetPoint.Size = new System.Drawing.Size(59, 19);
            this.BtnSetPoint.TabIndex = 48;
            this.BtnSetPoint.Text = "SET";
            this.BtnSetPoint.UseVisualStyleBackColor = true;
            this.BtnSetPoint.Click += new System.EventHandler(this.BtnSetPoint_Click);
            // 
            // txtPy
            // 
            this.txtPy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPy.Location = new System.Drawing.Point(411, 104);
            this.txtPy.Name = "txtPy";
            this.txtPy.Size = new System.Drawing.Size(90, 24);
            this.txtPy.TabIndex = 47;
            this.txtPy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPy.TextChanged += new System.EventHandler(this.txtPx_TextChanged);
            // 
            // txtPx
            // 
            this.txtPx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPx.Location = new System.Drawing.Point(411, 73);
            this.txtPx.Name = "txtPx";
            this.txtPx.Size = new System.Drawing.Size(90, 24);
            this.txtPx.TabIndex = 46;
            this.txtPx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPx.TextChanged += new System.EventHandler(this.txtPx_TextChanged);
            // 
            // BtnRobotForward
            // 
            this.BtnRobotForward.BackColor = System.Drawing.Color.LightGray;
            this.BtnRobotForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRobotForward.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRobotForward.Location = new System.Drawing.Point(23, 14);
            this.BtnRobotForward.Name = "BtnRobotForward";
            this.BtnRobotForward.Size = new System.Drawing.Size(240, 30);
            this.BtnRobotForward.TabIndex = 45;
            this.BtnRobotForward.Text = "Forward Kinematic";
            this.BtnRobotForward.UseVisualStyleBackColor = false;
            this.BtnRobotForward.Click += new System.EventHandler(this.BtnRobotForward_Click);
            // 
            // BtnRobotInverse
            // 
            this.BtnRobotInverse.BackColor = System.Drawing.Color.LightGray;
            this.BtnRobotInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRobotInverse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRobotInverse.Location = new System.Drawing.Point(302, 14);
            this.BtnRobotInverse.Name = "BtnRobotInverse";
            this.BtnRobotInverse.Size = new System.Drawing.Size(260, 30);
            this.BtnRobotInverse.TabIndex = 44;
            this.BtnRobotInverse.Text = "Inverse Kinematic";
            this.BtnRobotInverse.UseVisualStyleBackColor = false;
            this.BtnRobotInverse.Click += new System.EventHandler(this.BtnRobotInverse_Click);
            // 
            // lblPy
            // 
            this.lblPy.AutoSize = true;
            this.lblPy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPy.Location = new System.Drawing.Point(393, 207);
            this.lblPy.Name = "lblPy";
            this.lblPy.Size = new System.Drawing.Size(0, 17);
            this.lblPy.TabIndex = 32;
            // 
            // lblPx
            // 
            this.lblPx.AutoSize = true;
            this.lblPx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPx.Location = new System.Drawing.Point(393, 171);
            this.lblPx.Name = "lblPx";
            this.lblPx.Size = new System.Drawing.Size(0, 17);
            this.lblPx.TabIndex = 31;
            // 
            // lblTheta2
            // 
            this.lblTheta2.AutoSize = true;
            this.lblTheta2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheta2.Location = new System.Drawing.Point(275, 207);
            this.lblTheta2.Name = "lblTheta2";
            this.lblTheta2.Size = new System.Drawing.Size(0, 17);
            this.lblTheta2.TabIndex = 30;
            // 
            // lblTheta1
            // 
            this.lblTheta1.AutoSize = true;
            this.lblTheta1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheta1.Location = new System.Drawing.Point(275, 171);
            this.lblTheta1.Name = "lblTheta1";
            this.lblTheta1.Size = new System.Drawing.Size(0, 17);
            this.lblTheta1.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(338, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 28;
            this.label15.Text = "Y Axis:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(338, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "X Axis:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(220, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 26;
            this.label13.Text = "Theta2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(220, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 25;
            this.label14.Text = "Theta1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 21);
            this.label12.TabIndex = 24;
            this.label12.Text = "ROBOT Point";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Y Axis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(360, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "X Axis";
            // 
            // TrbTheta2
            // 
            this.TrbTheta2.AutoSize = false;
            this.TrbTheta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TrbTheta2.LargeChange = 1;
            this.TrbTheta2.Location = new System.Drawing.Point(67, 108);
            this.TrbTheta2.Maximum = 180;
            this.TrbTheta2.Name = "TrbTheta2";
            this.TrbTheta2.Size = new System.Drawing.Size(192, 33);
            this.TrbTheta2.TabIndex = 14;
            this.TrbTheta2.Scroll += new System.EventHandler(this.TrbTheta2_Scroll);
            // 
            // TrbTheta1
            // 
            this.TrbTheta1.AutoSize = false;
            this.TrbTheta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TrbTheta1.LargeChange = 1;
            this.TrbTheta1.Location = new System.Drawing.Point(67, 70);
            this.TrbTheta1.Maximum = 180;
            this.TrbTheta1.Name = "TrbTheta1";
            this.TrbTheta1.Size = new System.Drawing.Size(192, 33);
            this.TrbTheta1.TabIndex = 13;
            this.TrbTheta1.Scroll += new System.EventHandler(this.TrbTheta1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Theta2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Theta1";
            // 
            // MyPorts
            // 
            this.MyPorts.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.MyPorts_DataReceived);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(244, 398);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 15);
            this.label22.TabIndex = 34;
            this.label22.Text = "A POINT";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(244, 428);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 15);
            this.label23.TabIndex = 35;
            this.label23.Text = "B POINT";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(350, 398);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 15);
            this.label24.TabIndex = 36;
            this.label24.Text = "X_axis";
            // 
            // TxtSetB_Px
            // 
            this.TxtSetB_Px.Location = new System.Drawing.Point(395, 428);
            this.TxtSetB_Px.Name = "TxtSetB_Px";
            this.TxtSetB_Px.Size = new System.Drawing.Size(50, 20);
            this.TxtSetB_Px.TabIndex = 34;
            this.TxtSetB_Px.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSetB_Px.TextChanged += new System.EventHandler(this.TxtPoint_TextChanged);
            // 
            // TxtSetA_Px
            // 
            this.TxtSetA_Px.Location = new System.Drawing.Point(395, 391);
            this.TxtSetA_Px.Name = "TxtSetA_Px";
            this.TxtSetA_Px.Size = new System.Drawing.Size(50, 20);
            this.TxtSetA_Px.TabIndex = 33;
            this.TxtSetA_Px.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSetA_Px.TextChanged += new System.EventHandler(this.TxtPoint_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(350, 431);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(39, 15);
            this.label25.TabIndex = 37;
            this.label25.Text = "X_axis";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(478, 431);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(39, 15);
            this.label26.TabIndex = 41;
            this.label26.Text = "Y_axis";
            // 
            // TxtSetB_Py
            // 
            this.TxtSetB_Py.Location = new System.Drawing.Point(523, 426);
            this.TxtSetB_Py.Name = "TxtSetB_Py";
            this.TxtSetB_Py.Size = new System.Drawing.Size(50, 20);
            this.TxtSetB_Py.TabIndex = 39;
            this.TxtSetB_Py.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSetB_Py.TextChanged += new System.EventHandler(this.TxtPoint_TextChanged);
            // 
            // TxtSetA_Py
            // 
            this.TxtSetA_Py.Location = new System.Drawing.Point(523, 391);
            this.TxtSetA_Py.Name = "TxtSetA_Py";
            this.TxtSetA_Py.Size = new System.Drawing.Size(50, 20);
            this.TxtSetA_Py.TabIndex = 38;
            this.TxtSetA_Py.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSetA_Py.TextChanged += new System.EventHandler(this.TxtPoint_TextChanged);
            // 
            // BtnRUN_Random
            // 
            this.BtnRUN_Random.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRUN_Random.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRUN_Random.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRUN_Random.Location = new System.Drawing.Point(254, 473);
            this.BtnRUN_Random.Name = "BtnRUN_Random";
            this.BtnRUN_Random.Size = new System.Drawing.Size(143, 30);
            this.BtnRUN_Random.TabIndex = 42;
            this.BtnRUN_Random.Text = "Random Orbit";
            this.BtnRUN_Random.UseVisualStyleBackColor = false;
            this.BtnRUN_Random.Click += new System.EventHandler(this.BtnRUN_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(478, 393);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(39, 15);
            this.label27.TabIndex = 43;
            this.label27.Text = "Y_axis";
            // 
            // BtnRunTwoPoint
            // 
            this.BtnRunTwoPoint.BackColor = System.Drawing.Color.LightGray;
            this.BtnRunTwoPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRunTwoPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRunTwoPoint.Location = new System.Drawing.Point(324, 345);
            this.BtnRunTwoPoint.Name = "BtnRunTwoPoint";
            this.BtnRunTwoPoint.Size = new System.Drawing.Size(240, 30);
            this.BtnRunTwoPoint.TabIndex = 49;
            this.BtnRunTwoPoint.Text = "ROBOT Orbit";
            this.BtnRunTwoPoint.UseVisualStyleBackColor = false;
            // 
            // BtnRun_Line
            // 
            this.BtnRun_Line.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRun_Line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRun_Line.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRun_Line.Location = new System.Drawing.Point(462, 473);
            this.BtnRun_Line.Name = "BtnRun_Line";
            this.BtnRun_Line.Size = new System.Drawing.Size(192, 30);
            this.BtnRun_Line.TabIndex = 50;
            this.BtnRun_Line.Text = "Line Orbit";
            this.BtnRun_Line.UseVisualStyleBackColor = false;
            this.BtnRun_Line.Click += new System.EventHandler(this.BtnRun_Line_Click);
            // 
            // BtnSetP
            // 
            this.BtnSetP.Enabled = false;
            this.BtnSetP.Location = new System.Drawing.Point(595, 411);
            this.BtnSetP.Name = "BtnSetP";
            this.BtnSetP.Size = new System.Drawing.Size(59, 19);
            this.BtnSetP.TabIndex = 49;
            this.BtnSetP.Text = "SET";
            this.BtnSetP.UseVisualStyleBackColor = true;
            this.BtnSetP.Click += new System.EventHandler(this.BtnSetP_Click);
            // 
            // TimerAVR
            // 
            this.TimerAVR.Tick += new System.EventHandler(this.TimerAVR_Tick);
            // 
            // txtModbusStatus
            // 
            this.txtModbusStatus.Location = new System.Drawing.Point(636, 79);
            this.txtModbusStatus.Name = "txtModbusStatus";
            this.txtModbusStatus.ReadOnly = true;
            this.txtModbusStatus.Size = new System.Drawing.Size(151, 20);
            this.txtModbusStatus.TabIndex = 51;
            this.txtModbusStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 515);
            this.Controls.Add(this.txtModbusStatus);
            this.Controls.Add(this.BtnSetP);
            this.Controls.Add(this.BtnRun_Line);
            this.Controls.Add(this.BtnRunTwoPoint);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.BtnRUN_Random);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.TxtSetB_Py);
            this.Controls.Add(this.TxtSetA_Py);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.TxtSetB_Px);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.TxtSetA_Px);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.CbxBaudRate);
            this.Controls.Add(this.CbxCom);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ROBOT Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbTheta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbTheta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ComboBox CbxCom;
        private System.Windows.Forms.ComboBox CbxBaudRate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar TrbTheta2;
        private System.Windows.Forms.TrackBar TrbTheta1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort MyPorts;
        private System.Windows.Forms.Label lblPy;
        private System.Windows.Forms.Label lblPx;
        private System.Windows.Forms.Label lblTheta2;
        private System.Windows.Forms.Label lblTheta1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TxtSetB_Px;
        private System.Windows.Forms.TextBox TxtSetA_Px;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TxtSetB_Py;
        private System.Windows.Forms.TextBox TxtSetA_Py;
        private System.Windows.Forms.Button BtnRUN_Random;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button BtnRobotForward;
        private System.Windows.Forms.Button BtnRobotInverse;
        private System.Windows.Forms.TextBox txtPy;
        private System.Windows.Forms.TextBox txtPx;
        private System.Windows.Forms.Button BtnSetPoint;
        private System.Windows.Forms.Button BtnRunTwoPoint;
        private System.Windows.Forms.Button BtnRun_Line;
        private System.Windows.Forms.Button BtnSetP;
        private System.Windows.Forms.Timer TimerAVR;
        private System.Windows.Forms.TextBox txtModbusStatus;
    }
}

