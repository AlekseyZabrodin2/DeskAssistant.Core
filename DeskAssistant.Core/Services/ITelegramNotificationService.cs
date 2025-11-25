using DeskAssistant.Core.Models;

namespace DeskAssistant.Core.Services
{
    public interface ITelegramNotificationService
    {
        Task<List<CalendarTaskEntity>> GetAllTasksAsync();
        Task<List<CalendarTaskEntity>> GetTasksForTodayAsync();
        Task<CalendarTaskEntity> AddTaskAsync(CalendarTaskEntity taskEntity);
        Task UpdateTaskAsync(CalendarTaskModel taskEntity, TaskStatusEnum status);
        Task NotifyTaskCreatedAsync(CalendarTaskModel notification);
        Task NotifyTaskCompletedAsync(CalendarTaskModel notification);
    }
}
