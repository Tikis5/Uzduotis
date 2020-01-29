using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Uzduotis_FlowForma
{
    public class FilterMeniu
    {
        public FilterMeniu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"mainbar\"]/div[2]/div/div[2]/div/div[3]")]
        public IWebElement Filter { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[2]/div[1]/div[2]/form/div/div/div[1]/div/div[1]/fieldset/div[2]/div/label")]
        public IWebElement CheckBoxNoAcceptedAnswer { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div[2]/div[1]/div[2]/form/div/div/div[1]/div/div[2]/fieldset/div[2]/div/div/input")]
        public IWebElement RadioButtonRecentActivity { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#uql-form > div > div > div.px12.py16 > div > div:nth-child(3) > div > div > input")]
        public IWebElement FilterMeniuTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#uql-form > div > div > div.p12.bt.bc-black-3 > div > div.grid.gs4.gsx.fl1 > button")]
        public IWebElement FilterMeniuButton { get; set; }
    }
}