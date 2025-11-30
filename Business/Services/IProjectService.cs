using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasko.Business.Services
{
    public interface IProjectService
    {
        Task<List<Projects>> GetAllProjectsAsync();
        Task<Projects> GetProjectByIdAsync(int projectId);
        Task AddProjectAsync(Projects project);
        Task UpdateProjectAsync(Projects project);
        Task DeleteProjectAsync(int projectId);
    }
}
