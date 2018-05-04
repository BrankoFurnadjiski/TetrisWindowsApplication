namespace TetrisProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHowToPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnHowToPlay.Image")));
            this.btnHowToPlay.Location = new System.Drawing.Point(232, 511);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(82, 23);
            this.btnHowToPlay.TabIndex = 12;
            this.btnHowToPlay.Text = "How to Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.Font = this.btnHowToPlay.Font;
            this.btnTop10.ForeColor = this.btnHowToPlay.ForeColor;
            this.btnTop10.Image = ((System.Drawing.Image)(resources.GetObject("btnTop10.Image")));
            this.btnTop10.Location = new System.Drawing.Point(320, 511);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(82, 23);
            this.btnTop10.TabIndex = 12;
            this.btnTop10.Text = "Top 10";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.numLevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(214, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 134);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(72, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(72, 73);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numLevel
            // 
            this.numLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numLevel.Location = new System.Drawing.Point(72, 38);
            this.numLevel.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(75, 29);
            this.numLevel.TabIndex = 1;
            this.numLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose level:";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(250, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Arcade";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(250, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(250, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Multiplayer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(250, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Single Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.button3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}