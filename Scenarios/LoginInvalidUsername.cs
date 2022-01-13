using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationFramework.Scenarios
{
    public class LoginInvalidUsername
    {
        IAlert alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            Action.InitializeDriver();
            NavigateTo.LoginThroughTestScenarios();
        }

        [TestCase]
        public void LessThan5Char()
        {
            Action.FillTheLoginForm(Config.Credentials.Invalid.UserName.FourCharacter, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);
        
            alert = Driver.driver.SwitchTo().Alert();
  
            Assert.AreEqual(Config.AlertTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MoreThan12Char()
        {
            Action.FillTheLoginForm(Config.Credentials.Invalid.UserName.ThirteenCharacter, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);
          
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
