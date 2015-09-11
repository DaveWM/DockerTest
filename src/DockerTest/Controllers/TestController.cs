using Microsoft.AspNet.Mvc;

namespace DockerTest.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET: api/test
        [HttpGet]
        public string Get()
        {
            return "Hello World V2";
        }
    }
}
