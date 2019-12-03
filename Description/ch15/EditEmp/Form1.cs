using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data .SqlClient;

namespace EditEmp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
         "AttachDbFilename=|DataDirectory|ch15DB.mdf;" +
         "Integrated Security=True";


        private void Form1_Load(object sender, EventArgs e)
        {
            //建立SqlConnection物件db
            SqlConnection db = new SqlConnection();
            //設定db連接ch15DB資料庫檔案
            db.ConnectionString = cn;
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM 員工", db);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "INSERT INTO 員工(員工編號,姓名,職稱,薪資)VALUES('" +
                    txtId.Text.Replace("'", "''") + "',N'" +
                    txtName.Text.Replace("'", "''") + "',N'" +
                    txtP.Text.Replace("'", "''") + "'," +
                    txtSalary.Text + ")";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "UPDATE 員工 SET 姓名=N'" + txtName.Text.Replace("'", "''") + "'," +
                    "職稱=N'" + txtP.Text.Replace("'", "''") + "'," +
                    "薪資=" + txtSalary.Text + " WHERE 員工編號='" + txtId.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection db = new SqlConnection();
                db.ConnectionString = cn;
                db.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "DELETE FROM 員工 WHERE 員工編號='" + txtId.Text.Replace("'", "''") + "'";
                cmd.ExecuteNonQuery();
                db.Close();
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}