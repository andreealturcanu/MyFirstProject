using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MyFirstProject.Extensions
{
    internal static class AddRepositoryExtensions
    {
        internal static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<DbContext, AppDbContext>();
            services.AddTransient<IGenericRepository<ToDoItem>, GenericRepository<ToDoItem>>();
            services.AddTransient<IToDoItemRepository, ToDoItemRepository>();
        }
    }
}
