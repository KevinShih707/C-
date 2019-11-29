using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiText
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        int num = 0;      // 記錄新增文件的次數

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;     //新增文件鈕不能使用
        }
       
        private void btnPassword_Click(object sender, EventArgs e)
        {
            frmPass fP = new frmPass();  // 宣告fP為frmPass表單的物件實體
            fP.ShowDialog();             // 用強制回應對話方塊方式來顯示frmPW表單
            btnAdd.Enabled = true;          // 設新增文件鈕可以使用
            btnPassword.Enabled = false;    // 設登入鈕不可以使用
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num++;  //新增文件的次數加1
            frmText fT = new frmText();    // 宣告fT為frmText表單的物件實體
            fT.Text = "文件 " + num.ToString();    //設定表單的標題文字內容
            fT.Show();               // 顯示fT表單
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
