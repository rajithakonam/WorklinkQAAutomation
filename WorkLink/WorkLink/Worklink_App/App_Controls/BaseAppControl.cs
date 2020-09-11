using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkLink.Worklink_App.App_Controls
{
    public class BaseAppControl : BaseControl
    {
        public AppiumWebElement element;
        public AppiumWebElement IsActive(String Xpath)
        {
            return element;
        }

    }
}
