using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.UIElements
{
    public class RightSideBar
    {
        public RightSideBar()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#recent-posts-2 > ul > li:nth-child(1) > a")]
        public IWebElement FirstRecentPost { get; set; }

        [FindsBy(How = How.Name, Using = "cat")]
        public IWebElement CategoryMenu { get; set; }


    }
}
