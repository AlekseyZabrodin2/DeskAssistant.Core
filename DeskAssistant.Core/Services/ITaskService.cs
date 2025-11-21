using DeskAssistant.Core.Models;

namespace DeskAssistant.Core.Services
{
    public interface ITaskService
    {
        Task<CalendarTaskEntity> AddTaskAsync(CalendarTaskEntity taskEntity);
        Task<List<CalendarTaskEntity>> GetTasksForDateAsync(DateTime date);
        Task<CalendarTaskEntity> GetTaskByIdAsync(int id);
        Task<bool> DeleteTaskAsync(int id);

        Task<List<CalendarTaskEntity>> GetAllTasksAsync();
        Task AddTaskForSelectedDate(CalendarTaskEntity taskEntity);
        Task UpdateTaskAsync(CalendarTaskModel taskEntity, TaskStatusEnum status);
    }
}
