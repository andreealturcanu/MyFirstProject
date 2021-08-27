using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Implementations
{
    public class ToDoItemRepository: GenericRepository<ToDoItem>, IToDoItemRepository
    {
        public ToDoItemRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<long> AddToDoItem(ToDoItem entity)
        {
            var x = await Add(entity);
            return x.ID;
        }
    }
}
