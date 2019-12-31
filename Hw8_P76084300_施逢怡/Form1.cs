using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DataAdapterSql
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" +
                 "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                 "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True"; //資料庫連接字串
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter
                ("SELECT 書號,書名,作者,定價 FROM 書目 ORDER BY 定價 DESC", db);
            DataSet ds = new DataSet();

            ap.Fill(ds, "書目");
            DataTable mytable = ds.Tables["書目"];
            book_author.Text = mytable.Rows[1]["書名"].ToString();
            dataGridView1.DataSource = ds.Tables["書目"];
            db.Close();
        }


        //新增
        private void button1_Click(object sender, EventArgs e)
        {
            if (book_name.Text != "" && book_author.Text != "" && book_number.Text != "" && book_price.Text != "")
            {/*
                string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                     "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                        "Integrated Security=True"; //資料庫連接字串
                SqlConnection db = new SqlConnection(cn);
                db.Open();

                string a = book_number.Text;
                string b = book_name.Text;
                string c = book_author.Text;
                string d = book_price.Text;
                SqlDataAdapter ap = new SqlDataAdapter
                ("INSERT INTO 書目(書號,書名,作者,定價) VALUES(a,b,c,d)", db);
                DataSet ds = new DataSet();
                ap.Fill(ds, "書目");
                dataGridView1.DataSource = ds.Tables["書目"];*/
                cmd = new SqlCommand("insert into 書目(書號,書名,作者,定價) values(@書號,@書名,@作者,@定價)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@書號", book_number.Text);
                cmd.Parameters.AddWithValue("@書名", book_name.Text);
                cmd.Parameters.AddWithValue("@作者", book_author.Text);
                cmd.Parameters.AddWithValue("@定價", book_price.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //Display Data in DataGridView  
        private void DisplayData()
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                 "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                    "Integrated Security=True"; //資料庫連接字串
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter
                ("SELECT 書號,書名,作者,定價 FROM 書目 ORDER BY 定價 DESC", db);
            DataSet ds = new DataSet();


            foreach (DataRow myRow in ds.Tables["書號"].Rows)
            {
                book_author.Text = myRow["DeptNo"].ToString();
            }
            ap.Fill(ds, "書目");
            dataGridView1.DataSource = ds.Tables["書目"];
            db.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            book_author.Text = "";
            book_number.Text = "";
            book_price.Text = "";
            book_name.Text = "";
        }
        //修改
        private void button2_Click(object sender, EventArgs e)
        {
            if (book_name.Text != "" && book_author.Text != "" && book_number.Text != "" && book_price.Text != "")
            {
                cmd = new SqlCommand("update 書目 set 書號=@書號,書名=@書名,作者=@作者,定價=@定價 where 書號=@書號", con);
                con.Open();
                cmd.Parameters.AddWithValue("@書號", book_number.Text);
                cmd.Parameters.AddWithValue("@書名", book_name.Text);
                cmd.Parameters.AddWithValue("@作者", book_author.Text);
                cmd.Parameters.AddWithValue("@定價", book_price.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        //刪除
        private void button3_Click(object sender, EventArgs e)
        {
            if (book_number.Text != "")
            {
                cmd = new SqlCommand("delete 書目 where 書號=@書號", con);
                con.Open();
                cmd.Parameters.AddWithValue("@書號", book_number.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
