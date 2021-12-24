using AutomationFramework.UIElements;
using System;
using System.Threading;

namespace AutomationFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
            NavigateTo.LoginThroughTestPage();
            Thread.Sleep(5000);


            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
            NavigateTo.LoginThroughTestScenarios();
            Thread.Sleep(5000);

            Driver.driver.Quit();

        }
    }
}
