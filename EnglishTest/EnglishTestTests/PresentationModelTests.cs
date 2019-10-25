using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnglishTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest.Tests
{
    [TestClass()]
    public partial class PresentationModelTests
    {
        Model _target;
        PresentationModel _presentation;
        PrivateObject _presentationTest;
        PrivateObject _modelTest;
        const string ARRAY = "_array";
        const string QUESTION1 = "_questionCounter";
        const string NUMBER = "_numberQuestions";
        const string CORRECT = "Correct!!";
        const string TYPE1 = "_type1";
        const int TEN = 10;
        const int THREE = 3;
        const int TWO = 2;
        const string A = "a";
        int[] _question = new[] { 1, TWO, TEN };
        const int ASSERT = 1;
        const int OUTPUT = 1;
        //Check 參數
        bool _input7 = true;
        bool _input8 = false;
        bool _input9 = false;
        bool _input10 = false;
        //初始化
        [TestInitialize()]

        [DeploymentItem("EnglishTest.exe")]
        public void Initialize()
        {
            _target = new Model();
            _target.Read();
            _modelTest = new PrivateObject(_target);
            _presentation = new PresentationModel(_target);
            _presentationTest = new PrivateObject(_presentation);
        }

        //PresentationModel Test
        [TestMethod()]

        public void DoPresentationModelTest()
        {
        }

        //IsStartEnabled Test
        [TestMethod()]

        public void IsStartEnabledTest()
        {
            const string START = "IsStartEnabled";
            var output = _presentationTest.Invoke(START);
            Assert.AreEqual(false, output);
        }

        //IsAnswerEnabled Test
        [TestMethod()]

        public void IsAnswerEnabledTest()
        {
            const string METHOD = "IsAnswerEnabled";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(false, output);
        }

        //IsNextEnabled Test
        [TestMethod()]

        public void IsNextEnabledTest()
        {
            const string METHOD = "IsNextEnabled";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(false, output);
        }
        //IsStopEnabled Test
        [TestMethod()]

        public void IsStopEnabledTest()
        {
            const string METHOD = "IsStopEnabled";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(false, output);
        }

        //IsStartInMenuEnabled Test
        [TestMethod()]

        public void IsStartInMenuEnabledTest()
        {
            const string METHOD = "IsStartInMenuEnabled";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(false, output);
        }

        //IsNextInMenuEnabled Test
        [TestMethod()]

        public void IsNextInMenuEnabledTest()
        {
            const string METHOD = "IsNextInMenuEnabled";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(false, output);
        }

        //IsStopInMenuEnabled Test
        [TestMethod()]

        public void IsStopInMenuEnabledTest()
        {
            const string METHOD = "IsStopInMenuEnabled";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(false, output);
        }

        //IsCheckVisible Test
        [TestMethod()]

        public void IsCheckVisibleTest()
        {
            const string METHOD = "IsCheckVisible";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(true, output);
        }

        //GetQuestion Test
        [TestMethod()]

        public void GetQuestionTest()
        {
            const string FEW = "few ";
            const string LEFT = " (";
            const string RIGHT = ")";
            const string ONE1 = "1";
            _modelTest.SetField(QUESTION1, 0);
            _modelTest.SetField(ARRAY, _question);
            const string METHOD = "GetQuestion";
            var output = _presentationTest.Invoke(METHOD);
            Assert.AreEqual(FEW + LEFT + ONE1 + RIGHT, output);
        }

        //Check Test
        [TestMethod()]

        public void CheckTest()
        {
            const string CHECK = "Check";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, 1);
            var output1 = _presentationTest.Invoke(CHECK, A, _input7, _input8, _input9, _input10);
            Assert.AreEqual(string.Empty, output1);
            _modelTest.SetField(NUMBER, TEN);
            _modelTest.SetField(ARRAY, _question);
            var output2 = _presentationTest.Invoke(CHECK, A, _input7, _input8, _input9, _input10);
            Assert.AreEqual(CORRECT, output2);
            bool[] input5 = new bool[] { true, false };
            int[] question1 = new int[] { 0, 1, TEN };
            const string ARRAY2 = "_array2";
            _modelTest.SetField(ARRAY, question1);
            _modelTest.SetField(ARRAY2, question1);
            _presentationTest.SetField(TYPE1, false);
            var output3 = _presentationTest.Invoke(CHECK, A, _input7, _input8, _input9, _input10);
            Assert.AreEqual(CORRECT, output3);
        }

        //Start Test
        [TestMethod()]

        public void StartTest()
        {
            const string START = "Start";
            _presentationTest.Invoke(START, TEN);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //IsNext Test
        [TestMethod()]

        public void IsNextTest()
        { 
            const string NEXT2 = "IsNext2";
            const string NEXT = "IsNext";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, TEN);
            _presentationTest.Invoke(NEXT);
            _presentationTest.Invoke(NEXT2);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //Stop Test
        [TestMethod()]

        public void StopTest()
        {
        }

        //GetQuestionNumber Test
        [TestMethod()]

        public void GetQuestionNumberTest()
        {
            const string GET = "GetQuestionNumber";
            _modelTest.SetField(QUESTION1, 1);
            _modelTest.SetField(NUMBER, 1);
            var output = _presentationTest.Invoke(GET);
            Assert.AreEqual(string.Empty, output);
        }
    }
}