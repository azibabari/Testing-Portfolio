using System;
using TechTalk.SpecFlow;
using SpecFlowProject.Specs.Pages;
using NextBasket.Pages;
using NUnit.Framework;

namespace SpecFlowProject.Specs.StepDefinitions
{
    [Binding]
    public class AddTP_LinkRouterToCartOnAmazonStepDefinitions
    {
        private IWebDriver _driver;
        private HomePage _home;
        private SearchResultPage _result;
        private ProductPage _product;
        private CartPage _cart;
        private string TpName = "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)";

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _home = new HomePage(_driver);
            _result = new SearchResultPage(_driver);
            _product = new ProductPage(_driver);
            _cart = new CartPage(_driver);
        }
        [Given(@"I navigate to the Amazon homepage")]
        public void GivenINavigateToTheAmazonHomepage()
        {
            _home.NavigateTo();
            _home.WaitFor();
            _home.ClickContinueShopping();
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string TpName)
        {
            _home.EnterProductName(TpName);
            _home.ClickSearchButton();
        }

        [Then(@"I verify the search results include the desired product")]
        public void ThenIVerifyTheSearchResultsIncludeTheDesiredProduct()
        {
            string productName = "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)";
            bool isProductPresent = _result.VerifySearchResultsIncludeRouter(productName);
            Assert.IsFalse(isProductPresent, "Desired product not found in search results");
        }

        [When(@"I select the first product matching the search term")]
        public void WhenISelectTheFirstProductMatchingTheSearchTerm()
        {
            _result.ClickRouter();
        }

        [Then(@"I am directed to the product details page")]
        public void ThenIAmDirectedToTheProductDetailsPage()
        {
            throw new PendingStepException();
        }

        [Then(@"I verify the product title is ""([^""]*)""")]
        public void ThenIVerifyTheProductTitleIs(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I verify the price is displayed as ""([^""]*)""")]
        public void ThenIVerifyThePriceIsDisplayedAs(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I click ""([^""]*)""")]
        public void WhenIClick(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I verify the ""([^""]*)"" button is available")]
        public void ThenIVerifyTheButtonIsAvailable(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I see a confirmation message indicating the product has been added to the cart")]
        public void ThenISeeAConfirmationMessageIndicatingTheProductHasBeenAddedToTheCart()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to the cart by clicking ""([^""]*)""")]
        public void WhenINavigateToTheCartByClicking(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I verify the added item is ""([^""]*)""")]
        public void ThenIVerifyTheAddedItemIs(string p0)
        {
            throw new PendingStepException();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
