namespace FAISAL_IE322
{
    partial class FrmMain
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAbt = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnGrpapp = new System.Windows.Forms.Button();
            this.BtnPicbox2 = new System.Windows.Forms.Button();
            this.BtnSelfapp = new System.Windows.Forms.Button();
            this.BtnPicbox = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnRandcom = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnRand = new System.Windows.Forms.Button();
            this.BtnProg = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnABC = new System.Windows.Forms.Button();
            this.BtnRobotcell = new System.Windows.Forms.Button();
            this.BtnMancell = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Green;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.Black;
            this.BtnLogin.Location = new System.Drawing.Point(475, 151);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(131, 48);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnAbt);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.TxtPass);
            this.groupBox1.Controls.Add(this.LblPass);
            this.groupBox1.Controls.Add(this.BtnLogin);
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnAbt
            // 
            this.BtnAbt.BackColor = System.Drawing.Color.Blue;
            this.BtnAbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbt.ForeColor = System.Drawing.Color.Black;
            this.BtnAbt.Location = new System.Drawing.Point(17, 151);
            this.BtnAbt.Name = "BtnAbt";
            this.BtnAbt.Size = new System.Drawing.Size(131, 47);
            this.BtnAbt.TabIndex = 5;
            this.BtnAbt.Text = "About";
            this.BtnAbt.UseVisualStyleBackColor = false;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(235, 46);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(188, 27);
            this.TxtUser.TabIndex = 4;
            this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged_1);
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(235, 105);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(188, 27);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.Color.White;
            this.LblPass.Location = new System.Drawing.Point(74, 105);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(106, 25);
            this.LblPass.TabIndex = 2;
            this.LblPass.Text = "Password";
            this.LblPass.Click += new System.EventHandler(this.LblPass_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(67, 44);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(113, 25);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "UserName";
            this.LblUser.Click += new System.EventHandler(this.LblUser_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Black;
            this.BtnExit.Location = new System.Drawing.Point(717, 458);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(283, 146);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BtnCombo);
            this.groupBox2.Controls.Add(this.BtnCheck);
            this.groupBox2.Controls.Add(this.BtnRadio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(355, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Controls";
            // 
            // BtnCombo
            // 
            this.BtnCombo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCombo.Location = new System.Drawing.Point(95, 99);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(110, 39);
            this.BtnCombo.TabIndex = 2;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = false;
            this.BtnCombo.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnCheck
            // 
            this.BtnCheck.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCheck.Location = new System.Drawing.Point(170, 32);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(110, 39);
            this.BtnCheck.TabIndex = 1;
            this.BtnCheck.Text = "CheckBox";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnRadio
            // 
            this.BtnRadio.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnRadio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRadio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRadio.Location = new System.Drawing.Point(21, 32);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(110, 39);
            this.BtnRadio.TabIndex = 0;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = false;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BtnGrpapp);
            this.groupBox3.Controls.Add(this.BtnPicbox2);
            this.groupBox3.Controls.Add(this.BtnSelfapp);
            this.groupBox3.Controls.Add(this.BtnPicbox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(29, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 154);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphical";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // BtnGrpapp
            // 
            this.BtnGrpapp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnGrpapp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGrpapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrpapp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGrpapp.Location = new System.Drawing.Point(158, 101);
            this.BtnGrpapp.Name = "BtnGrpapp";
            this.BtnGrpapp.Size = new System.Drawing.Size(107, 37);
            this.BtnGrpapp.TabIndex = 3;
            this.BtnGrpapp.Text = "Groupie App";
            this.BtnGrpapp.UseVisualStyleBackColor = false;
            // 
            // BtnPicbox2
            // 
            this.BtnPicbox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnPicbox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPicbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicbox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPicbox2.Location = new System.Drawing.Point(17, 101);
            this.BtnPicbox2.Name = "BtnPicbox2";
            this.BtnPicbox2.Size = new System.Drawing.Size(110, 37);
            this.BtnPicbox2.TabIndex = 2;
            this.BtnPicbox2.Text = "PictureBox2";
            this.BtnPicbox2.UseVisualStyleBackColor = false;
            // 
            // BtnSelfapp
            // 
            this.BtnSelfapp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSelfapp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSelfapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelfapp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSelfapp.Location = new System.Drawing.Point(158, 32);
            this.BtnSelfapp.Name = "BtnSelfapp";
            this.BtnSelfapp.Size = new System.Drawing.Size(108, 37);
            this.BtnSelfapp.TabIndex = 1;
            this.BtnSelfapp.Text = "SelfieApp";
            this.BtnSelfapp.UseVisualStyleBackColor = false;
            // 
            // BtnPicbox
            // 
            this.BtnPicbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnPicbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPicbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPicbox.Location = new System.Drawing.Point(17, 32);
            this.BtnPicbox.Name = "BtnPicbox";
            this.BtnPicbox.Size = new System.Drawing.Size(110, 37);
            this.BtnPicbox.TabIndex = 0;
            this.BtnPicbox.Text = "PictureBox";
            this.BtnPicbox.UseVisualStyleBackColor = false;
            this.BtnPicbox.Click += new System.EventHandler(this.BtnPicbox_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.BtnRandcom);
            this.groupBox4.Controls.Add(this.BtnTimer);
            this.groupBox4.Controls.Add(this.BtnRand);
            this.groupBox4.Controls.Add(this.BtnProg);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(29, 445);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 159);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "More Controls";
            // 
            // BtnRandcom
            // 
            this.BtnRandcom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnRandcom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRandcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandcom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRandcom.Location = new System.Drawing.Point(159, 97);
            this.BtnRandcom.Name = "BtnRandcom";
            this.BtnRandcom.Size = new System.Drawing.Size(107, 39);
            this.BtnRandcom.TabIndex = 3;
            this.BtnRandcom.Text = "RandomCom";
            this.BtnRandcom.UseVisualStyleBackColor = false;
            this.BtnRandcom.Click += new System.EventHandler(this.button11_Click);
            // 
            // BtnTimer
            // 
            this.BtnTimer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnTimer.Location = new System.Drawing.Point(159, 33);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(107, 38);
            this.BtnTimer.TabIndex = 2;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = false;
            // 
            // BtnRand
            // 
            this.BtnRand.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnRand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRand.Location = new System.Drawing.Point(17, 97);
            this.BtnRand.Name = "BtnRand";
            this.BtnRand.Size = new System.Drawing.Size(110, 39);
            this.BtnRand.TabIndex = 1;
            this.BtnRand.Text = "Random";
            this.BtnRand.UseVisualStyleBackColor = false;
            this.BtnRand.Click += new System.EventHandler(this.BtnRand_Click);
            // 
            // BtnProg
            // 
            this.BtnProg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnProg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnProg.Location = new System.Drawing.Point(17, 33);
            this.BtnProg.Name = "BtnProg";
            this.BtnProg.Size = new System.Drawing.Size(110, 38);
            this.BtnProg.TabIndex = 0;
            this.BtnProg.Text = "Progress";
            this.BtnProg.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.BtnTalk);
            this.groupBox5.Controls.Add(this.BtnDraw);
            this.groupBox5.Font = new System.Drawing.Font("Adobe Heiti Std R", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Red;
            this.groupBox5.Location = new System.Drawing.Point(691, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 154);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Draw and Talk";
            // 
            // BtnTalk
            // 
            this.BtnTalk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnTalk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTalk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnTalk.Location = new System.Drawing.Point(180, 47);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(110, 54);
            this.BtnTalk.TabIndex = 1;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = false;
            // 
            // BtnDraw
            // 
            this.BtnDraw.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnDraw.Location = new System.Drawing.Point(17, 46);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(110, 54);
            this.BtnDraw.TabIndex = 0;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = false;
            this.BtnDraw.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.BtnJohari);
            this.groupBox6.Controls.Add(this.BtnABC);
            this.groupBox6.Controls.Add(this.BtnRobotcell);
            this.groupBox6.Controls.Add(this.BtnMancell);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(691, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(309, 226);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Exam Apps";
            // 
            // BtnJohari
            // 
            this.BtnJohari.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnJohari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnJohari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJohari.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnJohari.Location = new System.Drawing.Point(164, 141);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(126, 58);
            this.BtnJohari.TabIndex = 3;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = false;
            // 
            // BtnABC
            // 
            this.BtnABC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnABC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnABC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnABC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnABC.Location = new System.Drawing.Point(17, 141);
            this.BtnABC.Name = "BtnABC";
            this.BtnABC.Size = new System.Drawing.Size(126, 58);
            this.BtnABC.TabIndex = 2;
            this.BtnABC.Text = "ABC Analysis";
            this.BtnABC.UseVisualStyleBackColor = false;
            // 
            // BtnRobotcell
            // 
            this.BtnRobotcell.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnRobotcell.Cursor = System.Windows.Forms.Cursors.No;
            this.BtnRobotcell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRobotcell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRobotcell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRobotcell.Location = new System.Drawing.Point(164, 43);
            this.BtnRobotcell.Name = "BtnRobotcell";
            this.BtnRobotcell.Size = new System.Drawing.Size(126, 60);
            this.BtnRobotcell.TabIndex = 1;
            this.BtnRobotcell.Text = "Robotic Cell";
            this.BtnRobotcell.UseVisualStyleBackColor = false;
            // 
            // BtnMancell
            // 
            this.BtnMancell.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnMancell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMancell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMancell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMancell.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMancell.Location = new System.Drawing.Point(17, 43);
            this.BtnMancell.Name = "BtnMancell";
            this.BtnMancell.Size = new System.Drawing.Size(126, 60);
            this.BtnMancell.TabIndex = 0;
            this.BtnMancell.Text = "Manufacturing Cell";
            this.BtnMancell.UseVisualStyleBackColor = false;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.BtnArduino);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.Red;
            this.groupBox7.Location = new System.Drawing.Point(355, 445);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(296, 159);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Micro Controller";
            // 
            // BtnArduino
            // 
            this.BtnArduino.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnArduino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnArduino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArduino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnArduino.Location = new System.Drawing.Point(49, 49);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(197, 73);
            this.BtnArduino.TabIndex = 0;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::FAISAL_IE322.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 624);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnGrpapp;
        private System.Windows.Forms.Button BtnPicbox2;
        private System.Windows.Forms.Button BtnSelfapp;
        private System.Windows.Forms.Button BtnPicbox;
        private System.Windows.Forms.Button BtnRandcom;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnRand;
        private System.Windows.Forms.Button BtnProg;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnABC;
        private System.Windows.Forms.Button BtnRobotcell;
        private System.Windows.Forms.Button BtnMancell;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Button BtnAbt;
    }
}

