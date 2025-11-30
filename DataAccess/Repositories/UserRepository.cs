using Core.Entities;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataAccess.Context;

namespace Tasko.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        public UserRepository(TaskoDbContext context) : base(context)
        {
        }

        public async Task<Users> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
