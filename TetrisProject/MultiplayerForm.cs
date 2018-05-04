using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisProject
{
    public partial class MultiplayerForm : Form
    {
        Timer timer1p1;
        Timer timer2p1;
        Scene scenep1;
        bool isPausedp1;

        Timer timer1p2;
        Timer timer2p2;
        Scene scenep2;
        bool isPausedp2;

        bool isGameOver;
        bool isMuted;

        System.IO.Stream str;
        System.Media.SoundPlayer snd;

        Form reference;

        public MultiplayerForm(Form reference)
        {
            InitializeComponent();
            scenep1 = new Scene();
            timer1p1 = new Timer();
            timer1p1.Interval = 500 - 50 * 1;
            timer1p1.Tick += Timer1p1_Tick;
            timer1p1.Start();
            DoubleBuffered = true;
            isPausedp1 = false;
            timer2p1 = new Timer();
            timer2p1.Interval = 15;
            timer2p1.Tick += Timer2p1_Tick;

            scenep2 = new Scene();
            timer1p2 = new Timer();
            timer1p2.Interval = 500 - 50 * 1;
            timer1p2.Tick += Timer1p2_Tick;
            timer1p2.Start();
            DoubleBuffered = true;
            isPausedp2 = false;
            timer2p2 = new Timer();
            timer2p2.Interval = 15;
            timer2p2.Tick += Timer2p2_Tick;

            isGameOver = false;
            this.reference = reference;

            str = Properties.Resources.TetrisMusic;
            snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
            isMuted = false;

            Image resultImg = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format24bppRgb);
            pictureBox1.Image = resultImg;
            pictureBox2.Image = resultImg;
        }

        private void Timer2p2_Tick(object sender, EventArgs e)
        {
            if (scenep2.anchor())
            {
                timer2p2.Stop();
                timer1p2.Start();
            }
            Timer1p2_Tick(null, null);
        }

        private void Timer1p2_Tick(object sender, EventArgs e)
        {
            scenep2.move();
            scenep2.drawNextShape(pbNextShape2.CreateGraphics());
            if (scenep2.gameOver() || scenep1.gameOver())
            {
                //lblGameOver2.Visible = true;
                writeGameOverLabels();
                pbNextShape2.Visible = false;
                isGameOver = true;
                timer1p2.Stop();
                timer2p2.Stop();
                snd.Stop();
            }
            lblScore2.Text = scenep2.Score.ToString();
            if (scenep2.changedLevel())
            {
                goFaster2();

            }
            Invalidate();
        }

        private void Timer2p1_Tick(object sender, EventArgs e)
        {
            if (scenep1.anchor())
            {
                timer2p1.Stop();
                timer1p1.Start();
            }
            Timer1p1_Tick(null, null);
        }

        private void Timer1p1_Tick(object sender, EventArgs e)
        {
            scenep1.move();
            scenep1.drawNextShape(pbNextShape1.CreateGraphics());
            if (scenep1.gameOver() || scenep2.gameOver())
            {
                //lblGameOver1.Visible = true;
                writeGameOverLabels();
                pbNextShape1.Visible = false;
                isGameOver = true;
                timer1p1.Stop();
                timer2p1.Stop();
                snd.Stop();
            }
            lblScore1.Text = scenep1.Score.ToString();
            if (scenep1.changedLevel())
            {
                goFaster1();

            }
            Invalidate();
        }

        private void writeGameOverLabels()
        {
            lblGameOver1.Visible = true;
            lblGameOver2.Visible = true;
            lblGameOverTie1.Visible = false;
            lblGameOverTie2.Visible = false;
            if(scenep1.Score > scenep2.Score)
            {
                lblGameOver1.Text = "WINNER";
                lblGameOver2.Text = "LOSER";
            } else if(scenep1.Score < scenep2.Score)
            {
                lblGameOver1.Text = "LOSER";
                lblGameOver2.Text = "WINNER";
            } else
            {
                lblGameOver1.Visible = false;
                lblGameOver2.Visible = false;
                lblGameOverTie1.Visible = true;
                lblGameOverTie2.Visible = true;
            }
        }

        private void goFaster1()
        {
            if (timer1p1.Interval != 50)
            {
                timer1p1.Interval -= 50;
            }
        }

        private void goFaster2()
        {
            if (timer1p2.Interval != 50)
            {
                timer1p2.Interval -= 50;
            }
        }

        private void MultiplayerForm_Load(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void MultiplayerForm_Paint(object sender, PaintEventArgs e)
        {
            Bitmap result1 = new Bitmap(pictureBox1.Image);
            Graphics resultGraphics1 = Graphics.FromImage(result1);
            resultGraphics1.Clear(Scene.colors[scenep1.Level]);
            scenep1.draw(resultGraphics1);
            pictureBox1.Image = result1;

            Bitmap result2 = new Bitmap(pictureBox2.Image);
            Graphics resultGraphics2 = Graphics.FromImage(result2);
            resultGraphics2.Clear(Scene.colors[scenep2.Level]);
            scenep2.draw(resultGraphics2);
            pictureBox2.Image = result2;
        }

        private void MultiplayerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver)
            {
                if (e.KeyCode == Keys.Down)
                {
                    Timer1p2_Tick(null, null);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (!isPausedp2)
                        scenep2.moveLeft();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (!isPausedp2)
                        scenep2.moveRight();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (!isPausedp2)
                        scenep2.moveUp();
                }
                else if (e.KeyCode == Keys.NumPad0)
                {
                    if (!timer2p2.Enabled && !isPausedp2)
                        goFastDown2();
                }
                else if (e.KeyCode == Keys.P)
                {
                    pause1();
                    pause2();
                }

                if (e.KeyCode == Keys.S)
                {
                    Timer2p1_Tick(null, null);
                }
                else if (e.KeyCode == Keys.A)
                {
                    if (!isPausedp1)
                        scenep1.moveLeft();
                }
                else if (e.KeyCode == Keys.D)
                {
                    if (!isPausedp1)
                        scenep1.moveRight();
                }
                else if (e.KeyCode == Keys.W)
                {
                    if (!isPausedp1)
                        scenep1.moveUp();
                }
                else if (e.KeyCode == Keys.C)
                {
                    if (!timer2p1.Enabled && !isPausedp1)
                        goFastDown1();
                }

                Invalidate();
            }
        }

        private void pause1()
        {
            if (!isPausedp1 && !isGameOver)
            {
                timer1p1.Stop();
                isPausedp1 = !isPausedp1;
                lblPause1.Visible = true;
                snd.Stop();
            }
            else if (isPausedp1)
            {
                timer1p1.Start();
                isPausedp1 = !isPausedp1;
                lblPause1.Visible = false;
                snd.PlayLooping();
            }
        }

        private void pause2()
        {
            if (!isPausedp2 && !isGameOver)
            {
                timer1p2.Stop();
                isPausedp2 = !isPausedp2;
                lblPause2.Visible = true;
                snd.Stop();
            }
            else if (isPausedp2)
            {
                timer1p2.Start();
                isPausedp2 = !isPausedp2;
                lblPause2.Visible = false;
                snd.PlayLooping();
            }
        }

        private void goFastDown1()
        {
            timer2p1.Start();
            timer1p1.Stop();
        }

        private void goFastDown2()
        {
            timer2p2.Start();
            timer1p2.Stop();
        }

        private void MultiplayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isGameOver)
            {
                pause1();
                pause2();
                if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    pause1();
                    pause2();
                    snd.PlayLooping();
                }
                else
                {
                    reference.Show();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                reference.Show();
            }
        }

        private void pbSound_Click(object sender, EventArgs e)
        {
            if (!isPausedp1 && !isGameOver) {
                if (isMuted) {
                    snd.PlayLooping();
                    pbSound.Image = Properties.Resources.mute;
                } else if (!isMuted) {
                    snd.Stop();
                    pbSound.Image = Properties.Resources.sound;
                }
                isMuted = !isMuted;
            }
        }
    }
}
