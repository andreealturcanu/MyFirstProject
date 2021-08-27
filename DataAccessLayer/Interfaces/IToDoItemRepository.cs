using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Interfaces
{
    public interface IToDoItemRepository: IGenericRepository<ToDoItem>
    {
        Task<long> AddToDoItem(ToDoItem entity);
    }
}
