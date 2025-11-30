using Core.Entities;

namespace Tasko.DataAccess.Repositories
{
    public interface IProjectRepository : IGenericRepository<Projects>
    {
        // İleride Project’e özel metodlar eklenebilir
        // Örnek: Task<List<Projects>> GetByOwnerUserIdAsync(int ownerId);
    }
}
