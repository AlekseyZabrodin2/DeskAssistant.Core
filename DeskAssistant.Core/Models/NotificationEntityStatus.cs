using CommunityToolkit.Mvvm.ComponentModel;

namespace DeskAssistant.Core.Models
{
    public partial class NotificationEntityStatus : ObservableObject
    {
        [ObservableProperty]
        public partial string Id { get; set; }

        [ObservableProperty]
        public partial string ClientId { get; set; }

        [ObservableProperty]
        public partial bool IsEnabled { get; set; }
    }
}
