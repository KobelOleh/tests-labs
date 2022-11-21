using PageObject;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class ManagerPageSteps : BaseSteps
    {
        private ManagerPage managerPage;

        [Given(@"click on the Customers button")]
        public void GivenClickOnTheCustomersButton()
        {
            managerPage = new ManagerPage(driver);
            managerPage.ClickCustomers();
        }

    }
}
