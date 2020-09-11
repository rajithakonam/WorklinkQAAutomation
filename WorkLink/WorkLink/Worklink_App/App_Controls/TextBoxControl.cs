using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkLink.Worklink_App.App_Controls
{
    public class TextBoxControl : BaseAppControl
    {
        public AppiumWebElement element;
        public void SetText(String Xpath, String text)
        {
           element = IsActive(Xpath);
            element.SendKeys(text);
        }
        public void ClearText()
        {

        }
        public void GetText()
        {

        }

    }
}
