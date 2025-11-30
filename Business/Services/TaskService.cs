using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tasko.DataAccess.Repositories;

namespace Tasko.Business.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllAsync();
        }

        public async Task<TaskItem> GetTaskByIdAsync(int taskId)
        {
            return await _taskRepository.GetByIdAsync(taskId);
        }

        public async Task AddTaskAsync(TaskItem task)
        {
            await _taskRepository.AddAsync(task);
        }

        public async Task UpdateTaskAsync(TaskItem task)
        {
            _taskRepository.Update(task);
        }

        public async Task DeleteTaskAsync(int taskId)
        {
            var task = await _taskRepository.GetByIdAsync(taskId);
            if (task != null)
                _taskRepository.Delete(task);
        }
    }
}
