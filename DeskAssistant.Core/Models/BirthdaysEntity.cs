using CommunityToolkit.Mvvm.ComponentModel;

namespace DeskAssistant.Core.Models
{
    public partial class BirthdaysEntity : ObservableObject
    {

        [ObservableProperty]
        public partial int Id { get; set; }

        [ObservableProperty]
        public partial string LastName { get; set; }
        [ObservableProperty]
        public partial string Name { get; set; }
        [ObservableProperty]
        public partial string MiddleName { get; set; }

        [ObservableProperty]
        public partial DateTime? Birthday { get; set; }

        [ObservableProperty]
        public partial string Email { get; set; }
    }
}
