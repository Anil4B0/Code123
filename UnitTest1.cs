using Newtonsoft.Json.Linq;
using RestSharp;
namespace Testone
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RestClient client = new RestClient("https://digitalapi.auspost.com.au");
            RestRequest request = new RestRequest("/postcode/search.json");
            request.AddHeader("auth-Key", "4b3bc7fb-f7f9-428c-a92a-685021667de1");
            request.AddParameter("Q", "QLD");
            request.AddParameter("postcode", "4075");

            RestResponse response = client.Execute(request);
            JObject  jsonData = JObject.Parse(request.);
            Assert
        }
    }
}