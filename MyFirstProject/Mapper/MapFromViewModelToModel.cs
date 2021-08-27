using AutoMapper;
using BusinessLogic.Models;
using MyFirstProject.ViewModels;

namespace MyFirstProject.Automapper
{
    public class MapFromViewModelToModel: Profile
    {
        public MapFromViewModelToModel()
        {
            CreateMap<ToDoItemViewModel, ToDoItemModel>();
            CreateMap<WeatherForecastModel, WeatherForecastViewModel>();
        }
    }
}
