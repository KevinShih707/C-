using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest
{
    public partial class Model
    {
        int _score;
        const int HUNDRED = 100;
        string[] _wrong = new string[HUNDRED];
        int _counter = 0;
        //回傳是否減一分
        public bool IsMark()
        {
            return _mark;
        }

        //加入解答
        public void AddCorrectAnswer(string english, string chinese)
        {
            _wrong[_counter] = english;
            _wrong[++_counter] = chinese;
            _counter ++;
        }

        //ShowAnswerDialog
        public void ShowAnswerDialog()
        {
            AnswerDialog form = new AnswerDialog();
            form.ShowDialog(_wrong);
        }
    }
}
