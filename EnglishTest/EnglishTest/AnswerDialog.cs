using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace EnglishTest
{
    public class AnswerDialog
    {
        DataGridView _data = new DataGridView()
        { 
            Dock = DockStyle.Fill };
        const int FORM_HEIGHT = 330;
        const int FORM_WIDTH = 260;
        DataTable _table = new DataTable();

        //FORM
        Form _aForm = new Form()
        { 
            Width = FORM_WIDTH, Height = FORM_HEIGHT, };

        //ShowDialog
        public void ShowDialog(string[] input)
        {
            const int TWO = 2;
            const string ENGLISH = "English";
            const string CHINESE = "Chinese";
            int counter = 0;
            _table.Columns.Add(ENGLISH, typeof(string));
            _table.Columns.Add(CHINESE, typeof(string));
            for (counter = 0; input[counter] != null; counter = counter + TWO)
            {
                _table.Rows.Add(input[counter], input[counter + 1]);
            }
            _data.DataSource = _table;
            _aForm.Controls.Add(_data);
            _aForm.ShowDialog();
        }
    }
}
