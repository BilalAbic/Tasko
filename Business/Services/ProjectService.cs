using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tasko.DataAccess.Repositories;

namespace Tasko.Business.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<Projects>> GetAllProjectsAsync()
        {
            return await _projectRepository.GetAllAsync();
        }

        public async Task<Projects> GetProjectByIdAsync(int projectId)
        {
            return await _projectRepository.GetByIdAsync(projectId);
        }

        public async Task AddProjectAsync(Projects project)
        {
            await _projectRepository.AddAsync(project);
        }

        public async Task UpdateProjectAsync(Projects project)
        {
            _projectRepository.Update(project);
        }

        public async Task DeleteProjectAsync(int projectId)
        {
            var project = await _projectRepository.GetByIdAsync(projectId);
            if (project != null)
                _projectRepository.Delete(project);
        }
    }
}
