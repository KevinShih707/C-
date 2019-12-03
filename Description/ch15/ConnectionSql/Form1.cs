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

namespace ConnectionSql
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
            db.Open();
            MessageBox.Show(db.Database, "資料庫");
            db.Close();
        }
    }
}
