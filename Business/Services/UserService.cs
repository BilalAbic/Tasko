using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tasko.DataAccess.Repositories;

namespace Tasko.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<Users>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<Users> GetUserByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task AddUserAsync(Users user)
        {
            var exists = await _userRepository.GetByEmailAsync(user.Email);
            if (exists != null)
                throw new System.Exception("Bu email zaten kayıtlı.");

            user.PasswordHash = HashPassword(user.PasswordHash);
            await _userRepository.AddAsync(user);
        }

        public async Task UpdateUserAsync(Users user)
        {
            _userRepository.Update(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user != null)
                _userRepository.Delete(user);
        }

        private string HashPassword(string password)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = System.Text.Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return System.Convert.ToBase64String(hash);
        }
    }
}
