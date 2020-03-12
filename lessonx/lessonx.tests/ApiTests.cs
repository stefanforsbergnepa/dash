using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Shouldly;
using Xunit;

namespace lessonx.tests
{
    public class ApiTests
    {
        private HttpClient httpClient;
        
        public ApiTests()
        {
            var builder = new WebHostBuilder()
                .UseStartup<Startup>();

            var testServer = new TestServer(builder);
            httpClient = testServer.CreateClient();
        }

        [Fact]
        public async Task No_place_like_home()
        {        
            var response = await httpClient.GetStringAsync("/home");

            response.ShouldBe("There is no place like 127.0.0.1");
        }

        [Fact]
        public async Task Get_with_parameter()
        {        
            // GET route /home with a parameter 'number'
            var response = await httpClient.GetStringAsync("/home?number=10");

            response.ShouldBe("Your parameter was 10");
        }

        [Fact]
        public async Task Posting_json_data()
        {        
            // POST json object '{ "Number": 10 }' to route /home
            var postData = new StringContent("{\"Number\": 10}", Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync("/home", postData);
            var content = await response.Content.ReadAsStringAsync();

            response.StatusCode.ShouldBe(HttpStatusCode.OK);
            content.ShouldBe("You posted number 10");
        }

        [Fact]
        public async Task Returning_json_data()
        {        
            // GET a json response '{ "SomeProperty": "TheValue" }' from route /json with parameter value=TheValue
            var response = await httpClient.GetAsync("/json?value=TheValue");
            var jsonContent = await response.Content.ReadAsStringAsync();
            var contentTypeHeader = response.Content.Headers.GetValues("Content-Type").Single();

            contentTypeHeader.ShouldBe("application/json; charset=utf-8");
            jsonContent.ShouldBe("{\"someProperty\":\"TheValue\"}");
        }
    }
}
