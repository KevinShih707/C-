using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace EnglishTest
{
    public partial class Model 
    {
        const string BLANK = " ";
        const string CORRECT = "Correct!!";
        const string SHOULD = "It should be ";
        const string BLANK2 = "  ";
        const string PICK = "Pick up questions ramdomly";
        const string FILL = "All fill in the blank questions";
        List<Document> _file;
        int[] _array;
        int[] _array2;//裝index 123 321...
        int[] _array3;//裝三個錯誤答案的index
        string[] _multipleQuestion;
        public int _questionCounter;
        int _numberQuestions;
        int _correct;
        int _count = -1;
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        //判斷對錯
        bool _mark;
        RandomFunction _randomFunction = new RandomFunction();
        //start
        public void Start(int numberQuestions)
        {
            Read();
            _array = _randomFunction.GetRandom(numberQuestions, _file.Count);
            this._numberQuestions = numberQuestions;
            _questionCounter = 0;
            _count = -1;
            this._correct = 0;
            this._score = numberQuestions;
            string[] wrong = new string[HUNDRED];
            _counter = 0;
        }

        //Next ,if finish 10 question ,print the result 
        public void GetNext()
        {
            const string FINISH = "Finish";
            const string PASS = "You pass ";
            const string OF = " of ";
            const string QUESTION = " questions!!";
            _questionCounter++;
            if (IsNoMoreQuestions())
            {
                MessageBox.Show(PASS + _correct + OF + _numberQuestions + QUESTION, FINISH);
            }      
        }

        //Stop
        public void Stop()
        {
            const string STOP = "stop";
            const string PASS = "You pass ";
            const string OF = " of ";
            const string QUESTION = " questions!!";
            MessageBox.Show(PASS + _correct + OF + _questionCounter + QUESTION, STOP);
        }

        //讀取檔案
        public void Read()
        {
            const string BLANK = " ";
            const string ARROW = ">>>";
            string address = @"..\..\B1000.txt";
            List<Document> file = new List<Document>();
            List<string> lines = File.ReadAllLines(address).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(new string[] { ARROW, BLANK }, StringSplitOptions.RemoveEmptyEntries);
                Document newdocument = new Document();
                newdocument.answer = entries[0];
                newdocument.question = entries[1];
                file.Add(newdocument);// 寫入file
            }
            //Console.ReadLine();
            this._file = file;
        }
        
        //確認答案
        public string Check(string answer)
        {
            if (answer.Equals(_file[_array[_questionCounter]].answer))
            {
                this._mark = false;
                _correct += 1;
                return CORRECT;
            }
            else
            {
                AddCorrectAnswer(_file[_array[_questionCounter]].answer, _file[_array[_questionCounter]].question);
                this._mark = true;
                string answer1 = (SHOULD + _file[_array[_questionCounter]].answer);
                return answer1;
            }
        }
        
        //判斷考試是否結束
        public bool IsNoMoreQuestions()
        {
            bool noMoreQuestion = _questionCounter + 1 > _numberQuestions;
            return noMoreQuestion;
        }

        //回傳提示(a___p (5))
        public string ShowHint()
        {
            const int WORD = 2;
            const string LINE = "____";
            const string LEFT = " (";
            const string RIGHT = ")";
            if ((_file[_array[_questionCounter]].answer.Length) <= WORD)
                return (_file[_array[_questionCounter]].question + BLANK + LEFT + _file[_array[_questionCounter]].answer.Length + RIGHT);
            else
                return (_file[_array[_questionCounter]].question + BLANK + _file[_array[_questionCounter]].answer.Substring(0, 1) + LINE + _file[_array[_questionCounter]].answer.Substring(_file[_array[_questionCounter]].answer.Length - 1, 1) + LEFT + _file[_array[_questionCounter]].answer.Length + RIGHT);
        }

        //----------------------------------------------------------
        //回傳模式2的四個選項
        public string ShowMultiple()
        {
            _count++;
            if (_count >= FOUR)
                _count = 0;
            return _multipleQuestion[_count];
        }

        //決定選擇題的四個選項
        public void DecideMultiple()
        {
            _array2 = _randomFunction.GetRandom2(FOUR);
            _array3 = _randomFunction.GetRandom3(THREE, _file.Count, _file.IndexOf(_file[_array[_questionCounter]]));
            string[] question = new string[FOUR];
            question[_array2[0]] = _file[_array[_questionCounter]].answer;
            question[_array2[1]] = _file[_array3[0]].answer;
            question[_array2[TWO]] = _file[_array3[1]].answer;
            question[_array2[THREE]] = _file[_array3[TWO]].answer;
            this._multipleQuestion = question;
        }

        //回傳模式2題目
        public string GetHintTwo()
        {
            return (_file[_array[_questionCounter]].question);
        }

        //Check模式2答案
        public string Check2(bool [] answer)
        {
            if (answer[_array2[0]])
            {
                this._mark = false;
                _correct += 1;
                return CORRECT;
            }
            else
            {
                AddCorrectAnswer(_file[_array[_questionCounter]].answer, _file[_array[_questionCounter]].question);
                this._mark = true;
                string answer1 = (SHOULD + _file[_array[_questionCounter]].answer);
                return answer1;
            }
        }

        //決定模式為何(fill, random, multiple)
        public int DecideMode(string mode)
        {
            if (mode == PICK)
                return 1;
            else if (mode == FILL)
                return TWO;
            else
                return THREE;
        }

        //回傳messengerbox字典裡的字數
        public void GetNumberOfWord()
        {
            const string TOTAL = "Total ";
            const string WORD = " words in the dictionary.";
            MessageBox.Show(TOTAL + _file.Count + WORD);
        }

        //顯示填充題題號
        public string GetQuestionNumber()
        {
            return _randomFunction.ShowType(IsNoMoreQuestions(), _questionCounter);
        }

        //顯示選擇題題號
        public string GetQuestionNumber2()
        {
            return _randomFunction.ShowType2(IsNoMoreQuestions(), _questionCounter);
        }

    }
}
