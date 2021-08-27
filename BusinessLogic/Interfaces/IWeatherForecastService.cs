using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecastModel> GetWeatherForecast();
    }
}
