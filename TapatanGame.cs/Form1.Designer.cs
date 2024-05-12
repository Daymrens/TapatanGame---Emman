namespace TapatanGame.cs
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitpnl = new System.Windows.Forms.Panel();
            this.btnFexitno = new System.Windows.Forms.Button();
            this.btnFexityes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpnlclos = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.optpnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.exitpnl.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.optpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Aqua;
            this.btnAbout.Location = new System.Drawing.Point(11, 429);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(144, 49);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.Aqua;
            this.btnOptions.Location = new System.Drawing.Point(175, 429);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(144, 49);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.optbtn);
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Aqua;
            this.Exit.Location = new System.Drawing.Point(338, 429);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(144, 49);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.btnExitGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = " T A P A T A N ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(191, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A Game of Strategy";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Aqua;
            this.btnPlay.Location = new System.Drawing.Point(141, 105);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(210, 89);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "P L A Y";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.Playbtn);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exitpnl);
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 277);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TapatanGame.cs.Properties.Resources.gamebg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // exitpnl
            // 
            this.exitpnl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.exitpnl.Controls.Add(this.btnFexitno);
            this.exitpnl.Controls.Add(this.btnFexityes);
            this.exitpnl.Controls.Add(this.label5);
            this.exitpnl.Location = new System.Drawing.Point(106, 52);
            this.exitpnl.Name = "exitpnl";
            this.exitpnl.Size = new System.Drawing.Size(281, 196);
            this.exitpnl.TabIndex = 14;
            // 
            // btnFexitno
            // 
            this.btnFexitno.BackColor = System.Drawing.Color.Transparent;
            this.btnFexitno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFexitno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFexitno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFexitno.ForeColor = System.Drawing.Color.Turquoise;
            this.btnFexitno.Location = new System.Drawing.Point(154, 128);
            this.btnFexitno.Name = "btnFexitno";
            this.btnFexitno.Size = new System.Drawing.Size(92, 49);
            this.btnFexitno.TabIndex = 2;
            this.btnFexitno.Text = "No";
            this.btnFexitno.UseVisualStyleBackColor = false;
            this.btnFexitno.Click += new System.EventHandler(this.exitNo);
            // 
            // btnFexityes
            // 
            this.btnFexityes.BackColor = System.Drawing.Color.Transparent;
            this.btnFexityes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFexityes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFexityes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFexityes.ForeColor = System.Drawing.Color.Turquoise;
            this.btnFexityes.Location = new System.Drawing.Point(47, 128);
            this.btnFexityes.Name = "btnFexityes";
            this.btnFexityes.Size = new System.Drawing.Size(92, 49);
            this.btnFexityes.TabIndex = 1;
            this.btnFexityes.Text = "Yes";
            this.btnFexityes.UseVisualStyleBackColor = false;
            this.btnFexityes.Click += new System.EventHandler(this.exitYes);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Turquoise;
            this.label5.Location = new System.Drawing.Point(32, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Are you sure to exit this game?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnpnlclos);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 370);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = " O P T I O N S ";
            // 
            // btnpnlclos
            // 
            this.btnpnlclos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnpnlclos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnpnlclos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpnlclos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpnlclos.ForeColor = System.Drawing.Color.Aqua;
            this.btnpnlclos.Location = new System.Drawing.Point(12, 309);
            this.btnpnlclos.Name = "btnpnlclos";
            this.btnpnlclos.Size = new System.Drawing.Size(270, 49);
            this.btnpnlclos.TabIndex = 16;
            this.btnpnlclos.Text = "Back";
            this.btnpnlclos.UseVisualStyleBackColor = true;
            this.btnpnlclos.Click += new System.EventHandler(this.exitOpt);
            // 
            // button8
            // 
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Aqua;
            this.button8.Location = new System.Drawing.Point(158, 246);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 49);
            this.button8.TabIndex = 15;
            this.button8.Text = "On";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.musicon);
            // 
            // button7
            // 
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Aqua;
            this.button7.Location = new System.Drawing.Point(32, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 49);
            this.button7.TabIndex = 14;
            this.button7.Text = "Off";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.musicoff);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(116, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "M U S I C";
            // 
            // button6
            // 
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Aqua;
            this.button6.Location = new System.Drawing.Point(12, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(270, 49);
            this.button6.TabIndex = 4;
            this.button6.Text = "Hard";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Aqua;
            this.button5.Location = new System.Drawing.Point(14, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(270, 49);
            this.button5.TabIndex = 3;
            this.button5.Text = "Medium";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(14, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(270, 49);
            this.button4.TabIndex = 2;
            this.button4.Text = "Easy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TapatanGame.cs.Properties.Resources.down;
            this.pictureBox2.Location = new System.Drawing.Point(0, 380);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(493, 277);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TapatanGame.cs.Properties.Resources.up;
            this.pictureBox3.Location = new System.Drawing.Point(0, -145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(493, 277);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // optpnl
            // 
            this.optpnl.BackColor = System.Drawing.Color.Turquoise;
            this.optpnl.Controls.Add(this.panel2);
            this.optpnl.Location = new System.Drawing.Point(106, 85);
            this.optpnl.Name = "optpnl";
            this.optpnl.Size = new System.Drawing.Size(304, 378);
            this.optpnl.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(490, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.optpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.exitpnl.ResumeLayout(false);
            this.exitpnl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.optpnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnpnlclos;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel optpnl;
        private System.Windows.Forms.Panel exitpnl;
        private System.Windows.Forms.Button btnFexitno;
        private System.Windows.Forms.Button btnFexityes;
        private System.Windows.Forms.Label label5;
    }
}

