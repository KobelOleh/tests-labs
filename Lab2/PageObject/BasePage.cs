using OpenQA.Selenium;

namespace PageObject
{
    public class BasePage
    {
        protected static IWebDriver driver;
        public BasePage (IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}