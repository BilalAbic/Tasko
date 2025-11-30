using Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasko.Business.Services
{
    public interface ITaskService
    {
        Task<List<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> GetTaskByIdAsync(int taskId);
        Task AddTaskAsync(TaskItem task);
        Task UpdateTaskAsync(TaskItem task);
        Task DeleteTaskAsync(int taskId);
    }
}
