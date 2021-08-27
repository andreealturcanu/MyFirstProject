using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BusinessLogic;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MyFirstProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService, IMapper mapper)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(WeatherForecastViewModel))]
        [ProducesResponseType(404)]
        public IActionResult Get()
        {
            _logger.LogDebug("GetWeatherForecastController was called.");
            IEnumerable<WeatherForecastModel> weatherForecastModelList = _weatherForecastService.GetWeatherForecast();

            IEnumerable<WeatherForecastViewModel> weatherForecastViewModelList =
                weatherForecastModelList.Select(s => _mapper.Map<WeatherForecastViewModel>(s));

            if (!weatherForecastViewModelList.Any())
            {
                return NotFound();
            }

            return Ok(weatherForecastViewModelList);
        }
    }
}
