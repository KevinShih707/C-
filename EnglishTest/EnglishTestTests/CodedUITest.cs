using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;

namespace EnglishTestTests
{
    /// <summary>
    /// Summary description for MainFormUITest
    /// </summary>
    [CodedUITest]
    public class MainFormUITest
    {
        const string FILE_PATH = @"../../../EnglishTest/bin/Debug/EnglishTest.exe";
        private const string CALCULATOR_TITLE = "基本能力測驗英文1000字";
        private const string EXPECTED_VALUE = "444";
        private const string RESULT_CONTROL_NAME = "Monitor";
        private const string TARGET_FORM_NAME = "About Spelling checker";

        /// <summary>
        /// Launches the Calculator
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, CALCULATOR_TITLE);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        // Runs the ExaminationSet
        private void RunScriptSet()
        {
            Robot.ClickMenuItem(new string[] { "Examination", "Number of Questions", "10 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Number of Questions", "20 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Number of Questions", "50 Questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All fill in the blank questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All multiple-choice questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "Pick up questions randomly" });
            Robot.SetNumericUpDown("_numericUpDown1", "10");
            Robot.SetComboBox("_comboBox1", "All multiple-choice questions");
            Robot.SetComboBox("_comboBox1", "All fill in the blank questions");
            Robot.SetComboBox("_comboBox1", "Pick up questions ramdomly");
        }
        
        //Test Examination-> Number of Questions.Question Type
        [TestMethod]
        public void TestExaminationSet()
        {
            RunScriptSet();
        }

        //Run About Dictionary
        private void RunHelp()
        {
            Robot.ClickMenuItem(new string[] { "Help", "About Dictionary" });
        }

        //Test About Dictionary
        [TestMethod]
        public void TestHelp()
        {
            RunHelp();
        }

        //Run about spelling checker
        private void RunHelp2()
        {
            Robot.ClickMenuItem(new string[] { "Help", "About Spelling Checker" });
            Robot.SetForm(TARGET_FORM_NAME);
            Robot.ClickLink("CSIE");
            Robot.ClickLink("NTUT");
        }

        //Test about spelling checker
        [TestMethod]
        public void TestHelp2()
        {
            RunHelp2();
        }

        //Run Start(menu), fill in question
        private void RunStartInMenu()
        {
            Robot.ClickMenuItem(new string[] { "Examination", "Question Type", "All fill in the blank questions" });
            Robot.ClickMenuItem(new string[] { "Examination", "Start" });
            Robot.ClickMenuItem(new string[] { "Examination", "Next" });
            Robot.ClickMenuItem(new string[] { "Examination", "Stop" });
            Robot.AssertWindow("stop");
            Robot.SendKeyEnterToMessageBox("Stop");
        }

        //Test Start(menu), fill in question
        [TestMethod]
        public void TestStartInMenu()
        {
            RunStartInMenu();
        }

        //Run Start(Button), multiple in question
        private void RunStartButton()
        {
            Robot.SetNumericUpDown("_numericUpDown1", "1");
            Robot.SetComboBox( "_comboBox1", "All multiple-choice questions" );
            Robot.ClickButton("Start");
            Robot.ClickButton("Next");
            Robot.AssertWindow("Finish");
            Robot.SendKeyEnterToMessageBox("Finish");
        }

        //Test Start(Button), multiple in question
        [TestMethod]
        public void TestStartButton()
        {
            RunStartButton();
        }

        //Run Start(Button), multiple in question
        private void RunExit()
        {
            Robot.ClickMenuItem(new string[] { "File", "Exit" });
        }

        //Test Exit
        [TestMethod]
        public void TestExit()
        {
            RunExit();
        }
    }
}
