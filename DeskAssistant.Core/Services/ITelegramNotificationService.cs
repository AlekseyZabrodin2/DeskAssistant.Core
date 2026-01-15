using DeskAssistant.Core.Models;

namespace DeskAssistant.Core.Services
{
    public interface ITelegramNotificationService
    {
        Task<List<CalendarTaskEntity>> GetAllTasksAsync();
        Task<List<CalendarTaskEntity>> GetTasksForTodayAsync();
        Task<CalendarTaskEntity> AddTaskAsync(CalendarTaskEntity taskEntity);
        Task UpdateTaskAsync(CalendarTaskModel taskEntity, TaskStatusEnum status);
        Task NotifiTaskCreatedAsync(CalendarTaskModel notification);
        Task NotifiTaskCompletedAsync(CalendarTaskModel notification);
        Task NotificationAboutTasksAsync(CalendarTaskModel notification);
        Task NotificationAboutBirthdaysAsync(BirthdaysEntity birthdays);
    }
}
