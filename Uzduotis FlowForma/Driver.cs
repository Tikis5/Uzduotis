using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace StackOverflow
{
    public static class Driver
    {
        public static IWebDriver driver = new ChromeDriver();
    }
}
