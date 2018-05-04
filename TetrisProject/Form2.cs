using System;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisProject
{
    public partial class Form2 : Form
    {
        SelectBlock selectBlock1;
        SelectBlock selectBlock2;

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            Scores.startScores();
            selectBlock1 = new SelectBlock();
            selectBlock2 = new SelectBlock();
        }

        private void moveSelectBlocks(int x, int y) {
            int endx = x + 199;
            selectBlock1.position = new Point(x, y);
            selectBlock2.position = new Point(endx, y);
            Invalidate(true);
        }

        private void button1_MouseEnter(object sender, EventArgs e) {
            moveSelectBlocks(button1.Location.X - 40, button1.Location.Y + 3);
        }

        private void button2_MouseEnter(object sender, EventArgs e) {
            moveSelectBlocks(button2.Location.X - 40, button2.Location.Y + 3);
        }

        private void button3_MouseEnter(object sender, EventArgs e) {
            moveSelectBlocks(button3.Location.X - 40, button3.Location.Y + 3);
        }

        private void button4_MouseEnter(object sender, EventArgs e) {
            moveSelectBlocks(button4.Location.X - 40, button4.Location.Y + 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            this.Hide();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            HowToPlayForm howToPlay = new HowToPlayForm();
            howToPlay.showText();
            howToPlay.ShowDialog();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            Top10Form top10form1 = new Top10Form(Scores.top10);
            top10form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MultiplayerForm mpForm1 = new MultiplayerForm(this);
            this.Hide();
            mpForm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // ARCADE BUTTON
        {
            moveSelectBlocks(-20, -20);
            showButtons(false);
            panel1.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            Form1 form1 = new Form1(this, (int)numLevel.Value);
            if(form1.ShowDialog() == DialogResult.OK)
            {
                showButtons();
                panel1.Visible = false;
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e) {
            selectBlock1.draw(e.Graphics);
            selectBlock2.draw(e.Graphics);
        }

        private void showButtons(bool yes=true) {
            button1.Visible = yes;
            button2.Visible = yes;
            button3.Visible = yes;
            button4.Visible = yes;
        }

        private void Form2_Load(object sender, EventArgs e) {
            button1.Focus();
            moveSelectBlocks(button1.Location.X - 40, button1.Location.Y + 3);
        }

        private void btnBack_Click(object sender, EventArgs e) {
            panel1.Visible = false;
            showButtons();
        }
    }

    class SelectBlock
    {
        public Point position {
            get { return new Point(stX, stY); }
            set { stX = value.X; stY = value.Y; }
        }
        private int stX { get; set; }
        private int stY { get; set; }
        int side = 20, smSide = 12;
        int smX, smY;
        Point middle;

        public SelectBlock() {
            this.position = new Point(-100, -100);
        }

        public void draw(Graphics g) {
            updateParameters();
            fillMethod(new SolidBrush(Color.FromArgb(185, 255, 198)),
                new Point[] { new Point(stX, stY), new Point(stX + side, stY), middle }, g);
            fillMethod(new SolidBrush(Color.FromArgb(65, 255, 105)), 
                new Point[] { new Point(stX, stY), new Point(stX, stY + side), middle }, g);
            fillMethod(new SolidBrush(Color.FromArgb(15, 145, 25)),
                new Point[] { new Point(stX, stY + side), new Point(stX + side, stY + side), middle }, g);
            fillMethod(new SolidBrush(Color.FromArgb(15, 160, 25)),
                new Point[] { new Point(stX + side, stY), new Point(stX + side, stY + side), middle }, g);
            g.FillRectangle(new SolidBrush(Color.FromArgb(25, 230, 45)), smX, smY, smSide, smSide);
        }

        private void updateParameters() {
            smX = stX + ((side - smSide) / 2);
            smY = stY + ((side - smSide) / 2);
            middle = new Point(stX + (side / 2), stY + (side / 2));
        }

        private void fillMethod(Brush br, Point[] points, Graphics g) {
            g.FillPolygon(br, points);
        }
    }
}
