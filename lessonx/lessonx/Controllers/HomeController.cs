using Microsoft.AspNetCore.Mvc;

namespace lessonx.Controllers
{
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "There is no place like 127.0.0.1";
        }
    }
}
