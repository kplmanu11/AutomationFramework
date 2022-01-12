using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.UIElements
{
    public class LoginScenarioPost
    {
        public LoginScenarioPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "repeatpassid")]
        public IWebElement RepeatPassword { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement LoginButton { get; set; }
    }
}
