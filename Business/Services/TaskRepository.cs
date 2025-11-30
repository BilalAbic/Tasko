using Core.Entities;
using DataAccess.Context;

namespace Tasko.DataAccess.Repositories
{
    public class TaskRepository : GenericRepository<TaskItem>, ITaskRepository
    {
        public TaskRepository(TaskoDbContext context) : base(context)
        {
        }

        // TaskItem’a özel metodlar buraya eklenebilir
    }
}
