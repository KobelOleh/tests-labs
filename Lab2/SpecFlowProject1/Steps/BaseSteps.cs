using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class BaseSteps
    {
        protected static WebDriverWait wait;
        protected static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeFeature()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }

}
