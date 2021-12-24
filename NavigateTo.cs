using AutomationFramework.UIElements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AutomationFramework
{
    public static class NavigateTo
    {
        public static void LoginThroughTestScenarios()
        {
            Menu menu = new Menu();
            TestScenarioPage tsPage = new TestScenarioPage();
            menu.TestScenarios.Click();
            Thread.Sleep(5000);
            tsPage.LoginFormScenario.Click();
            Thread.Sleep(5000);
        }

        public static void LoginThroughTestPage()
        {
            Menu menu = new Menu();
            TestCasePage tcPage = new TestCasePage();
            UserNameFieldPost ucPost = new UserNameFieldPost();
            menu.TestCase.Click();
            Thread.Sleep(5000);
            tcPage.UserNameCase.Click();
            Thread.Sleep(7000);
            ucPost.LoginFormLink.Click();
            Thread.Sleep(5000);

        }
    }
}
