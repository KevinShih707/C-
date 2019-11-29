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
    public partial class frmInver : Form
    {
        public frmInver()
        {
            InitializeComponent();
        }

        private void frmCls_Load(object sender, EventArgs e)
        {
            string st = mdlString.stInput;
            txtReceive.Text = st;
            txtRes.Text = mdlString.InverString(st);   //字串反向顯示
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain f = new frmMain();
            f.Show();
        }
    }
}
