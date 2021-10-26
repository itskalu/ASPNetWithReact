using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETWithReactJS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] ImageURLs = new[]
       {
            "https://i.insider.com/5953a2645d3e4e41fd2623e1?width=1063&format=jpeg",
            "https://www.justapack.com/wp-content/uploads/2019/03/paris-france-sites.jpg",
            "https://www.goabroad.com/section_cloudinary/gaplabs/image/upload/images2/program_content/1-1565754901.jpg",
            "https://thumbor.forbes.com/thumbor/711x474/https://specials-images.forbesimg.com/dam/imageserve/1049399747/960x0.jpg?fit=scale"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)],
                ImageURL = ImageURLs[rng.Next(ImageURLs.Length)]
            })
            .ToArray();
        }
    }
}
