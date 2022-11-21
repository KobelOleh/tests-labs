using OpenQA.Selenium;

namespace PageObject
{
    public class CustomersPage : BasePage
    {
        public CustomersPage(IWebDriver webDriver) : base(webDriver) {
        }

        private IWebElement btnDeleteCustomer => driver.FindElement(By.XPath("//tr/td[5]/button")); 

        private List<IWebElement> CustomersList => driver.FindElements(By.XPath("//tbody/tr[@class='ng-scope']")).ToList<IWebElement>();

        public void ClickDeleteCustomer() => btnDeleteCustomer.Click();
        public List<string> GetCustomersList() => CustomersList.Select(el => el.Text).ToList<string>();

    }
}
