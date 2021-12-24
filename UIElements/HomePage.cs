using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationFramework.UIElements
{
    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.mh-clearfix > div > div > div > div > a > h1")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.mh-clearfix > div > div > div > div > a > h2")]
        public IWebElement SubHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement HeadLine { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(1) > a > img")]
        public IWebElement Image { get; set; }
    }
}
