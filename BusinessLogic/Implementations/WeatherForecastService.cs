using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.Extensions.Logging;

namespace BusinessLogic
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly ILogger<WeatherForecastService> _logger;

        public WeatherForecastService(ILogger<WeatherForecastService> logger)
        {
            _logger = logger;
        }

        public IEnumerable<WeatherForecastModel> GetWeatherForecast()
        {
            _logger.LogDebug("GetWeatherForecastService was called.");
            Random rng = new Random();
            Array enumValues = Enum.GetValues(typeof(ESummaries));
            var random = rng.Next(enumValues.Length);
            var summary = enumValues.GetValue(random)?.ToString();

            var forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = summary
            })
                .ToArray();
            return forecast;
        }
    }
}