using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace DataReaderOleDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" +
                Application.StartupPath + "\\friend.mdb";   // 資料庫連接字串

            OleDbConnection db = new OleDbConnection(cn);
            db.Open();   //使用Open方法開啟和資料庫的連接
            OleDbCommand cmd = new OleDbCommand
                ("SELECT * FROM 通訊錄", db);
            OleDbDataReader dr = cmd.ExecuteReader();
            string data = "";   //宣告字串存放資料內容
            for (int i = 0; i < dr.FieldCount; i++)
            {
                data += dr.GetName(i) + "\t";
            }
            data += "\n";   //換行
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    data += dr[i].ToString() + "\t";
                }
            }
            MessageBox.Show(data, "通訊錄");
            db.Close();   //使用Close方法關閉和資料庫的連接
        }
    }
}