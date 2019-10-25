using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishTest
{
    public partial class PresentationModel
    {
        bool _isStartEnabled = false;
        bool _isNextEnabled = false;
        bool _isStopEnabled = false;
        bool _isStartInMenuEnabled = false;
        bool _isNextInMenuEnabled = false;
        bool _isStopInMenuEnabled = false;
        bool _isAnswerEnabled = false;
        bool _type1 = true;//fill
        bool _type2 = true;//multiple
        bool _type3 = true;//選擇題數與題型
        bool _checkVisible = true;
        int _mode = 0;
        int _score;
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        Model _model;
        public PresentationModel(Model model)
        {
            this._model = model;
        }

        //check Start button enable
        public bool IsStartEnabled()
        {
            return _isStartEnabled;
        }

        //check Answer label enable
        public bool IsAnswerEnabled()
        {
            return _isAnswerEnabled;
        }

        //check Next button enable
        public bool IsNextEnabled()
        {
            return _isNextEnabled;
        }

        //check Stop button enable
        public bool IsStopEnabled()
        {
            return _isStopEnabled;
        }

        //check "Start" in menu enable
        public bool IsStartInMenuEnabled()
        {
            return _isStartInMenuEnabled;
        }

        //check "Next" in menu enable
        public bool IsNextInMenuEnabled()
        {
            return _isNextInMenuEnabled;
        }

        //check "Stop" in menu enable
        public bool IsStopInMenuEnabled()
        {
            return _isStopInMenuEnabled;
        }

        //check 的清除
        public bool IsCheckVisible()
        {
            return _checkVisible;
        }

        //得到題目
        public string GetQuestion()
        {
            return _model.ShowHint();
        }

        //判斷答案
        public string Check(string answer, bool radio1, bool radio2, bool radio3, bool radio4)
        {
            bool[] check = new bool[FOUR];
            check[0] = radio1;
            check[1] = radio2;
            check[TWO] = radio3;
            check[THREE] = radio4;
            if (_model.IsNoMoreQuestions())
                return string.Empty;
            if (_type1)
                return _model.Check(answer);
            else
                return _model.Check2(check);
        }

        //Start
        public void Start(int numberQuestions)
        {
            _isNextEnabled = true;
            _isStartEnabled = false;
            _isAnswerEnabled = true;
            _isStartInMenuEnabled = false;
            _isStopInMenuEnabled = true;
            _isNextInMenuEnabled = true;
            _checkVisible = true;
            _isStopEnabled = true;
            _type3 = false;
            this._score = numberQuestions;
            _model.Start(numberQuestions);
            _isTimerEnabled = true;
        }

        //Next
        public void IsNext()
        {
            _model.GetNext();
            if (_model.IsNoMoreQuestions())
            {
                IsNext2();
                ShowAnswerDialog();
                _model._questionCounter = 0;
            }
        }

        //Isnext2
        public void IsNext2()
        {
            _isNextEnabled = false;
            _isStartEnabled = true;
            _isAnswerEnabled = false;
            _type1 = false;
            _type2 = false;
            _type3 = true;
            _checkVisible = false;
            _isStopEnabled = false;
            _isStartInMenuEnabled = true;
            _isStopInMenuEnabled = false;
            _isNextInMenuEnabled = false;
            _isTimerEnabled = false;
        }

        //Stop
        public void Stop()
        {
            _model.Stop();
        }

        //顯示題號
        public string GetQuestionNumber()
        {
            return _model.GetQuestionNumber();
        }

        //------------------------------------------------------------
        public string GetMultiple()
        {
            return _model.ShowMultiple();
        }

        //決定選擇題的四個選項
        public void StartMultiple()
        {
            _model.DecideMultiple();
        }

        //回傳模式2題目
        public string GetQuestion2()
        {
            if (_model.IsNoMoreQuestions())
                return string.Empty;
            return _model.GetHintTwo();
        }

        //顯示題號
        public string GetQuestionNumber2()
        {
            return _model.GetQuestionNumber2();
        }

        //回傳messengerbox字典裡的字數
        public void GetNumberOfWord()
        {
            _model.GetNumberOfWord();
        }
    }
}
