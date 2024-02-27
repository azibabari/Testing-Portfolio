using RestSharp;
using System;
using TechTalk.SpecFlow;
using Newtonsoft.Json.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;

namespace SpecFlowProject.Specs.StepDefinitions
{
    [Binding]
    public class BookAPITestingStepDefinitions
    {
        private int expectedStatusCode = 200;
        private RestResponse response;
        [Given(@"I make a request to the book API")]
        public async Task GivenIMakeARequestToTheBookAPIAsync()
        {
            var options = new RestClientOptions("https://simple-books-api.glitch.me")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/books", Method.Get);
            response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int expectedStatusCode)
        {
            Assert.AreEqual(expectedStatusCode, (int)response.StatusCode);
        }

        [Then(@"the response body should contain id, name, availability, and type of books")]
        public void ThenTheResponseBodyShouldContainIdNameAvailabilityAndTypeOfBooks()
        {
            JArray responseData = JArray.Parse(response.Content);

            Assert.IsTrue(responseData.Count > 0);

            foreach (JObject item in responseData)
            {
                Assert.IsTrue(item.ContainsKey("id"));
                Assert.IsTrue(item.ContainsKey("name"));
                Assert.IsTrue(item.ContainsKey("available"));
                Assert.IsTrue(item.ContainsKey("type"));

                var idValue = item["id"];
                var nameValue = item["name"];
                var availableValue = item["available"];
                var typeValue = item["type"];

                Assert.AreEqual(JTokenType.Integer, idValue.Type);
                Assert.AreEqual(JTokenType.String, nameValue.Type);
                Assert.AreEqual(JTokenType.Boolean, availableValue.Type);
                Assert.AreEqual(JTokenType.String, typeValue.Type);
            }
        }
    }
}
