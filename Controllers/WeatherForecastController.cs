using CopilotWebAPI.Abstractions;
using CopilotWebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CopilotWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherService _weatherForecastService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastService.GetWeatherForecast();
        }
    }
}
