using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace NextBasket
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public async Task TestMethodAsync()
            {
            var options = new RestClientOptions("https://simple-books-api.glitch.me")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/books", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
