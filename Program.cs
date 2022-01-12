using AutomationFramework.UIElements;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace AutomationFramework
{
    class Program
    {
        IAlert alert;
        //static void Main(string[] args)
        ////{

        ////}
        [SetUp]
        public void Initialize()
        {
            Action.InitializeDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginThroughTestPage();
            Action.FillTheLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertTexts.SuccessfullLogin, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
