using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBasket.Pages
{
    internal class HomePage
    {
        private IWebDriver _driver;
        private string _url = "https://www.amazon.com";
        private string TpName = "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)";
        private By searchBox = By.Id("twotabsearchbox");
        private By searchButton = By.Id("nav-search-submit-button");
        private By continueShopping = By.Id("a-button-text");

        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }
            public void NavigateTo()
        {
            _driver.Navigate().GoToUrl(_url);
        }
        public void WaitFor()
        {
            System.Threading.Thread.Sleep(10000); // Short wait for user to type in the RECAPTCHA TEST
        }
        public void ClickContinueShopping()
        {
            _driver.FindElement(continueShopping).Click();
        }
        public void EnterProductName(string TpName)
        {
            _driver.FindElement(searchBox).SendKeys(TpName);
        }

        public void ClickSearchButton()
        {
            _driver.FindElement(searchButton).Click();
        }
    }
}
