using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;//引用System.Data.SqlClient命名空間

namespace DataReaderSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename=|DataDirectory|Database1.mdf;" +
               "Integrated Security=True";
            SqlConnection db = new SqlConnection(cn);//建立連接物件
            db.Open();   //使用Open方法開啟和資料庫的連接
            SqlCommand cmd = new SqlCommand
                   ("SELECT TOP 3 * FROM 書目", db);
            SqlDataReader dr = cmd.ExecuteReader();
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
                data += "\n";
            }
            MessageBox.Show(data, "書目");
            db.Close();   //使用Close方法關閉和資料庫的連接
        }
    }
}
