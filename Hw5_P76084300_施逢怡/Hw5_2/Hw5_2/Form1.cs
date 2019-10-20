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
        UserRec rec;               // 建立UserRec結構型別的變數rec
                                   // 建立Dictionary類別物件
        Dictionary<string, UserRec> userDict = new Dictionary<string, UserRec>();
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

        private void button_query_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string password = textBox_password.Text;
            string input_name = name;
            string fm;
            if (!userDict.ContainsKey(name))  // 若userDict物件索引鍵不包含該姓名
                MessageBox.Show("查無此人");
            else                          // 若userDict物件索引鍵包含該姓名
            {
                string pw = password;         // 登入使用者密碼
                if (userDict[name].passwd == pw)   // 若使用者密碼相符，顯示資料
                {
                    string input_fm="";
                    if (userDict[name].sex)
                        input_fm = "男";
                    else
                        input_fm = "女";
                    string people = "";
                    foreach (KeyValuePair<string, UserRec> kv in userDict)
                    {
                        name = kv.Key;
                        if (kv.Value.sex)
                            fm = "男";
                        else
                            fm = "女";
                        pw = kv.Value.passwd;
                        string mail = kv.Value.email;
                        people+= (name+"\t"+fm+"\t"+pw+"\t"+mail+"\n");
                    }
                    MessageBox.Show("顯示"+ input_name + "相關資料\n"+ "性別 : "+ input_fm + "\nEmail："+ 
                                    userDict[input_name].email+"\n"+ "\n列出所有使用者相關資料\n"+ 
                                    "姓名\t性別\t密碼\tmail\n"+ "======\t====\t======\t==============\n"
                                    +people);
                }
                else                                 // 若使用者密碼不符
                    MessageBox.Show("密碼不對");
            }
        }
    }
}
