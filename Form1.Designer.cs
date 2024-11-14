namespace WindowsApplicationGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbWinnerIs = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.lbPlayerTurn = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRestart);
            this.groupBox1.Controls.Add(this.lbWinnerIs);
            this.groupBox1.Controls.Add(this.lbWinner);
            this.groupBox1.Controls.Add(this.lbPlayerTurn);
            this.groupBox1.Controls.Add(this.lbTurn);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 778);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Khaki;
            this.btnRestart.Location = new System.Drawing.Point(67, 541);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(199, 60);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbWinnerIs
            // 
            this.lbWinnerIs.AutoSize = true;
            this.lbWinnerIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinnerIs.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbWinnerIs.Location = new System.Drawing.Point(32, 404);
            this.lbWinnerIs.Name = "lbWinnerIs";
            this.lbWinnerIs.Size = new System.Drawing.Size(234, 46);
            this.lbWinnerIs.TabIndex = 3;
            this.lbWinnerIs.Text = "In Progress";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.YellowGreen;
            this.lbWinner.Location = new System.Drawing.Point(12, 327);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(177, 51);
            this.lbWinner.TabIndex = 2;
            this.lbWinner.Text = "Winner ";
            // 
            // lbPlayerTurn
            // 
            this.lbPlayerTurn.AutoSize = true;
            this.lbPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerTurn.ForeColor = System.Drawing.Color.Ivory;
            this.lbPlayerTurn.Location = new System.Drawing.Point(12, 214);
            this.lbPlayerTurn.Name = "lbPlayerTurn";
            this.lbPlayerTurn.Size = new System.Drawing.Size(174, 46);
            this.lbPlayerTurn.TabIndex = 1;
            this.lbPlayerTurn.Text = "Player 1";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.Bisque;
            this.lbTurn.Location = new System.Drawing.Point(12, 153);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(117, 46);
            this.lbTurn.TabIndex = 0;
            this.lbTurn.Text = "Turn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(675, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // pic1
            // 
            this.pic1.BackColor = System.Drawing.Color.Black;
            this.pic1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic1.ErrorImage = null;
            this.pic1.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic1.InitialImage = global::WindowsApplicationGame.Properties.Resources.black_abstract_background_hexagon_pattern_with_light_rays_99236_811;
            this.pic1.Location = new System.Drawing.Point(467, 140);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(163, 155);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            this.pic1.Tag = "?";
            this.pic1.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic2
            // 
            this.pic2.BackColor = System.Drawing.Color.Black;
            this.pic2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic2.ErrorImage = null;
            this.pic2.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic2.Location = new System.Drawing.Point(835, 140);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(163, 155);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            this.pic2.Tag = "?";
            this.pic2.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic3
            // 
            this.pic3.BackColor = System.Drawing.Color.Black;
            this.pic3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic3.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic3.Location = new System.Drawing.Point(1208, 140);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(163, 155);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic3.TabIndex = 5;
            this.pic3.TabStop = false;
            this.pic3.Tag = "?";
            this.pic3.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic4
            // 
            this.pic4.BackColor = System.Drawing.Color.Black;
            this.pic4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic4.ErrorImage = null;
            this.pic4.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic4.Location = new System.Drawing.Point(467, 366);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(163, 155);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic4.TabIndex = 12;
            this.pic4.TabStop = false;
            this.pic4.Tag = "?";
            this.pic4.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic5
            // 
            this.pic5.BackColor = System.Drawing.Color.Black;
            this.pic5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic5.ErrorImage = null;
            this.pic5.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic5.Location = new System.Drawing.Point(835, 366);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(163, 155);
            this.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic5.TabIndex = 13;
            this.pic5.TabStop = false;
            this.pic5.Tag = "?";
            this.pic5.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic6
            // 
            this.pic6.BackColor = System.Drawing.Color.Black;
            this.pic6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic6.ErrorImage = null;
            this.pic6.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic6.Location = new System.Drawing.Point(1208, 366);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(163, 155);
            this.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic6.TabIndex = 14;
            this.pic6.TabStop = false;
            this.pic6.Tag = "?";
            this.pic6.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic9
            // 
            this.pic9.BackColor = System.Drawing.Color.Black;
            this.pic9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic9.ErrorImage = null;
            this.pic9.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic9.Location = new System.Drawing.Point(1208, 577);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(163, 155);
            this.pic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic9.TabIndex = 15;
            this.pic9.TabStop = false;
            this.pic9.Tag = "?";
            this.pic9.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic8
            // 
            this.pic8.BackColor = System.Drawing.Color.Black;
            this.pic8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic8.ErrorImage = null;
            this.pic8.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic8.Location = new System.Drawing.Point(835, 577);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(163, 155);
            this.pic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic8.TabIndex = 16;
            this.pic8.TabStop = false;
            this.pic8.Tag = "?";
            this.pic8.Click += new System.EventHandler(this.Button_Click);
            // 
            // pic7
            // 
            this.pic7.BackColor = System.Drawing.Color.Black;
            this.pic7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic7.ErrorImage = null;
            this.pic7.Image = global::WindowsApplicationGame.Properties.Resources.f6aaee4e_1a27_4053_943c_b81cc5742c9d1;
            this.pic7.Location = new System.Drawing.Point(467, 577);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(163, 155);
            this.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic7.TabIndex = 17;
            this.pic7.TabStop = false;
            this.pic7.Tag = "?";
            this.pic7.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::WindowsApplicationGame.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1507, 778);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbWinnerIs;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Label lbPlayerTurn;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic7;
    }
}

