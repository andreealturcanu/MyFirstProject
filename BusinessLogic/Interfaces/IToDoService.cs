using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.Interfaces
{
    public interface IToDoService
    {
        Task<long> PostToDoItem(ToDoItemModel toDoViewModel);
    }
}
