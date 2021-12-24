using AutomationFramework.UIElements;
using System;

namespace AutomationFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            menu.Selectors.Click();


        }
    }
}
