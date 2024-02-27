using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Specs.Pages
{
    internal class ProductPage
    {
        private IWebDriver _driver;

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
