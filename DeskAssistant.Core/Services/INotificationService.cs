using DeskAssistant.Core.Models;

namespace DeskAssistant.Core.Services
{
    public interface INotificationService
    {
        Task<List<NotificationEntity>> GetNotificationsSettingsAsync(string clientId);
        Task CreatNotificationsAsync(NotificationEntity notification); 
        Task DeleteNotificationAsync(string clientId, string notificationId);
        Task SetNotificationsStatusAsync(NotificationEntityStatus notificationStatus);
    }
}
