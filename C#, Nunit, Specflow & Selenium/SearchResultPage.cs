using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Specs.Pages
{
    internal class SearchResultPage
    {
        private IWebDriver _driver;
        private By routername = By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[3]/div/div/span/div/div/div/div[2]/div/div/div[1]/h2/a");
        private string productName = "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)";
        public SearchResultPage(IWebDriver driver)
        {
            _driver = driver;
        }
        public bool VerifySearchResultsIncludeRouter(string productName)
        {
            IReadOnlyCollection<IWebElement> searchResult = _driver.FindElements(routername);
            foreach (var result in searchResult)
            {
                if (result.Text.Contains(productName))
                {
                    return true;
                }
            }
            return false;
        }
        public void ClickRouter()
        {
            _driver.FindElement(routername).Click();
        }
    }
}
