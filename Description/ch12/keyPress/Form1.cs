using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyPress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdb1.Checked = true;  //預設第一個選項
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked == true)
            {
                lblMsg.Text = "請輸入數字";
                txtInput.Clear();  //清空txtInput文字
                txtInput.Focus();  //txtInput取得焦點
            }
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2.Checked == true)
            {
                lblMsg.Text = "請輸入小寫英文字母";
                txtInput.Clear();  //清空txtInput文字
                txtInput.Focus();  //txtInput取得焦點; 
            }
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3.Checked == true)
            {
                lblMsg.Text = "請輸入英文字母，小寫會轉成大寫";
                txtInput.Clear();  //清空txtInput文字
                txtInput.Focus();  //txtInput取得焦點
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (rdb1.Checked == true)
            {   // 若小於0或大於9，且不是退位鍵
                if ((c < '0' || c > '9') && (byte)e.KeyChar != 8)
                {
                    lblMsg.Text = "注意：請按數字鍵！";
                    e.Handled = true;             // 不接收字元
                }
            }
            else if (rdb2.Checked == true)
            {   // 若小於a或大於z，且不是退位鍵
                if ((c < 'a' || c > 'z') && (byte)e.KeyChar != 8)
                {
                    lblMsg.Text = "請注意：輸入小寫英文字母！";
                    e.Handled = true;             // 不接收字元
                }
            }
            else
            {   // 若小於A或大於Z，且不是退位鍵
                if ((c < 'A' || c > 'Z') && (byte)e.KeyChar != 8)
                {
                    if (c >= 'a' && c <= 'z')  //若是小寫就轉成大寫字母
                    { e.KeyChar = (char)((int)e.KeyChar - 32); }
                    else
                    {
                        lblMsg.Text = "請注意：輸入英文字母！";
                        e.Handled = true;             // 不接收字元
                    }
                }
            }
        }
    }
}
