using Core.Entities;

namespace Tasko.DataAccess.Repositories
{
    public interface ITaskRepository : IGenericRepository<TaskItem>
    {
        // İleride TaskItem’a özel metodlar eklenebilir
        // Örnek: Task<List<TaskItem>> GetByProjectIdAsync(int projectId);
    }
}
