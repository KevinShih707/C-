using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace EnglishTest
{
    public class HelpDialog
    {
        const int TEN = 10;
        const int FIFTY = 50;
        const string FORM_TITLE = "About Spelling checker";
        const int FORM_HEIGHT = 170;
        const int FORM_WIDTH = 250;
        const int FORM_WORD_SIZE = 5;

        const string DEPARTMENT_TEXT = "CSIE";
        const int DEPARTMENT_POINT_X = 80;
        const int DEPARTMENT_POINT_Y = 35;
        const int DEPARTMENT_WIDTH = 40;

        const string SCHOOL = "NCKU";
        const int SCHOOL_POINT_X = 120;
        const int SCHOOL_POINT_Y = 35;

        const string OK = "OK";
        const int OK_POINT_X = 150;
        const int OK_POINT_Y = 100;

        const string SPELL = "Spelling Checker 1000 word";
        const int SPELL_WIDTH = 200;
        const int SPELL_POINT_X = 80;
        const int SPELL_POINT_Y = 10;

        const string ALL = "All right\nSpirit Du";
        const int ALL_POINT_X = 80;
        const int ALL_POINT_Y = 60;

        const int BOOK_POINT_X = 15;
        const int BOOK_POINT_Y = 10;
        const int BOOK_WIDTH = 50;
        const int BOOK_HEIGHT = 50;
        //FORM
        Form _aForm = new Form()
        { 
            Width = FORM_WIDTH, Height = FORM_HEIGHT, Text = @FORM_TITLE, MaximizeBox = false, MinimizeBox = false };

        //Picture
        PictureBox _book = new PictureBox()
        { 
            Location = new Point(BOOK_POINT_X, BOOK_POINT_Y), Width = BOOK_WIDTH, Height = BOOK_HEIGHT, Image = Image.FromFile(@"..\..\book_marks.png"), SizeMode = PictureBoxSizeMode.AutoSize };

        //CSIE
        LinkLabel _linkLabel1 = new LinkLabel()
        { 
            Text = DEPARTMENT_TEXT, Location = new Point(DEPARTMENT_POINT_X, DEPARTMENT_POINT_Y), Width = DEPARTMENT_WIDTH }; 

        //NTUT
        LinkLabel _linkLabel2 = new LinkLabel()
        { 
            Text = SCHOOL, Location = new Point(SCHOOL_POINT_X, SCHOOL_POINT_Y) }; 

        //OK
        Button _ok = new Button()
        { 
            Location = new Point(OK_POINT_X, OK_POINT_Y), Text = OK };

        //Spelling Checker 1000 Words
        Label _spell = new Label()
        { 
            Text = SPELL, Width = SPELL_WIDTH, Location = new Point(SPELL_POINT_X, SPELL_POINT_Y) };

        //ALLRIGHT
        Label _all = new Label()
        { 
            Text = ALL, Location = new Point(ALL_POINT_X, ALL_POINT_Y) };

        //處理Help->About Spelling Checker  
        public void ShowDialog()
        {
            _aForm.Controls.Add(_book);
            _aForm.Controls.Add(_spell);
            _aForm.Controls.Add(_linkLabel1);
            _aForm.Controls.Add(_linkLabel2);
            _aForm.Controls.Add(_all);
            _aForm.Controls.Add(_ok);
            _linkLabel1.Click += ConnectDepartment;
            _linkLabel2.Click += ConnectSchool;
            _ok.Click += Quit;
            _aForm.ShowDialog();
        }

        //連接資工系網頁
        void ConnectDepartment(Object sender, EventArgs args)
        {
            const string DEPARTMENT = "http://www.csie.ncku.edu.tw/ncku_csie/";
            Process.Start(DEPARTMENT);
        }

        //連接成大網頁
        void ConnectSchool(Object sender, EventArgs args)
        {
            const string SCHOOL = "https://web.ncku.edu.tw/";
            Process.Start(SCHOOL);
        }

        //關閉分頁
        void Quit(Object sender, EventArgs args)
        {
            _aForm.Close();
        }
    }
}
