using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTestTests
{
    public partial class Robot
    {
        //// DelteteDataGridViewByIndex
        //public static void DoDataGridViewByIndex(string[] data)
        //{
        //    const int TWO = 2;
        //    const int THREE = 3;
        //    WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), data[0], _root);
        //    WinRow row = new WinRow(table);
        //    if (data[THREE] == string.Empty)
        //    {
        //        Mouse.Click(table, System.Windows.Forms.MouseButtons.Right);
        //    }
        //    else
        //    {
        //        row.SearchProperties.Add(WinRow.PropertyNames.RowIndex, data[THREE]);
        //        row.Find();
        //        UITestControlCollection collection = row.GetChildren();
        //        Mouse.Click(collection[0]);
        //        Mouse.Click(collection[0], System.Windows.Forms.MouseButtons.Right);
        //    }
        //    WinWindow window = new WinWindow();
        //    WinMenu menu = new WinMenu(window);
        //    menu.SearchProperties[WinMenu.PropertyNames.Name] = data[1];
        //    WinMenuItem item = new WinMenuItem(menu);
        //    item.SearchProperties[WinMenuItem.PropertyNames.Name] = data[TWO];
        //    Mouse.Click(item);
        //}

        //ClickListViewByValue
        public static void ClickListViewByValue(string name, string data)
        {
            const string TASK = "Task Type";
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            WinList list = new WinList(window);
            list.WindowTitles.Add(TASK);
            if (data == string.Empty)
            {
                Mouse.Click(list);
            }
            else
            {
                list.SelectedItemsAsString = data;
            }
        }

        //ClickListViewToEmpty
        public static void ClickListViewToEmpty(string name, string data)
        {
            const string TASK = "Task Type";
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            window.WindowTitles.Add(TASK);
            WinList list = new WinList(window);
            list.SelectedItemsAsString = null;
        }

        //SetNumericUpDown
        public static void SetNumericUpDown(string name, string keys)
        {
            const string ENTER = "{Enter}";
            WinComboBox spinner = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            if (spinner.SelectedItem != keys)
                spinner.SelectedItem = keys;
            Keyboard.SendKeys(ENTER);
        }

        //SetComboBox
        public static void SetComboBox(string name, string targetName)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            if (comboBox.SelectedItem != targetName)
                comboBox.SelectedItem = targetName;
        }

        //SetCheckBox
        public static void SetCheckBox(string name, bool isChecked)
        {
            WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
            if (checkBox.Checked != isChecked)
                checkBox.Checked = isChecked;
        }

        //AssertEdit
        public static void AssertEdit(string name, string assertValue)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            Assert.AreEqual(edit.Text, assertValue);
        }

        //AssertText
        public static void AssertText(string name, string assertValue)
        {
            WinText edit = (WinText)Robot.FindWinControl(typeof(WinText), name, _root);
            Assert.AreEqual(edit.DisplayText, assertValue);
        }

        //AssertCheckBox
        public static void AssertCheckBox(string name, bool isChecked)
        {
            WinCheckBox checkBox = (WinCheckBox)Robot.FindWinControl(typeof(WinCheckBox), name, _root);
            Assert.AreEqual(checkBox.Checked, isChecked);
        }

        //AssertNumericUpDown
        public static void AssertNumericUpDown(string name, string keys)
        {
            WinComboBox spinner = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            Assert.AreEqual(spinner.SelectedItem, keys);
        }

        //AssertDateTimePicker
        public static void AssertDateTimePicker(string[] data)
        {
            const int TWO = 2;
            const int THREE = 3;
            WinDateTimePicker dateTimePicker = (WinDateTimePicker)Robot.FindWinControl(typeof(WinDateTimePicker), data[0], _root);
            Assert.AreEqual(dateTimePicker.DateTime.Year, int.Parse(data[1]));
            Assert.AreEqual(dateTimePicker.DateTime.Month, int.Parse(data[TWO]));
            Assert.AreEqual(dateTimePicker.DateTime.Day, int.Parse(data[THREE]));
        }

        // AssertComboBox
        public static void AssertComboBox(string name, string assertValue)
        {
            WinComboBox comboBox = (WinComboBox)Robot.FindWinControl(typeof(WinComboBox), name, _root);
            Assert.AreEqual(comboBox.SelectedItem, assertValue);
        }

        //AssertListViewByValue
        public static void AssertListViewByValue(string name, string[] data)
        {
            const string TASK = "Task Type";
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            WinList list = new WinList(window);
            list.WindowTitles.Add(TASK);
            UITestControlCollection collection = list.Items;
            for (int i = 0; i < collection.Count; i++)
            {
                Assert.AreEqual(data[i], collection[i].Name);
            }
        }

        //AssertDataGridViewByIndex
        public static void AssertDataGridViewByIndex(string name, string index, string[] data)
        {
            WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            WinRow row = new WinRow(table);
            row.SearchProperties.Add(WinRow.PropertyNames.RowIndex, index);
            row.Find();
            UITestControlCollection collection = row.GetChildren();
            for (int i = 0; i < collection.Count; i++)
            {
                WinCell cell = collection[i] as WinCell;
                Assert.AreEqual(data[i], cell.Value);
            }
        }

        //AssertDataItemsInDataGridView
        public static void AssertDataItemsInDataGridView(string name, int items)
        {
            WinTable table = (WinTable)Robot.FindWinControl(typeof(WinTable), name, _root);
            Assert.AreEqual(table.Rows.Count, items);
        }

        //AssertButtonEnable
        public static void AssertButtonEnable(string name, bool state)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Assert.AreEqual(button.Enabled, state);
        }

        //AssertWindow
        public static void AssertWindow(string name)
        {
            const string KEY_TEXT = "\n";
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), name, null);
            Keyboard.SendKeys(window, KEY_TEXT);
        }

        //SendKeyEnterToMessageBox
        public static void SendKeyEnterToMessageBox(string caption)
        {
            const string ENTER = "{Enter}";
            WinControl control = (WinControl)Robot.FindWinControl(typeof(WinControl), caption, null);
            Keyboard.SendKeys(ENTER);
        }

        //ClickRadioButton
        public static void ClickRadioButton(string name)
        {
            WinRadioButton radio = (WinRadioButton)Robot.FindWinControl(typeof(WinRadioButton), name, _root);
            Mouse.Click(radio);
        }

        //ClickHyperlink
        public static void ClickLink(string name)
        {
            WinHyperlink link = (WinHyperlink)Robot.FindWinControl(typeof(WinHyperlink), name, _root);
            Mouse.Click(link);
        }
    }
}
