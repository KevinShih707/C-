using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnglishTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishTest.Test
{
    [TestClass()]
    public class ModelTests
    {
        const int TWO = 2;
        const int THREE = 3;
        const int FOUR = 4;
        const int TEN = 10;
        const int NINE = 9;
        const string BLANK = " ";
        const string A = "a";
        const string NO = "n";
        const string APPLE = "apple";
        const string START = "Start";
        const string CORRECT = "Correct!!";
        const string QUESTION1 = "_questionCounter";
        const string NUMBER = "_numberQuestions";
        const string ARRAY = "_array";
        const string AFTERNOON = "[名]下午;午後 ";
        int[] _question = new[] { 1, TWO, TEN };
        Model _target;
        PrivateObject _modelTest;
        //初始化
        [TestInitialize()]

        [DeploymentItem("EnglishTest.exe")]
        public void Initialize()
        {
            _target = new Model();
            _target.Read();
            _modelTest = new PrivateObject(_target);
        }

        //Start Test
        [TestMethod()]

        public void StartTest()
        {
            _modelTest.Invoke(START, TEN);
            Assert.AreEqual(1, 1);
        }

        //GetNext Test
        [TestMethod()]

        public void GetNextTest()
        {
            const string GET = "GetNext";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, FOUR);
            _modelTest.Invoke(GET);
            Assert.AreEqual(1, 1);
        }

        //Stop Test
        [TestMethod()]

        public void StopTest()
        {
        }

        //Read Test
        [TestMethod()]

        public void ReadTest()
        {
            const string READ = "Read";
            _modelTest.Invoke(READ);
            Assert.AreEqual(1, 1);
        }

        //Check Test
        [TestMethod()]

        public void CheckTest()
        {
            const string CHECK = "Check";
            const string WRONG = "It should be a";
            _modelTest.SetField(QUESTION1, 0);
            _modelTest.SetField(ARRAY, _question);
            var output = _modelTest.Invoke(CHECK, A);
            var output2 = _modelTest.Invoke(CHECK, APPLE);
            Assert.AreEqual(CORRECT, output);
            Assert.AreEqual(WRONG, output2);
        }

        //IsNoMoreQuestion Test
        [TestMethod()]

        public void IsNoMoreQuestionsTest()
        {
            const string MORE = "IsNoMoreQuestions";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, 1);
            var output = _modelTest.Invoke(MORE);
            bool output1 = true;
            Assert.AreEqual(output1, output);
        }

        //ShowHint Test
        [TestMethod() ]

        public void ShowHintTest()
        {
            const string SHOW = "ShowHint";
            const string FEW = "few";
            const string LINE = "____";
            const string LEFT = " (";
            const string RIGHT = ")";
            const string ONE1 = "1";
            _modelTest.SetField(QUESTION1, 0);
            _modelTest.SetField(ARRAY, _question);
            var output1 = _modelTest.Invoke(SHOW);
            _modelTest.SetField(QUESTION1, TWO);
            var output2 = _modelTest.Invoke(SHOW);
            Assert.AreEqual(FEW + BLANK + LEFT + ONE1 + RIGHT, output1);
            Assert.AreEqual(AFTERNOON + A + LINE + NO + LEFT + NINE + RIGHT, output2);
        }

        //ShowMultiple Test
        [TestMethod()]

        public void ShowMultipleTest()
        {
            Model target = new Model();
            const string COUNT = "_count";
            const string MULTIPLE = "_multipleQuestion";
            const string SHOW = "ShowMultiple";
            const string ONE1 = "one";
            const string TWO1 = "two";
            const string THREE1 = "THREE";
            const string FOUR1 = "FOUR";
            string[] question = new string[] { ONE1, TWO1, THREE1, FOUR1 };
            var showMultipleTest = new PrivateObject(target);
            showMultipleTest.SetField(COUNT, THREE);
            showMultipleTest.SetField(MULTIPLE, question);
            var output = showMultipleTest.Invoke(SHOW);
            Assert.AreEqual(ONE1, output);
        }

        //DecideMultile Test
        [TestMethod()]

        public void DecideMultipleTest()
        {
            const string DECIDE = "DecideMultiple";
            _modelTest.SetField(QUESTION1, 0);
            _modelTest.SetField(ARRAY, _question);
            _modelTest.Invoke(DECIDE);
            Assert.AreEqual(1, 1);
        }

        //GetHintTwo Test
        [TestMethod()]

        public void GetHintTwoTest()
        {
            const string FEW = "few";
            const string GET = "GetHintTwo";
            _modelTest.SetField(QUESTION1, 0);
            _modelTest.SetField(ARRAY, _question);
            var output = _modelTest.Invoke(GET);
            Assert.AreEqual(FEW, output);
        }

        //Check2 Test
        [TestMethod()]

        public void Check2Test()
        {
            bool[] input = new bool[] { true, false };
            bool[] input2 = new bool[] { false, true };
            int[] question1 = new int[] { 0, 1, TEN };
            const string ARRAY2 = "_array2";
            const string CHECK2 = "Check2";
            const string WRONG = "It should be a";
            _modelTest.SetField(QUESTION1, 0);
            _modelTest.SetField(ARRAY, question1);
            _modelTest.SetField(ARRAY2, question1);
            var output = _modelTest.Invoke(CHECK2, input);
            var output2 = _modelTest.Invoke(CHECK2, input2);
            Assert.AreEqual(CORRECT, output);
            Assert.AreEqual(WRONG, output2);
        }

        //DecideMode Test
        [TestMethod()]

        public void DecideModeTest()
        {
            const string PICK = "Pick up questions ramdomly";
            const string FILL = "All fill in the blank questions";
            const string ELSE = "else";
            Model decideModeTest = new Model();
            int output = decideModeTest.DecideMode(PICK);
            int output2 = decideModeTest.DecideMode(FILL);
            int output3 = decideModeTest.DecideMode(ELSE);
            Assert.AreEqual(THREE, output3);
            Assert.AreEqual(TWO, output2);
            Assert.AreEqual(1, output);
        }

        //GetNumberOfWord Test
        [TestMethod()]

        public void GetNumberOfWordTest()
        {
        }

        //GetQuestionNumber Test
        [TestMethod()]

        public void GetQuestionNumberTest()
        {
            const string GET = "GetQuestionNumber";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, 1);
            var output = _modelTest.Invoke(GET);
            Assert.AreEqual(string.Empty, output);
        }

        //GetQuestionNumber2 Test
        [TestMethod()]

        public void GetQuestionNumber2Test()
        {
            const string GET = "GetQuestionNumber2";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, 1);
            var output = _modelTest.Invoke(GET);
            Assert.AreEqual(string.Empty, output);
        }
    }
}