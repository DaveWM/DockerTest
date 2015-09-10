using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DockerTest.Controllers
{
    [Route("api/[controller]")]
    public class SportController : Controller
    {
        private static List<string> Sports = new List<string> {"Football", "Tennis", "Rugby", "Cricket"};

            // GET: api/sport
        [HttpGet]
        public string Get()
        {
            var containerNumString = Environment.GetEnvironmentVariable("HOSTNAME")?.Split('-').Last() ?? "1";
            var containerNum = Int32.Parse(containerNumString);
            var index = (containerNum - 1) % Sports.Count;
            return Sports[index];
        }
    }
}
