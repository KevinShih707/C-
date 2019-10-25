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
        private static Dictionary<string, UITestControl> _cache;
        private static ApplicationUnderTest _aut;
        private static UITestControl _root;
        private const string CONTROL_NOT_FOUND_EXCEPTION = "The specific control is not found!!";
        private const string MSAA_TECHNOLOGY = "MSAA";

        //SetDelayBetweenActions
        public static void SetDelayBetweenActions(int millisecond)
        {
            Playback.PlaybackSettings.DelayBetweenActions = millisecond;
        }

        //UITestControl Initialize
        public static UITestControl Initialize(string path, string title)
        {
            Playback.PlaybackSettings.DelayBetweenActions = 0;
            Playback.PlaybackSettings.ThinkTimeMultiplier = 0.0d;
            Playback.PlaybackSettings.SkipSetPropertyVerification = true;
            Playback.PlaybackSettings.ShouldSearchFailFast = true;
            _aut = ApplicationUnderTest.Launch(path);

            _cache = new Dictionary<string, UITestControl>();
            WinWindow window = new WinWindow();
            window.SearchProperties.Add(WinWindow.PropertyNames.Name, title);
            CacheComponentFound(window, title);
            _root = window;
            return _root;
        }

        //CleanUp
        public static void CleanUp()
        {
            _cache.Clear();
            _root = null;
            _aut.Close();
        }

        //UITestControl SetForm
        public static UITestControl SetForm(string formName)
        {
            WinWindow window = (WinWindow)Robot.FindWinControl(typeof(WinWindow), formName, null);
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            _root = window;
            return _root;
        }

        //WinControl FindWinControl
        private static WinControl FindWinControl(Type type, string name, UITestControl parent)
        {
            if (_cache.ContainsKey(name))
            {
                return (WinControl)_cache[name];
            }
            else
            {
                WinControl control = (WinControl)Activator.CreateInstance(type, new Object[] { parent });
                control.SearchProperties.Add(WinControl.PropertyNames.Name, name);
                CacheComponentFound(control, name);
                return control;
            }
        }

        //CacheComponentFound
        private static void CacheComponentFound(UITestControl control, string name)
        {
            control.Find();
            if (!control.Exists)
            {
                throw new Exception(CONTROL_NOT_FOUND_EXCEPTION);
            }
            _cache.Add(name, control);
        }

        //ClickMenuItem
        public static void ClickMenuItem(string[] path)
        {
            foreach (string item in path)
            {
                Mouse.Click((WinMenuItem)Robot.FindWinControl(typeof(WinMenuItem), item, _root));
            }
        }

        //ClickDateTimePicker
        public static void ClickDateTimePicker(string[] data)
        {
            const string DATE = "DateTime";
            const string LINE = "/";
            const int TWO = 2;
            const int THREE = 3;
            WinDateTimePicker dateTimePicker = (WinDateTimePicker)Robot.FindWinControl(typeof(WinDateTimePicker), data[0], _root);
            dateTimePicker.SetProperty(DATE, data[1] + LINE + data[TWO] + LINE + data[THREE]);
        }

        //ClickButton
        public static void ClickButton(string name)
        {
            WinButton button = (WinButton)Robot.FindWinControl(typeof(WinButton), name, _root);
            Mouse.Click(button);
        }

        //ClickTabControl
        public static void ClickTabControl(string name)
        {
            Mouse.Click((WinTabPage)Robot.FindWinControl(typeof(WinTabPage), name, _root));
        }

        //SetEdit
        public static void SetEdit(string name, string keys)
        {
            WinEdit edit = (WinEdit)Robot.FindWinControl(typeof(WinEdit), name, _root);
            if (edit.Text != keys)
                edit.Text = keys;
        }

        //AssertOtherFormEdit
        public static void AssertOtherFormEdit(string formName, string editName, string assertValue)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinEdit edit = new WinEdit(window);
            edit.SearchProperties[WinWindow.PropertyNames.Name] = editName;
            Assert.AreEqual(edit.Text, assertValue);
        }

        //SetOtherFormEdit
        public static void SetOtherFormEdit(string formName, string editName, string keys)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinEdit edit = new WinEdit(window);
            edit.SearchProperties[WinWindow.PropertyNames.Name] = editName;
            if (edit.Text != keys)
                edit.Text = keys;
        }

        //ClickOtherFormButton
        public static void ClickOtherFormButton(string formName, string buttonName)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinButton button = new WinButton(window);
            button.SearchProperties[WinWindow.PropertyNames.Name] = buttonName;
            Mouse.Click(button);
        }

        //CloseWindow
        public static void CloseWindow(string name)
        {
            const string CLOSE = "Close";
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = name;
            window.WindowTitles.Add(name);
            WinTitleBar bar = new WinTitleBar(window);
            WinButton button = new WinButton(bar);
            button.SearchProperties[WinButton.PropertyNames.Name] = CLOSE;
            Mouse.Click(button);
        }

        // AssertOtherFormButtonEnable
        public static void AssertOtherFormButtonEnable(string formName, string buttonName, bool assertValue)
        {
            WinWindow window = new WinWindow();
            window.SearchProperties[WinWindow.PropertyNames.Name] = formName;
            window.WindowTitles.Add(formName);
            WinButton button = new WinButton(window);
            button.SearchProperties[WinWindow.PropertyNames.Name] = buttonName;
            Assert.AreEqual(button.Enabled, assertValue);
        }
    }
}