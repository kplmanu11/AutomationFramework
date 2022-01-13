using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationFramework.Scenarios
{
    public class LoginInvalidPassword
    {
        IAlert alert;

        [OneTimeSetUp]
        public void Intialize()
        {
            Action.InitializeDriver();
            NavigateTo.LoginThroughTestPage();
        }

        [TestCase]
        public void LessThan5Char()
        {
            Action.FillTheLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MoreThan12Char()
        {
            Action.FillTheLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);
       
            alert = Driver.driver.SwitchTo().Alert();
           
            Assert.AreEqual(Config.AlertTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {

            Driver.driver.Quit();
        }

    }
}
