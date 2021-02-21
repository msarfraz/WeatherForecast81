using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherForecast81
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        // GET: /<controller>/
        public IEnumerable<String> Index()
        {
            return new String[] { "Hello Home!" };
        }
    }
}
