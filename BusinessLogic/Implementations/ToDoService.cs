using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;
using Microsoft.Extensions.Logging;

namespace BusinessLogic.Implementations
{
    public class ToDoService : IToDoService
    {
        private readonly ILogger<WeatherForecastService> _logger;
        private readonly IToDoItemRepository _toDoRepository;
        private readonly IMapper _mapper;


        public ToDoService(ILogger<WeatherForecastService> logger, IMapper mapper, IToDoItemRepository toDoRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _toDoRepository = toDoRepository;
        }

        public async Task<long> PostToDoItem(ToDoItemModel toDoItemModel)
        {
            _logger.LogDebug(@$"PostToDoItem was called with model: {toDoItemModel}");
            ToDoItem entity = _mapper.Map<ToDoItem>(toDoItemModel);
            long id = await _toDoRepository.AddToDoItem(entity);

            return id;
        }
    }
}
