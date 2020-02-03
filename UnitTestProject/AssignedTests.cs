using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackOverflow;

namespace UnitTestProject
{
    [TestClass]
    public class AssignedTests
    {
        [TestMethod]
        public void FirstTest()
        {
            var filterMenu = new FilterMenu();
            var navigationMenu = new NavigationMenu();

            navigationMenu.LeftNavigationMenu.Click();
            navigationMenu.NavMenuStackOverflow.Click();
            filterMenu.Filter.Click();
            filterMenu.CheckBoxNoAcceptedAnswer.Click();
            filterMenu.RadioButtonRecentActivity.Click();
            filterMenu.FilterMenuTextBox.SendKeys("javascript");
            filterMenu.FilterMenuButton.Click();
            //Driver.driver.Quit();
        }
        [TestMethod]
        public void SecondTest()
        {
            var navigationMenu = new NavigationMenu();
            var tabsMenu = new TabsMenu();

            navigationMenu.LeftNavigationMenu.Click();
            navigationMenu.NavMenuTabs.Click();
            tabsMenu.TagFilterTextBox.Click();
            tabsMenu.TagFilterTextBox.SendKeys("c#");
            tabsMenu.ResultCSharp.Click();
        }
        [ClassInitialize]
        public void Initialize() 
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            //var navigationMenu = new NavigationMenu();
            //var tabsMenu = new TabsMenu();
        }
        [ClassCleanup]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
