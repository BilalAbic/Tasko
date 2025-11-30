using Core.Entities;

namespace Tasko.DataAccess.Repositories
{
    public interface IOrganizationRepository : IGenericRepository<Organization>
    {
        // Gerekirse ekstra metodlar buraya eklenebilir
        // Örnek: Task<List<Organization>> GetByTypeAsync(string type);
    }
}
