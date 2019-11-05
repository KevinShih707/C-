using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            picBird.Image = imgMotor.Images[n];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrFly.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrFly.Enabled = false;
        }

        private void tmrFly_Tick(object sender, EventArgs e)
        {
            //n = n == 3 ? 0 : n + 1;
            //picBird.Image = imgMotor.Images[n];
            if(picBird.Left <= -5 && picBird.Top != 0)
            {
                n = 3;
                picBird.Image = imgMotor.Images[n];
                picBird.Top -= 10;
            }
            else if (picBird.Top >= 160)
            {
                n = 2;
                picBird.Image = imgMotor.Images[n];
                picBird.Left -= 10;
            }
            else if (picBird.Right >= 290)
            {
                n = 1;
                picBird.Image = imgMotor.Images[n];
                picBird.Top += 10;
            }
            else if (picBird.Left == 0 || picBird.Top ==0)
            {
                n = 0;
                picBird.Image = imgMotor.Images[n];
                picBird.Left += 10;
            }
        }

    }
}
