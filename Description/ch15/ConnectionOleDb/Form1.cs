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

namespace ConnectionOleDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string cn =
                "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\friend.mdb";
            OleDbConnection db = new OleDbConnection(cn);
            db.Open();
            MessageBox.Show(db.DataSource, "資料來源");
            db.Close();
        }
    }
}
