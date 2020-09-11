using System;
using System.Collections.Generic;
using System.Text;
using WorkLink.Worklink_App.App_Controls;

namespace WorkLink.Worklink_App.App_PageObjects
{
   public class LoginScreen : BaseAppScreen

    {
        public TextBoxControl textboxControl;
        public ButtonControl buttonControl;
        public LoginScreen()
        {
            textboxControl = new TextBoxControl();
            buttonControl = new ButtonControl();
        }
        public void Login(String username, String Password)
        {
            textboxControl.SetText("//",username);
            textboxControl.SetText("//", Password);
            buttonControl.ClickButton("//");
        }
    }
}
