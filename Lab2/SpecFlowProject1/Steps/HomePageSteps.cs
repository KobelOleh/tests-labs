using PageObject;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class HomePageSteps:BaseSteps
    {
        private HomePage homePage;


        [Given(@"open the XYZ Bank page")]
        public void GivenOpenTheXYZBankPage()
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login";
            homePage = new HomePage(driver);
        }

        [Given(@"click on the Bank Manager Login button")]
        public void GivenClickOnTheBankManagerLoginButton()
        {
            homePage.ClickBankManagerLogin();
        }
    }
}
