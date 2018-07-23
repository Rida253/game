using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Car_Racing
{
    public partial class Form1 : Form
    {
        int speed;
        int score = 0;
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Form1()
        {
            speed = 3;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.URL= "mME6QTeiP2Ja.128.mp3";
            player.controls.play();
            this.ControlBox = false;
            this.Text = "Racing Game";
            this.label1.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label2.Text= "Score  0";
            this.label2.ForeColor = Color.White;
            this.MaximizeBox = false;
            this.label1.Text = "Game Over";
            this.label1.BackColor = Color.DarkGray;
            this.label1.ForeColor = Color.Black;
            this.label3.Text = "Restart";
            this.label3.BackColor = Color.DarkGray;
            this.label3.ForeColor = Color.Black;
            this.label3.Cursor = Cursors.Hand;
            this.label4.Text = "Exit";
            this.label4.BackColor = Color.DarkGray;
            this.label4.ForeColor = Color.Black;
            this.label4.Cursor = Cursors.Hand; 
            this.pictureBox1.BackColor = Color.White;
            this.pictureBox2.BackColor = Color.White;
            this.pictureBox3.BackColor = Color.White;
            this.pictureBox4.BackColor = Color.White;
            this.pictureBox5.BackColor = Color.White;
            this.pictureBox6.BackColor = Color.White;
            this.pictureBox7.BackColor = Color.White;
            this.pictureBox8.BackColor = Color.White;
            this.pictureBox9.BackColor = Color.White;
            this.pictureBox11.BackColor = Color.White;
            this.pictureBox12.BackColor = Color.White;
            this.pictureBox13.BackColor = Color.White;
            this.pictureBox10.BackColor = Color.Transparent;
            this.pictureBox10.Image = Properties.Resources.car7;
            this.pictureBox14.Image = Properties.Resources.car4;
            this.pictureBox15.Image = Properties.Resources.car1;
            this.pictureBox16.Image = Properties.Resources.car3;
            this.pictureBox17.Image = Properties.Resources.car6;
            this.pictureBox18.Image = Properties.Resources.car5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 7; i++)
            {
                startGame();
            }

            if (pictureBox10.Bounds.IntersectsWith(pictureBox14.Bounds) | pictureBox10.Bounds.IntersectsWith(pictureBox15.Bounds) | pictureBox10.Bounds.IntersectsWith(pictureBox16.Bounds) | pictureBox10.Bounds.IntersectsWith(pictureBox17.Bounds) | pictureBox10.Bounds.IntersectsWith(pictureBox18.Bounds))
            {
                gameOver();
            }

        }
        public void gameOver()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            this.label1.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pictureBox10.Left += 20;
            }
            else if (e.KeyCode == Keys.Left)
            {
                pictureBox10.Left -= 20;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox10.Top -= 10;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox10.Top += 10;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox10.Left += 2;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox10.Left -= 2;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            pictureBox14.Top += 8;
            if (pictureBox14.Top >= this.Height)
            {
                score += 1;
                this.label2.Text = "Score " + score; 
                pictureBox14.Top -= this.Height;
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            pictureBox15.Top += 10;
            if (pictureBox15.Top >= this.Height)
            {
                score += 1;
                this.label2.Text = "Score " + score;
                pictureBox15.Top -= this.Height;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox16.Top += 7;
            if (pictureBox16.Top >= this.Height)
            {
                score += 1;
                this.label2.Text = "Score " + score;
                pictureBox16.Top -= this.Height;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox17.Top += 10;
            if (pictureBox17.Top >= this.Height)
            {
                score += 1;
                this.label2.Text = "Score " + score;
                pictureBox17.Top -= this.Height;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox18.Top += 10;
            if (pictureBox18.Top >= this.Height)
            {
                score += 1;
                this.label2.Text = "Score " + score;
                pictureBox18.Top -= this.Height;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creator: Rida", "Car Racing Game",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void startGame()
        {
            pictureBox1.Top += 2;
            pictureBox2.Top += 2;
            pictureBox3.Top += 2;
            pictureBox4.Top += 2;
            pictureBox5.Top += 2;
            pictureBox6.Top += 2;
            pictureBox7.Top += 2;
            pictureBox8.Top += 2;
            pictureBox9.Top += 2;
            pictureBox11.Top += 2;
            pictureBox12.Top += 2;
            pictureBox13.Top += 2;
            if (pictureBox1.Top >= this.Height | pictureBox2.Top >= this.Height | pictureBox3.Top >= this.Height | pictureBox4.Top >= this.Height | pictureBox5.Top >= this.Height | pictureBox6.Top >= this.Height | pictureBox7.Top >= this.Height | pictureBox8.Top >= this.Height | pictureBox9.Top >= this.Height | pictureBox11.Top >= this.Height | pictureBox12.Top >= this.Height | pictureBox13.Top >= this.Height)
            {
                speed += 10;
                pictureBox1.Top += -pictureBox1.Height;
                pictureBox2.Top += -pictureBox2.Height;
                pictureBox3.Top += -pictureBox3.Height;
                pictureBox4.Top += -pictureBox4.Height;
                pictureBox5.Top += -pictureBox5.Height;
                pictureBox6.Top += -pictureBox6.Height;
                pictureBox7.Top += -pictureBox7.Height;
                pictureBox8.Top += -pictureBox8.Height;
                pictureBox9.Top += -pictureBox9.Height;
                pictureBox11.Top += -pictureBox11.Height;
                pictureBox12.Top += -pictureBox12.Height;
                pictureBox13.Top += -pictureBox13.Height;
             
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
