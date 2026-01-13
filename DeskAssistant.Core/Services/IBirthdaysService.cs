using DeskAssistant.Core.Models;

namespace DeskAssistant.Core.Services
{
    public interface IBirthdaysService
    {
        Task AddBirthdaysToDbAsync(BirthdaysEntity birthdaysEntity);
        Task<List<BirthdaysEntity>> GetBirthdaysFromDbAsync();
        Task<List<BirthdaysEntity>> GetBirthdaysForTodayAsync();
    }
}
