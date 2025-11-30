using Core.Entities;
using Core.Entities;

namespace Tasko.DataAccess.Repositories
{
    public interface IUserRepository : IGenericRepository<Users>
    {
        // Özel methodlar
        Task<Users> GetByEmailAsync(string email);
    }
}
