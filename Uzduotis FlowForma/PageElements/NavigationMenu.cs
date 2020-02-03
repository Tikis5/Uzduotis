using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace StackOverflow
{
    public class NavigationMenu
    {
        public NavigationMenu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "left-sidebar-toggle")]
        public IWebElement LeftNavigationMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#nav-questions > span")]
        public IWebElement NavMenuStackOverflow { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#nav-tags")]
        public IWebElement NavMenuTabs { get; set; }
    }
}
