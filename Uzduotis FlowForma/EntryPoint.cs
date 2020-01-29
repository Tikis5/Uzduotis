namespace Uzduotis_FlowForma
{
    public class EntryPoint
    {
        static void Main()
        {
            NavigationMeniu navigationMeniu = new NavigationMeniu();
            FilterMeniu filterMeniu = new FilterMeniu();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);

            navigationMeniu.LeftNavigationMeniu.Click();
            navigationMeniu.NavMeniuStackOverflow.Click();
            filterMeniu.Filter.Click();
            filterMeniu.CheckBoxNoAcceptedAnswer.Click();
            filterMeniu.RadioButtonRecentActivity.Click();
            filterMeniu.FilterMeniuTextBox.SendKeys("javascript");
            filterMeniu.FilterMeniuButton.Click();

            Driver.driver.Quit();
        }
    }
}
