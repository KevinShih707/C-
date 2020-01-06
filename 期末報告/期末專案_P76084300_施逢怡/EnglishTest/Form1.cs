using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EnglishTest
{

    public partial class FormOne : Form
    {
        const int TEN = 10;
        const int TWENTY = 20;
        const int FIFTY = 50;
        const string PICK = "Pick up questions ramdomly";
        const string FILL = "All fill in the blank questions";
        const string MULTIPLE = "All multiple-choice questions";
        private const int MILLISECONDS_PER_SECOND = 1000;
        private Timer _timer;
        int _counter = 0;
        int _point;
        PresentationModel _model;
        
        public FormOne(PresentationModel presentationModel)
        {
            this._model = presentationModel;
            InitializeComponent();
            _model.Start((int)_numericUpDown1.Value);
            _startToolStripMenuItem.Click += StartClick;
            _stopToolStripMenuItem.Click += StopClick;
            _nextToolStripMenuItem.Click += GetNext;
        }

        //狀態確認
        void RefreshControls()
        {
            //Enable or not
            _start.Enabled = _model.IsStartEnabled();
            _next.Enabled = _model.IsNextEnabled();
            _answer.Enabled = _model.IsAnswerEnabled();
            _stop.Enabled = _model.IsStopEnabled();
            _timer.Enabled = _model.IsTimerEnabled();
            _startToolStripMenuItem.Enabled = _model.IsStartInMenuEnabled();
            _nextToolStripMenuItem.Enabled = _model.IsNextInMenuEnabled();
            _stopToolStripMenuItem.Enabled = _model.IsStopInMenuEnabled();
            RefreshControlsTest();
        }

        //View 的控制及顯示
        void RefreshControlsTest()
        {
            //題數與題型  &  題目
            _question2.Text = _model.GetQuestion2();
            _question.Text = _model.GetQuestion();
            _type.Text = _model.GetQuestionNumber();
            _type2.Text = _model.GetQuestionNumber2();
            //groupbox的visible
            _groupBox1.Visible = _model.IsTypeOne();
            _groupBox2.Visible = _model.IsTypeTwo();
            _groupBox3.Visible = _model.IsTypeThree();
            //決定選擇題四個選擇
            _model.StartMultiple();
            _radioButton1.Text = _model.GetMultiple();
            _radioButton2.Text = _model.GetMultiple();
            _radioButton3.Text = _model.GetMultiple();
            _radioButton4.Text = _model.GetMultiple();
        }

        //Start 按鈕 顯示第一題題目
        private void StartClick(object sender, EventArgs e)
        {
            const int HUNDRED = 100;
            _model.Start((int)_numericUpDown1.Value);
            _model.DecideMode(_comboBox1.Text);
            _model.IsTypeEnabled();
            this._counter = 0;
            StartTimer();
            this._point = HUNDRED;
            _score.Text = _point.ToString();
            RefreshControls();
        }

        //Next 按鈕
        private void GetNext(object sender, EventArgs e) 
        {   
            _check.Text = _model.Check(_answer.Text,_radioButton1.Checked, _radioButton2.Checked, _radioButton3.Checked, _radioButton4.Checked);
            _model.IsTypeEnabled();
            _answer.Clear();
            _radioButton1.Checked = false;
            _radioButton2.Checked = false;
            _radioButton3.Checked = false;
            _radioButton4.Checked = false;
            _model.IsNext();
            this._point += _model.CheckScore();
            _check.Visible = _model.IsCheckVisible();
            _progressBar.Value = 10;
            RefreshControls();
        }

        //Timer
        private void StartTimer()
        {
            _timer = new Timer();
            _timer.Enabled = true;
            _timer.Interval = MILLISECONDS_PER_SECOND;
            _timer.Tick += TickEventHandler;
            _timer.Start();
        }

        //Timer handler
        private void TickEventHandler(object sender, EventArgs e)
        {
            const int SIXTY = 60;
            const int THOUSAND = 3600;
            const string ZERO = "00";
            const string COLON = ":";
            _counter++;
            _watch.Text = ((_counter / THOUSAND) % SIXTY).ToString(ZERO) + COLON + ((_counter / SIXTY) % SIXTY).ToString(ZERO) + COLON + (_counter % SIXTY).ToString(ZERO);
            _progressBar.Value += _model.CheckProgressBar(_progressBar.Value);
            _score.Text = _model.CountScore(_point);
            this._point = Convert.ToInt32(_score.Text);
        }

        //Menu之下的Stop
        private void StopClick(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            _model.Stop();
            _timer.Enabled = true;
        }

        //Menu之下的10 questions
        private void ChooseTenQuestions(object sender, EventArgs e)
        {
            _numericUpDown1.Value = TEN;
        }

        //Menu之下的20 questions
        private void ChooseTwentyQuestions(object sender, EventArgs e)
        {
            _numericUpDown1.Value = TWENTY;
        }

        //Menu之下的50 questions
        private void ChooseFiftyQuestions(object sender, EventArgs e)
        {
            _numericUpDown1.Value = FIFTY;
        }

        //Menu之下的File->Exit
        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        //Menu之下的Help->About Dictionary
        private void GetNumberOfWord(object sender, EventArgs e)
        {
            _model.GetNumberOfWord();
        }

        //Menu之下的Help->About Spelling Checker
        private void GetRelatedInformation(object sender, EventArgs e)
        {
            HelpDialog dialog = new HelpDialog();
            dialog.ShowDialog();
        }

        //在Menu設定填寫題
        private void PickFillInMenu(object sender, EventArgs e)
        {
            _comboBox1.Text = FILL;
        }

        //在Menu設定選擇題
        private void PickMultipleInMenu(object sender, EventArgs e)
        {
            _comboBox1.Text = MULTIPLE;
        }

        //在Menu設定隨機題目
        private void PickRandomInMenu(object sender, EventArgs e)
        {
            _comboBox1.Text = PICK;
        }

        private void FormOne_Load(object sender, EventArgs e)
        {

        }

        private void _question_Click(object sender, EventArgs e)
        {

        }

        private void _questionType_Click(object sender, EventArgs e)
        {

        }

        private void _watch_Click(object sender, EventArgs e)
        {

        }
    }
}
