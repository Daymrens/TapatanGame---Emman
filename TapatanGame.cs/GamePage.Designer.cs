namespace TapatanGame.cs
{
    partial class GamePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.pnlgameboard = new System.Windows.Forms.Panel();
            this.pbpos9 = new System.Windows.Forms.PictureBox();
            this.pbpos8 = new System.Windows.Forms.PictureBox();
            this.pbpos7 = new System.Windows.Forms.PictureBox();
            this.pbpos4 = new System.Windows.Forms.PictureBox();
            this.pbpos6 = new System.Windows.Forms.PictureBox();
            this.pbpos3 = new System.Windows.Forms.PictureBox();
            this.pbpos2 = new System.Windows.Forms.PictureBox();
            this.pbpos5 = new System.Windows.Forms.PictureBox();
            this.pbpos1 = new System.Windows.Forms.PictureBox();
            this.pbboardaxis = new System.Windows.Forms.PictureBox();
            this.pnlbckonlopt = new System.Windows.Forms.Panel();
            this.pnlsettings = new System.Windows.Forms.Panel();
            this.exitpnl = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnleadboard = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlleadboard2 = new System.Windows.Forms.Panel();
            this.lblleadboard = new System.Windows.Forms.Label();
            this.pnlleadboard3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblp1turn = new System.Windows.Forms.Label();
            this.lblp2turn = new System.Windows.Forms.Label();
            this.pbp1 = new System.Windows.Forms.PictureBox();
            this.pbp2 = new System.Windows.Forms.PictureBox();
            this.leaderboardListBox = new System.Windows.Forms.ListBox();
            this.pnlgameboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbboardaxis)).BeginInit();
            this.pnlbckonlopt.SuspendLayout();
            this.pnlsettings.SuspendLayout();
            this.exitpnl.SuspendLayout();
            this.pnlleadboard2.SuspendLayout();
            this.pnlleadboard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbp2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlgameboard
            // 
            this.pnlgameboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlgameboard.Controls.Add(this.pbpos9);
            this.pnlgameboard.Controls.Add(this.pbpos8);
            this.pnlgameboard.Controls.Add(this.pbpos7);
            this.pnlgameboard.Controls.Add(this.pbpos4);
            this.pnlgameboard.Controls.Add(this.pbpos6);
            this.pnlgameboard.Controls.Add(this.pbpos3);
            this.pnlgameboard.Controls.Add(this.pbpos2);
            this.pnlgameboard.Controls.Add(this.pbpos5);
            this.pnlgameboard.Controls.Add(this.pbpos1);
            this.pnlgameboard.Controls.Add(this.pbboardaxis);
            this.pnlgameboard.Controls.Add(this.pnlbckonlopt);
            this.pnlgameboard.Controls.Add(this.pnlleadboard2);
            this.pnlgameboard.Location = new System.Drawing.Point(77, 165);
            this.pnlgameboard.Name = "pnlgameboard";
            this.pnlgameboard.Size = new System.Drawing.Size(514, 509);
            this.pnlgameboard.TabIndex = 0;
            // 
            // pbpos9
            // 
            this.pbpos9.BackColor = System.Drawing.Color.Transparent;
            this.pbpos9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos9.Location = new System.Drawing.Point(437, 434);
            this.pbpos9.Name = "pbpos9";
            this.pbpos9.Size = new System.Drawing.Size(65, 65);
            this.pbpos9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos9.TabIndex = 10;
            this.pbpos9.TabStop = false;
            this.pbpos9.Click += new System.EventHandler(this.cells);
            // 
            // pbpos8
            // 
            this.pbpos8.BackColor = System.Drawing.Color.Transparent;
            this.pbpos8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos8.Location = new System.Drawing.Point(225, 434);
            this.pbpos8.Name = "pbpos8";
            this.pbpos8.Size = new System.Drawing.Size(65, 65);
            this.pbpos8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos8.TabIndex = 9;
            this.pbpos8.TabStop = false;
            this.pbpos8.Click += new System.EventHandler(this.cells);
            // 
            // pbpos7
            // 
            this.pbpos7.BackColor = System.Drawing.Color.Transparent;
            this.pbpos7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos7.Location = new System.Drawing.Point(10, 434);
            this.pbpos7.Name = "pbpos7";
            this.pbpos7.Size = new System.Drawing.Size(65, 65);
            this.pbpos7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos7.TabIndex = 8;
            this.pbpos7.TabStop = false;
            this.pbpos7.Click += new System.EventHandler(this.cells);
            // 
            // pbpos4
            // 
            this.pbpos4.BackColor = System.Drawing.Color.Transparent;
            this.pbpos4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos4.Location = new System.Drawing.Point(10, 216);
            this.pbpos4.Name = "pbpos4";
            this.pbpos4.Size = new System.Drawing.Size(65, 65);
            this.pbpos4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos4.TabIndex = 7;
            this.pbpos4.TabStop = false;
            this.pbpos4.Click += new System.EventHandler(this.cells);
            // 
            // pbpos6
            // 
            this.pbpos6.BackColor = System.Drawing.Color.Transparent;
            this.pbpos6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbpos6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos6.Location = new System.Drawing.Point(437, 216);
            this.pbpos6.Name = "pbpos6";
            this.pbpos6.Size = new System.Drawing.Size(65, 65);
            this.pbpos6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos6.TabIndex = 6;
            this.pbpos6.TabStop = false;
            this.pbpos6.Click += new System.EventHandler(this.cells);
            // 
            // pbpos3
            // 
            this.pbpos3.BackColor = System.Drawing.Color.Transparent;
            this.pbpos3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos3.Location = new System.Drawing.Point(437, 11);
            this.pbpos3.Name = "pbpos3";
            this.pbpos3.Size = new System.Drawing.Size(65, 65);
            this.pbpos3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos3.TabIndex = 5;
            this.pbpos3.TabStop = false;
            this.pbpos3.Click += new System.EventHandler(this.cells);
            // 
            // pbpos2
            // 
            this.pbpos2.BackColor = System.Drawing.Color.Transparent;
            this.pbpos2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos2.Location = new System.Drawing.Point(225, 11);
            this.pbpos2.Name = "pbpos2";
            this.pbpos2.Size = new System.Drawing.Size(65, 65);
            this.pbpos2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos2.TabIndex = 4;
            this.pbpos2.TabStop = false;
            this.pbpos2.Click += new System.EventHandler(this.cells);
            // 
            // pbpos5
            // 
            this.pbpos5.BackColor = System.Drawing.Color.Transparent;
            this.pbpos5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos5.Location = new System.Drawing.Point(225, 216);
            this.pbpos5.Name = "pbpos5";
            this.pbpos5.Size = new System.Drawing.Size(65, 65);
            this.pbpos5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos5.TabIndex = 3;
            this.pbpos5.TabStop = false;
            this.pbpos5.Click += new System.EventHandler(this.cells);
            // 
            // pbpos1
            // 
            this.pbpos1.BackColor = System.Drawing.Color.Transparent;
            this.pbpos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbpos1.Location = new System.Drawing.Point(10, 11);
            this.pbpos1.Name = "pbpos1";
            this.pbpos1.Size = new System.Drawing.Size(65, 65);
            this.pbpos1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpos1.TabIndex = 2;
            this.pbpos1.TabStop = false;
            this.pbpos1.Click += new System.EventHandler(this.cells);
            // 
            // pbboardaxis
            // 
            this.pbboardaxis.Image = global::TapatanGame.cs.Properties.Resources.myaxis;
            this.pbboardaxis.Location = new System.Drawing.Point(46, 45);
            this.pbboardaxis.Name = "pbboardaxis";
            this.pbboardaxis.Size = new System.Drawing.Size(425, 425);
            this.pbboardaxis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbboardaxis.TabIndex = 1;
            this.pbboardaxis.TabStop = false;
            // 
            // pnlbckonlopt
            // 
            this.pnlbckonlopt.BackColor = System.Drawing.Color.Turquoise;
            this.pnlbckonlopt.Controls.Add(this.pnlsettings);
            this.pnlbckonlopt.Location = new System.Drawing.Point(102, 45);
            this.pnlbckonlopt.Name = "pnlbckonlopt";
            this.pnlbckonlopt.Size = new System.Drawing.Size(303, 422);
            this.pnlbckonlopt.TabIndex = 14;
            // 
            // pnlsettings
            // 
            this.pnlsettings.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnlsettings.Controls.Add(this.exitpnl);
            this.pnlsettings.Controls.Add(this.button6);
            this.pnlsettings.Controls.Add(this.button8);
            this.pnlsettings.Controls.Add(this.button7);
            this.pnlsettings.Controls.Add(this.label3);
            this.pnlsettings.Controls.Add(this.btnleadboard);
            this.pnlsettings.Controls.Add(this.btnrestart);
            this.pnlsettings.Controls.Add(this.btnback);
            this.pnlsettings.Controls.Add(this.button1);
            this.pnlsettings.Location = new System.Drawing.Point(4, 5);
            this.pnlsettings.Name = "pnlsettings";
            this.pnlsettings.Size = new System.Drawing.Size(295, 413);
            this.pnlsettings.TabIndex = 8;
            // 
            // exitpnl
            // 
            this.exitpnl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.exitpnl.Controls.Add(this.button10);
            this.exitpnl.Controls.Add(this.button9);
            this.exitpnl.Controls.Add(this.label2);
            this.exitpnl.Location = new System.Drawing.Point(7, 136);
            this.exitpnl.Name = "exitpnl";
            this.exitpnl.Size = new System.Drawing.Size(280, 196);
            this.exitpnl.TabIndex = 9;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(154, 125);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 49);
            this.button10.TabIndex = 2;
            this.button10.Text = "No";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.exitNo);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(45, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 49);
            this.button9.TabIndex = 1;
            this.button9.Text = "Yes";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.exitYes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Are you sure to exit this game?";
            // 
            // button6
            // 
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Turquoise;
            this.button6.Location = new System.Drawing.Point(13, 349);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 49);
            this.button6.TabIndex = 19;
            this.button6.Text = "Exit Game";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.exitGame);
            // 
            // button8
            // 
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Aqua;
            this.button8.Location = new System.Drawing.Point(159, 224);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 49);
            this.button8.TabIndex = 18;
            this.button8.Text = "On";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.musicon);
            // 
            // button7
            // 
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Aqua;
            this.button7.Location = new System.Drawing.Point(31, 224);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 49);
            this.button7.TabIndex = 17;
            this.button7.Text = "Off";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.musicoff);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(118, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "M U S I C";
            // 
            // btnleadboard
            // 
            this.btnleadboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnleadboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnleadboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleadboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnleadboard.ForeColor = System.Drawing.Color.Turquoise;
            this.btnleadboard.Location = new System.Drawing.Point(13, 16);
            this.btnleadboard.Name = "btnleadboard";
            this.btnleadboard.Size = new System.Drawing.Size(270, 49);
            this.btnleadboard.TabIndex = 4;
            this.btnleadboard.Text = "Leader Board";
            this.btnleadboard.UseVisualStyleBackColor = true;
            this.btnleadboard.Click += new System.EventHandler(this.leadbaord);
            // 
            // btnrestart
            // 
            this.btnrestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnrestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnrestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.ForeColor = System.Drawing.Color.Turquoise;
            this.btnrestart.Location = new System.Drawing.Point(13, 81);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(270, 49);
            this.btnrestart.TabIndex = 3;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.Game_Restart);
            // 
            // btnback
            // 
            this.btnback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Turquoise;
            this.btnback.Location = new System.Drawing.Point(13, 294);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(270, 49);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Resume";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.gpSkippnl);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(13, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Homepg);
            // 
            // pnlleadboard2
            // 
            this.pnlleadboard2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlleadboard2.Controls.Add(this.lblleadboard);
            this.pnlleadboard2.Controls.Add(this.pnlleadboard3);
            this.pnlleadboard2.Location = new System.Drawing.Point(83, 166);
            this.pnlleadboard2.Name = "pnlleadboard2";
            this.pnlleadboard2.Size = new System.Drawing.Size(348, 213);
            this.pnlleadboard2.TabIndex = 15;
            // 
            // lblleadboard
            // 
            this.lblleadboard.AutoSize = true;
            this.lblleadboard.BackColor = System.Drawing.Color.Transparent;
            this.lblleadboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblleadboard.Font = new System.Drawing.Font("MODERN WARFARE", 20.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblleadboard.Location = new System.Drawing.Point(14, 11);
            this.lblleadboard.Name = "lblleadboard";
            this.lblleadboard.Size = new System.Drawing.Size(322, 22);
            this.lblleadboard.TabIndex = 0;
            this.lblleadboard.Text = "L E A D E R B O A R D";
            // 
            // pnlleadboard3
            // 
            this.pnlleadboard3.BackColor = System.Drawing.Color.Turquoise;
            this.pnlleadboard3.Controls.Add(this.leaderboardListBox);
            this.pnlleadboard3.Controls.Add(this.button2);
            this.pnlleadboard3.Location = new System.Drawing.Point(9, 43);
            this.pnlleadboard3.Name = "pnlleadboard3";
            this.pnlleadboard3.Size = new System.Drawing.Size(333, 161);
            this.pnlleadboard3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(263, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "skip";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.skipleadboard);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = " T A P A T A N ";
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(552, 30);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(27, 30);
            this.btnOptions.TabIndex = 7;
            this.btnOptions.Text = "=";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.gpSetting);
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblp1turn
            // 
            this.lblp1turn.AutoSize = true;
            this.lblp1turn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblp1turn.Location = new System.Drawing.Point(192, 108);
            this.lblp1turn.Name = "lblp1turn";
            this.lblp1turn.Size = new System.Drawing.Size(45, 13);
            this.lblp1turn.TabIndex = 12;
            this.lblp1turn.Text = "My turn!";
            // 
            // lblp2turn
            // 
            this.lblp2turn.AutoSize = true;
            this.lblp2turn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblp2turn.Location = new System.Drawing.Point(426, 108);
            this.lblp2turn.Name = "lblp2turn";
            this.lblp2turn.Size = new System.Drawing.Size(45, 13);
            this.lblp2turn.TabIndex = 13;
            this.lblp2turn.Text = "My turn!";
            // 
            // pbp1
            // 
            this.pbp1.Image = ((System.Drawing.Image)(resources.GetObject("pbp1.Image")));
            this.pbp1.Location = new System.Drawing.Point(123, 97);
            this.pbp1.Name = "pbp1";
            this.pbp1.Size = new System.Drawing.Size(50, 50);
            this.pbp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbp1.TabIndex = 11;
            this.pbp1.TabStop = false;
            // 
            // pbp2
            // 
            this.pbp2.Image = ((System.Drawing.Image)(resources.GetObject("pbp2.Image")));
            this.pbp2.Location = new System.Drawing.Point(498, 97);
            this.pbp2.Name = "pbp2";
            this.pbp2.Size = new System.Drawing.Size(50, 50);
            this.pbp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbp2.TabIndex = 10;
            this.pbp2.TabStop = false;
            // 
            // leaderboardListBox
            // 
            this.leaderboardListBox.BackColor = System.Drawing.Color.Turquoise;
            this.leaderboardListBox.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardListBox.FormattingEnabled = true;
            this.leaderboardListBox.Location = new System.Drawing.Point(9, 12);
            this.leaderboardListBox.Name = "leaderboardListBox";
            this.leaderboardListBox.Size = new System.Drawing.Size(318, 108);
            this.leaderboardListBox.TabIndex = 10;
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(664, 709);
            this.Controls.Add(this.lblp2turn);
            this.Controls.Add(this.lblp1turn);
            this.Controls.Add(this.pbp1);
            this.Controls.Add(this.pbp2);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlgameboard);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlgameboard.ResumeLayout(false);
            this.pnlgameboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbboardaxis)).EndInit();
            this.pnlbckonlopt.ResumeLayout(false);
            this.pnlsettings.ResumeLayout(false);
            this.pnlsettings.PerformLayout();
            this.exitpnl.ResumeLayout(false);
            this.exitpnl.PerformLayout();
            this.pnlleadboard2.ResumeLayout(false);
            this.pnlleadboard2.PerformLayout();
            this.pnlleadboard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlgameboard;
        private System.Windows.Forms.PictureBox pbboardaxis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbpos9;
        private System.Windows.Forms.PictureBox pbpos8;
        private System.Windows.Forms.PictureBox pbpos7;
        private System.Windows.Forms.PictureBox pbpos4;
        private System.Windows.Forms.PictureBox pbpos6;
        private System.Windows.Forms.PictureBox pbpos3;
        private System.Windows.Forms.PictureBox pbpos2;
        private System.Windows.Forms.PictureBox pbpos5;
        private System.Windows.Forms.PictureBox pbpos1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlsettings;
        private System.Windows.Forms.Button btnleadboard;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel exitpnl;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pbp2;
        private System.Windows.Forms.PictureBox pbp1;
        private System.Windows.Forms.Label lblp1turn;
        private System.Windows.Forms.Label lblp2turn;
        private System.Windows.Forms.Panel pnlbckonlopt;
        private System.Windows.Forms.Panel pnlleadboard2;
        private System.Windows.Forms.Label lblleadboard;
        private System.Windows.Forms.Panel pnlleadboard3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox leaderboardListBox;
    }
}