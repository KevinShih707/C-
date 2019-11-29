using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace touch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int SM_DIGITIZER = 94;
        [DllImport("User32.dll")]
        public static extern int GetSystemMetrics(int n);

        private void Form1_Load(object sender, EventArgs e)
        {
            int digitizerStatus = GetSystemMetrics(SM_DIGITIZER);
            if ((digitizerStatus & (0x80 + 0x40)) != 0)
                MessageBox.Show("支援多點觸控");
            else
                MessageBox.Show("不支援多點觸控");
            picT1.Image = Image.FromFile("pic1.png");
            picT1.SizeMode = PictureBoxSizeMode.StretchImage;
            picT2.Image = Image.FromFile("pic2.png");
            picT2.SizeMode = PictureBoxSizeMode.StretchImage;
            picT3.Image = Image.FromFile("pic3.png");
            picT3.SizeMode = PictureBoxSizeMode.StretchImage;
            picT2.Click += picT1_Click;
            picT3.Click += picT1_Click;
            picT2.DoubleClick += picT1_DoubleClick;
            picT3.DoubleClick += picT1_DoubleClick;
            picT2.MouseClick += picT1_MouseClick;
            picT3.MouseClick += picT1_MouseClick;
            this.MouseWheel += new MouseEventHandler(picZoom);
        }

        private void picZoom(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            { this.Controls[0].Width += 8; this.Controls[0].Height += 6; }
            else
            { this.Controls[0].Width -= 8; this.Controls[0].Height -= 6; }
        }

        private void picT1_Click(object sender, EventArgs e)
        {
            PictureBox picClick = (PictureBox)sender;
            //this.Controls.SetChildIndex(picClick, 0);
            picClick.BringToFront();
        }

        private void picT1_DoubleClick(object sender, EventArgs e)
        {
            PictureBox picDClick = (PictureBox)sender;
            picDClick.Size = new Size(160, 120);
        }

        private void picT1_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox picMClick = (PictureBox)sender;
            if (e.Button == MouseButtons.Right)
                picMClick.SendToBack();
                //this.Controls.SetChildIndex(picMClick, this.Controls.Count-1);
        }

    }
}
