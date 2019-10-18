using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct UserRec            // 宣告UserRec結構，內含三個成員
        {
            public string passwd, email;   // 密碼(passwd)、email成員皆為string型別
            public bool sex;             // 性別(sex)成員為bool型別
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserRec rec;               // 建立UserRec結構型別的變數rec
            // 建立Dictionary類別物件
            Dictionary<string, UserRec> userDict = new Dictionary<string, UserRec>();
            rec.passwd = "123456";         // 指派結構變數rec成員資料
            rec.sex = true;
            rec.email = "cc@yljh.edu.tw";
            userDict.Add("張三榮", rec);    // 加入第一筆資料到userDict物件中
            // ------------------------------------------------------------------------------
            rec.passwd = "111111";
            rec.sex = false;
            rec.email = "mm@hinet.net";
            userDict.Add("李玲玲", rec);    // 加入第二筆資料到userDict物件中
            // ------------------------------------------------------------------------------
            rec.passwd = "aaa";
            rec.sex = true;
            rec.email = "aaa";
            userDict.Add("施逢怡", rec);    // 加入第二筆資料到userDict物件中
        }
    }
}
