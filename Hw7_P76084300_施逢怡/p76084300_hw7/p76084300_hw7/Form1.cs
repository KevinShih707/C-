using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p76084300_hw7
{
    public partial class Form1 : Form
    {
        private OpenFileDialog od = new OpenFileDialog();
        private SaveFileDialog sd = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        //開啟txt檔
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            od.ShowDialog();//選擇開啟文字檔案
            if (od.FileName != "")
            {
                //將文字檔案裡面的內容載入到介面內
                richTextBox1.LoadFile(od.FileName, RichTextBoxStreamType.PlainText);
                this.Text = od.FileName + "-記事本";
            }
        }
        //儲存檔案
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (od.FileName != "")
            {
                richTextBox1.SaveFile(od.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("儲存成功");
            }
            else
                MessageBox.Show("請先開啟文字檔案", "資訊提示", MessageBoxButtons.OK);
        }
        
        //Clean textbox
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();

            richTextBox1.Text = "";
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Black;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void 綠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Green;
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;
        }

        //調整字體
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            string fontString = toolStripTextBox1.Text;
            int font = int.Parse(fontString);
            //richTextBox1.SelectionFont = new Font("Verdana", font, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font("Verdana", font);
        }

    }
}
