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

namespace DataAdapterOleDb
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
            Application.StartupPath + "\\friend.mdb"; // 資料庫連接字串
            OleDbConnection db = new OleDbConnection(cn);
            db.Open();
            OleDbDataAdapter ap = new OleDbDataAdapter
              ("SELECT * FROM 通訊錄", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "通訊錄");
            dataGridView1.DataSource = ds.Tables["通訊錄"];
            db.Close();
        }
    }
}
