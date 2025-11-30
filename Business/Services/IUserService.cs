using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasko.Business.Services
{
    public interface IUserService
    {
        Task<List<Users>> GetAllUsersAsync();
        Task<Users> GetUserByEmailAsync(string email);
        Task AddUserAsync(Users user);
        Task UpdateUserAsync(Users user);
        Task DeleteUserAsync(int userId);
    }
}
