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

namespace Relations
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
            SqlConnection db = new SqlConnection(cn);

            DataSet ds = new DataSet();
            SqlDataAdapter daPublisher = new SqlDataAdapter
                    ("SELECT * FROM 出版者", cn);
            daPublisher.Fill(ds, "出版者");
            SqlDataAdapter daBook = new SqlDataAdapter
                    ("SELECT * FROM 書目", cn);
            daBook.Fill(ds, "書目");

            ds.Relations.Add("FK_出版者_書目", ds.Tables["出版者"].Columns["編號"], ds.Tables["書目"].Columns["書商"]);
            dataGridView1.Dock = DockStyle.Top;     //dataGridView1停駐在上方
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "出版者";
            dataGridView2.Dock = DockStyle.Fill;    //dataGridView2整個填滿畫面
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "出版者.FK_出版者_書目";
        }
    }
}
