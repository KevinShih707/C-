using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //建立記憶體的DataTable物件tableProduct，用來存放產品資料
            DataTable tableProduct = new DataTable();
            //在tableProudct依序建立編號、品名、單價三個DataColumn資料欄物件
            tableProduct.Columns.Add(new DataColumn("編號"));
            tableProduct.Columns.Add(new DataColumn("品名"));
            tableProduct.Columns.Add(new DataColumn("單價"));

            //在tableProduct新增第一筆資料記錄DataRow物件
            DataRow row1 = tableProduct.NewRow();
            row1["編號"] = "A01";
            row1["品名"] = "iPhone 6+";
            row1["單價"] = "28500";
            tableProduct.Rows.Add(row1);

            //在tableProduct新增第二筆資料記錄DataRow物件
            DataRow row2 = tableProduct.NewRow();
            row2["編號"] = "A02";
            row2["品名"] = "三星 Super S8";
            row2["單價"] = "25500";
            tableProduct.Rows.Add(row2);

            //在tableProduct新增第三筆資料記錄DataRow物件
            DataRow row3 = tableProduct.NewRow();
            row3["編號"] = "A03";
            row3["品名"] = "小米手環 5";
            row3["單價"] = "8500";
            tableProduct.Rows.Add(row3);

            dataGridView1.DataSource = tableProduct;
        }
    }
}
