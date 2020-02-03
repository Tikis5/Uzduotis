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

        [FindsBy(How = How.LinkText, Using = "c#")]
        public IWebElement ResultCSharp { get; set; }
    }
}