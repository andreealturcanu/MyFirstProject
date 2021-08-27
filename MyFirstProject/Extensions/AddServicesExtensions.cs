using BusinessLogic;
using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MyFirstProject.Extensions
{
    internal static class AddServicesExtensions
    {
        internal static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddTransient<IToDoService, ToDoService>();
        }
    }
}
