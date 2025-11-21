using DeskAssistant.Core.Models;

namespace DeskAssistant.Core.Services
{
    public interface ITelegramNotificationService
    {
        Task NotifyTaskCreatedAsync(CalendarTaskModel notification);
        Task NotifyTaskCompletedAsync(CalendarTaskModel notification);

    }
}
