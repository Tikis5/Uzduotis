using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Uzduotis_FlowForma
{
    public class NavigationMeniu
    {
        public NavigationMeniu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "left-sidebar-toggle")]
        public IWebElement LeftNavigationMeniu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#nav-questions > span")]
        public IWebElement NavMeniuStackOverflow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#nav-tags")]
        public IWebElement NavMeniuTabs { get; set; }
    }
}
