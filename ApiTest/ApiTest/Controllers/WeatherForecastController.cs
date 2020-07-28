using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //Ocp-Apim-Subscription-Key

            Request.Headers.TryGetValue("Ocp-Apim-Subscription-Key", out StringValues subscriptionKey);

            return Ok(JsonConvert.SerializeObject(subscriptionKey));
        }
    }
}
