using CopilotWebAPI.Model;

namespace CopilotWebAPI.Abstractions
{
    public interface IWeatherService
    {
        public IEnumerable<WeatherForecast> GetWeatherForecast();
    }
}
