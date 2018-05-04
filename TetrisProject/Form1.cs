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
    public partial class Form1 : Form
    {
        Timer timer1;
        Timer timer2;
        Scene scene1;
        bool isGameOver;
        bool isPaused;
        bool isMuted;
        Form reference;

        System.IO.Stream str;
        System.Media.SoundPlayer snd;

        public Form1(Form reference,int level=1)
        {
            InitializeComponent();
            this.reference = reference;
            scene1 = new Scene(level);
            timer1 = new Timer();
            timer1.Interval = 500 - 50 * level;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            isGameOver = false;
            DoubleBuffered = true;
            isPaused = false;
            timer2 = new Timer();
            timer2.Interval = 15;
            timer2.Tick += Timer2_Tick;

            Image resultImg = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format24bppRgb);
            pictureBox1.Image = resultImg;

            str = Properties.Resources.TetrisMusic;
            snd = new System.Media.SoundPlayer(str);
            snd.PlayLooping();
            isMuted = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            scene1.move();
            scene1.drawNextShape(pbNextShape.CreateGraphics());
            if (scene1.gameOver())
            {
                label1.Visible = true;
                btnPlayAgain.Visible = true;
                pbNextShape.Visible = false;
                isGameOver = true;
                timer1.Stop();
                timer2.Stop();
                btnPlayAgain.Focus();
                Scores.Add(scene1.Score);
                Scores.saveScores();
                snd.Stop();
            }
            lblScore.Text = scene1.Score.ToString();
            if (scene1.changedLevel())
            {
                goFaster();

            }
            
            Invalidate();
        }

        private void goFaster()
        {
            if (timer1.Interval != 50)
            {
                timer1.Interval -= 50;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHighScore.Text = Scores.HighScore.ToString();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap result = new Bitmap(pictureBox1.Image);
            Graphics resultGraphics = Graphics.FromImage(result);
            resultGraphics.Clear(Scene.colors[scene1.Level]);
            //pictureBox1.CreateGraphics().Clear(Scene.colors[scene1.Level]);
            scene1.draw(resultGraphics);
            pictureBox1.Image = result;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver)
            {
                if (e.KeyCode == Keys.Down)
                {
                    Timer1_Tick(null, null);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if(!isPaused)
                        scene1.moveLeft();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (!isPaused)
                        scene1.moveRight();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    if (!isPaused)
                        scene1.moveUp();
                }else if(e.KeyCode == Keys.Space)
                {
                    if(!timer2.Enabled && !isPaused)
                        goFastDown();
                } else if(e.KeyCode == Keys.P)
                {
                    pause();
                }
                Invalidate();
            }
        }

        private void pause()
        {
            if (!isPaused && !isGameOver)
            {
                timer1.Stop();
                isPaused = !isPaused;
                lblPause.Visible = true;
                snd.Stop();
            }
            else if (isPaused)
            {
                timer1.Start();
                isPaused = !isPaused;
                lblPause.Visible = false;
                snd.PlayLooping();
            }
        }

        private void goFastDown()
        {
            timer2.Start();
            timer1.Stop();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (scene1.anchor())
            {
                timer2.Stop();
                timer1.Start();
            }
            Timer1_Tick(null, null);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            lblScore.Text = "0";
            lblHighScore.Text = Scores.HighScore.ToString();
            scene1 = new Scene(scene1.StartedLevel);
            timer1.Start();
            timer1.Interval = 500 - scene1.StartedLevel * 50;
            isGameOver = false;
            label1.Visible = false;
            btnPlayAgain.Visible = false;
            pbNextShape.Visible = true;
            pictureBox1.CreateGraphics().Clear(Scene.colors[scene1.Level]);
            Invalidate();
            Focus();
            snd.PlayLooping();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            pause();
            snd.Stop();
            if (!isGameOver)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    pause();
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
            if (!isPaused && !isGameOver) {
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
