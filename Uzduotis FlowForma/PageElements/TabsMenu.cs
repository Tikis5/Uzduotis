using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace StackOverflow
{
    public class TabsMenu
    {
        public TabsMenu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "tagfilter")]
        public IWebElement TagFilterTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#tags-browser > div:nth-child(1) > a")]
        public IWebElement ResultCSharp { get; set; }
    }
}