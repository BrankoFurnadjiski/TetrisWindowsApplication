using System.Drawing;

namespace TetrisProject
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbNextShape = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.pbSound = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
            this.pictureBox1.Location = new System.Drawing.Point(146, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 512);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbNextShape
            // 
            this.pbNextShape.BackColor = System.Drawing.Color.White;
            this.pbNextShape.Location = new System.Drawing.Point(13, 30);
            this.pbNextShape.Name = "pbNextShape";
            this.pbNextShape.Size = new System.Drawing.Size(127, 170);
            this.pbNextShape.TabIndex = 1;
            this.pbNextShape.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(211, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 110);
            this.label1.TabIndex = 2;
            this.label1.Text = "GAME\r\nOVER";
            this.label1.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(13, 30);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(127, 59);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(37)))), ((int)(((byte)(69)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(13, 227);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(49)))), ((int)(((byte)(93)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "High score:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(55)))), ((int)(((byte)(99)))));
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHighScore.ForeColor = System.Drawing.Color.Black;
            this.lblHighScore.Location = new System.Drawing.Point(13, 281);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(18, 20);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "0";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPause.Location = new System.Drawing.Point(181, 196);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(228, 55);
            this.lblPause.TabIndex = 2;
            this.lblPause.Text = "PAUSED";
            this.lblPause.Visible = false;
            // 
            // pbSound
            // 
            this.pbSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(195)))));
            this.pbSound.Image = global::TetrisProject.Properties.Resources.mute;
            this.pbSound.Location = new System.Drawing.Point(13, 492);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(50, 50);
            this.pbSound.TabIndex = 7;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pbSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TetrisProject.Properties.Resources.bckgr;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.pbSound);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbNextShape);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris - Single player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbNextShape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.PictureBox pbSound;
    }
}

