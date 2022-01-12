using AutomationFramework.UIElements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework
{
    public static class Action
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }
        public static void FillTheLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lstPost = new LoginScenarioPost();

            lstPost.Username.SendKeys(username);
            lstPost.Password.SendKeys(password);
            lstPost.RepeatPassword.SendKeys(repeatPassword);
            lstPost.LoginButton.Click();
        }
    }
}
