using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = "Car Racing Game";
            this.BackgroundImage = Properties.Resources.game_cover1;
            this.button1.Text = "Start";
            this.button1.BackColor = Color.DarkGray;
            this.button1.ForeColor = Color.Red;
            this.button1.Cursor = Cursors.Hand;
            this.AcceptButton=this.button1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
