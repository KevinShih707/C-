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
    public class RandomFunctionTests
    {
        const int THREE = 3;
        const int TWO = 2;
        const int TEN = 10;
        const int ASSERT = 1;
        const int OUTPUT = 1;
        RandomFunction _target;
        PrivateObject _randomTest;
        //初始化
        [TestInitialize()]

        [DeploymentItem("EnglishTest.exe")]
        public void Initialize()
        {
            _target = new RandomFunction();
            _randomTest = new PrivateObject(_target);
        }

        //GetRandom Test
        [TestMethod()]

        public void GetRandomTest()
        {
            const string GET = "GetRandom";
            _randomTest.Invoke(GET, TWO, THREE);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //GetRandom2 Test
        [TestMethod()]

        public void GetRandom2Test()
        {
            const string GET = "GetRandom2";
            _randomTest.Invoke(GET, TWO);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //GetRandom3 Test
        [TestMethod()]

        public void GetRandom3Test()
        {
            const string GET = "GetRandom3";
            _randomTest.Invoke(GET, THREE, TEN, TWO);
            Assert.AreEqual(ASSERT, OUTPUT);
        }

        //ShowType Test
        [TestMethod()]

        public void ShowTypeTest()
        {
            const string SHOW = "ShowType";
            const string FILL = "Q2:Fill in the Blanks";
            const bool INPUT = true;
            const bool INPUT2 = false;
            var output = _randomTest.Invoke(SHOW, INPUT, 1);
            Assert.AreEqual(string.Empty, output);
            var output2 = _randomTest.Invoke(SHOW, INPUT2, 1);
            Assert.AreEqual(FILL, output2);
        }

        //ShowType2 Test
        [TestMethod()]

        public void ShowType2Test()
        {
            const string SHOW = "ShowType2";
            const string FILL = "Q2:Multiple Choice Question";
            const bool INPUT = true;
            const bool INPUT2 = false;
            var output = _randomTest.Invoke(SHOW, INPUT, 1);
            Assert.AreEqual(string.Empty, output);
            var output2 = _randomTest.Invoke(SHOW, INPUT2, 1);
            Assert.AreEqual(FILL, output2);
        }
    }
}