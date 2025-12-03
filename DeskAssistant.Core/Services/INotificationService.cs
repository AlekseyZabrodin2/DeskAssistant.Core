using DeskAssistant.Core.Models;

namespace DeskAssistant.Core.Services
{
    public interface INotificationService
    {
        Task<List<NotificationEntity>> GetNotificationsSettingsAsync(string clientId);
        Task GetNotificationStatus(NotificationEntity notification);
        Task CreatNotificationsAsync(NotificationEntity notification); 
        Task DeleteNotificationAsync(NotificationEntity notification);
        Task ActivateNotificationsAsync(NotificationEntity notification);
        Task DisableNotificationsAsync(NotificationEntity notification);

        Task StartNotificationServiceAsync();
        Task StopNotificationServiceAsync();
    }
}
