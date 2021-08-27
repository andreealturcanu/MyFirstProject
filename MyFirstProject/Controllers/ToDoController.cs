using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstProject.ViewModels;

namespace MyFirstProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IToDoService _toDoService;
        private readonly IMapper _mapper;

        public ToDoController(ILogger<WeatherForecastController> logger, IToDoService toDoService, IMapper mapper)
        {
            _logger = logger;
            _toDoService = toDoService;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(200, Type = typeof(ToDoItemViewModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> PostToDoItem([FromBody] ToDoItemViewModel toDoViewModel)
        {
            _logger.LogDebug(@$"PostToDoItem was called with model: {toDoViewModel}");
            ToDoItemModel model = _mapper.Map<ToDoItemModel>(toDoViewModel);
            long id = await _toDoService.PostToDoItem(model);

            if (id == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
