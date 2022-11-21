using OpenQA.Selenium;


namespace PageObject
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement BankManagerLoginBtn => driver.FindElement(By.XPath("//button[@ng-click='manager()']"));
        public void ClickBankManagerLogin() => BankManagerLoginBtn.Click();
    }
}
