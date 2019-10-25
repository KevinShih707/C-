using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnglishTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Tests
{
    public partial class PresentationModelTests
    {
        //GetMultiple Test
        [TestMethod()]

        public void GetMultipleTest()
        {
            const string GET = "GetMultiple";
            const string COUNT = "_count";
            const string MULTIPLE = "_multipleQuestion";
            const string ONE1 = "one";
            const string TWO1 = "two";
            const string THREE1 = "THREE";
            const string FOUR1 = "FOUR";
            string[] question = new string[] { ONE1, TWO1, THREE1, FOUR1 };
            _modelTest.SetField(COUNT, THREE);
            _modelTest.SetField(MULTIPLE, question);
            var output = _presentationTest.Invoke(GET);
            Assert.AreEqual(ONE1, output);
        }

        //StartMultiple Test
        [TestMethod()]

        public void StartMultipleTest()
        {
            const string START = "StartMultiple";
            _modelTest.SetField(QUESTION1, 0);
            _modelTest.SetField(ARRAY, _question);
            _presentationTest.Invoke(START);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //GetQuestion2 Test
        [TestMethod()]

        public void GetQuestion2Test()
        {
            const string FEW = "few";
            const string QUESTION2 = "GetQuestion2";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, 1);
            var output = _presentationTest.Invoke(QUESTION2);
            Assert.AreEqual(string.Empty, output);
            _modelTest.SetField(NUMBER, TEN);
            _modelTest.SetField(ARRAY, _question);
            _modelTest.SetField(QUESTION1, 0);
            var output2 = _presentationTest.Invoke(QUESTION2);
            Assert.AreEqual(FEW, output2);
        }

        //GetQuestionNumber2 Test
        [TestMethod()]

        public void GetQuestionNumber2Test()
        {
            const string GET = "GetQuestionNumber2";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, 1);
            var output = _presentationTest.Invoke(GET);
            Assert.AreEqual(string.Empty, output);
        }

        //GetNumberOfWord Test
        [TestMethod()]

        public void GetNumberOfWordTest()
        {
        }

        //IsTypeEnabled Test
        [TestMethod()]

        public void IsTypeEnabledTest()
        {
            const string MODE = "_mode";
            const string IS = "IsTypeEnabled";
            _presentationTest.SetField(MODE, 1);
            _presentationTest.Invoke(IS);
            _presentationTest.SetField(MODE, TWO);
            _presentationTest.Invoke(IS);
            _presentationTest.SetField(MODE, THREE);
            _presentationTest.Invoke(IS);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //DecideType Test
        [TestMethod()]

        public void DecideTypeTest()
        {
            const string DECIDE = "DecideType";
            _presentationTest.Invoke(DECIDE);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //DecideMode Test
        [TestMethod()]

        public void DecideModeTest()
        {
            const string DECIDE = "DecideMode";
            const string PICK = "Pick up questions ramdomly";
            var output = _presentationTest.Invoke(DECIDE, PICK);
            Assert.AreEqual(null, output);
        }

        //IsTypeOne Test
        [TestMethod()]

        public void IsTypeOneTest()
        {
            const string START = "IsTypeOne";
            var output = _presentationTest.Invoke(START);
            Assert.AreEqual(true, output);
        }

        //IsTypeTwo Test
        [TestMethod()]

        public void IsTypeTwoTest()
        {
            const string START = "IsTypeTwo";
            var output = _presentationTest.Invoke(START);
            Assert.AreEqual(true, output);
        }

        //IsTypeThree Test
        [TestMethod()]

        public void IsTypeThreeTest()
        {
            const string START = "IsTypeThree";
            var output = _presentationTest.Invoke(START);
            Assert.AreEqual(true, output);
        }

        //timer test
        [TestMethod()]

        public void GetTimerTest()
        {
            const int HUNDRED = 100;
            const int FIFTY = 50;
            const int NINETY = 90;
            const string FUNCTION = "CheckProgressBar";
            const string FUNCTION2 = "CountScore";
            const string SUBTRACT = "_subtract";
            var output = _presentationTest.Invoke(FUNCTION, HUNDRED);
            var output2 = _presentationTest.Invoke(FUNCTION, FIFTY);
            Assert.AreEqual(-NINETY, output);
            Assert.AreEqual(TEN, output2);
            _presentationTest.SetField(SUBTRACT, true);
            var output3 = _presentationTest.Invoke(FUNCTION2, HUNDRED);
            _presentationTest.SetField(SUBTRACT, false);
            var output4 = _presentationTest.Invoke(FUNCTION2, HUNDRED);
        }

        //CheckScore. IsTimerEnabled Test
        [TestMethod()]

        public void GetCheckScoreTest()
        {
            const int ZERO = 0;
            const int TWENTY = 20;
            const int FIVE = 5;
            const string FUNCTION = "CheckScore";
            const string FUNCTION2 = "IsTimerEnabled";
            const string MARK = "_mark";
            const string SCORE = "_score";
            _modelTest.SetField(MARK, true);
            _presentationTest.SetField(SCORE, FIVE);
            var output = _presentationTest.Invoke(FUNCTION);
            _modelTest.SetField(MARK,false);
            var output2 = _presentationTest.Invoke(FUNCTION);
            Assert.AreEqual(-TWENTY, output);
            Assert.AreEqual(ZERO, output2);
            var output3 = _presentationTest.Invoke(FUNCTION2);
            Assert.AreEqual(true, output3);
        }

        //Dialog Test
        [TestMethod()]

        public void ShowDialogTest()
        {
            const int HUNDRED = 100;
            string[] wrong = new string[HUNDRED];
            const string COUNTER = "_counter";
            const string WRONG = "_wrong";
            const string FUNCTION = "AddCorrectAnswer";
            const string ENGLISH = "english";
            const string CHINESE = "chinese";
            _modelTest.SetField(WRONG, wrong);
            _modelTest.SetField(COUNTER, 0);
            var output = _modelTest.Invoke(FUNCTION, ENGLISH, CHINESE);
        }
    }
}
