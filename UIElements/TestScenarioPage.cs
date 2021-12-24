using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationFramework.UIElements
{
    public class TestScenarioPage
    {
        public TestScenarioPage()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-72.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div > header > h3 > a")]
        public IWebElement LoginFormScenario { get; set; }
    }
}
