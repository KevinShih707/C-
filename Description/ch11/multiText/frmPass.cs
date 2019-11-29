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
    public partial class frmPass : Form
    {
        public frmPass()
        {
            InitializeComponent();
        }

        int num = 0;      // 記錄密碼輸入次數

        private void btnOK_Click(object sender, EventArgs e)
        {
            num++;           // 密碼輸入次數+1
            //若ID = "happy" 且 Password = "168"
            if (txtID.Text == "happy" && txtPassword.Text == "168")
                this.Close();   // 關閉目前(frmPass)表單
            else
            {
                if (num < 3)   // 若輸入次數<3
                {
                    DialogResult result = MessageBox.Show("是否再輸入？",
                                         "密碼錯誤", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        txtID.Clear(); txtPassword.Clear();    // 清空文字方塊
                        txtID.Focus();     // 使txtID成為作用物件
                    }
                    else
                        Application.Exit();  // 使用者不想輸入結束程式
                }
                else
                {
                    DialogResult result = MessageBox.Show("連續三次密碼錯誤？",
                                       "結束程式", MessageBoxButtons.OK);
                    Application.Exit();       // 輸入次數=3結束程式
                }
            }
        }
    }
}
