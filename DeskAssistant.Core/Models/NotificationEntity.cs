using CommunityToolkit.Mvvm.ComponentModel;

namespace DeskAssistant.Core.Models
{
    public partial class NotificationEntity : ObservableObject
    {
        [ObservableProperty]
        public partial string Id { get; set; }

        [ObservableProperty]
        public partial string ClientId { get; set; }
        [ObservableProperty]
        public partial bool IsEnabled { get; set; }
        [ObservableProperty]
        public partial TimeSpan NotificationTime { get; set; }

        [ObservableProperty]
        public partial Guid? TimerId { get; set; }

        [ObservableProperty]
        public partial bool MondayEnabled { get; set; }
        [ObservableProperty]
        public partial bool TuesdayEnabled { get; set; }
        [ObservableProperty]
        public partial bool WednesdayEnabled { get; set; }
        [ObservableProperty]
        public partial bool ThursdayEnabled { get; set; }
        [ObservableProperty]
        public partial bool FridayEnabled { get; set; }
        [ObservableProperty]
        public partial bool SaturdayEnabled { get; set; }
        [ObservableProperty]
        public partial bool SundayEnabled { get; set; }

        [ObservableProperty]
        public partial DateTime CreatedAt { get; set; }
        [ObservableProperty]
        public partial bool IsSentToday { get; set; }
    }
}
