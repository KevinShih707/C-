using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtInput.Text = mdlString.stInput;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mdlString.stInput = txtInput.Text;
            if (rdbInver.Checked)
            {
                this.Hide();
                frmInver f1 = new frmInver();
                f1.Show(); 
            }
            if (rdbCls.Checked)
            {
                this.Hide();
                frmCls f2 = new frmCls();
                f2.Show();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
