using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest
{
    public partial class PresentationModel
    {
        bool _subtract;
        bool _isTimerEnabled = true;
        //回傳考試模式
        public void IsTypeEnabled()
        {
            if (_mode == 1)
            {
                this._type1 = DecideType();
                this._type2 = (!_type1);
            }
            else if (_mode == TWO)
            {
                this._type1 = true;
                this._type2 = false;
            }
            else if (_mode == THREE)
            {
                this._type1 = false;
                this._type2 = true;
            }
        }

        //在random模式下決定為哪種TYPE
        public bool DecideType()
        {
            Random random = new Random();
            return (random.Next(0, TWO) == 0);
        }

        //決定是何種Mode
        public void DecideMode(string mode)
        {
            _mode = _model.DecideMode(mode);
        }

        //回傳模式1
        public bool IsTypeOne()
        {
            return _type1;
        }

        //回傳模式2
        public bool IsTypeTwo()
        {
            return _type2;
        }

        //回傳模式3
        public bool IsTypeThree()
        {
            return _type3;
        }

        /////Progressbox
        public int CheckProgressBar(int value)
        {
            const int HUNDRED = 100;
            const int NINETY = 90;
            const int TEN = 10;
            if (value == HUNDRED)
            {
                this._subtract = true;
                return -NINETY;
            }
            else
            {
                this._subtract = false;
                return TEN;
            }
        }

        //當超過十秒，扣一分
        public string CountScore(int value)
        {
            if (_subtract)
                return (--value).ToString();
            else
                return value.ToString();
        }

        //判斷分數
        public int CheckScore()
        {
            const int HUNDRED = 100;
            if (_model.IsMark())
            {
                return -(HUNDRED / _score);
            }
            else
            {
                return 0;
            }
        }

        //回傳timer enabled
        public bool IsTimerEnabled()
        {
            return _isTimerEnabled;
        }

        //show correct answer dialog
        public void ShowAnswerDialog()
        {
            _model.ShowAnswerDialog();
        }
    }
}
