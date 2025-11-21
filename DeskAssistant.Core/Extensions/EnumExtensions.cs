namespace DeskAssistant.Core.Extensions
{
    public class EnumExtensions
    {

        public PrioritiesLevelEnum PrioritiesLevelFromString(string priority)
        {
            return priority?.ToLower() switch
            {
                "высокий" => PrioritiesLevelEnum.Высокий,
                "средний" => PrioritiesLevelEnum.Средний,
                "низкий" => PrioritiesLevelEnum.Низкий,
                _ => PrioritiesLevelEnum.Низкий
            };
        }

        public TaskStatusEnum StatusFromString(string status)
        {
            return status?.ToLower() switch
            {
                "в процессе" => TaskStatusEnum.InProgress,
                "в ожидание" => TaskStatusEnum.Pending,
                "выполненно" => TaskStatusEnum.Completed,
                _ => TaskStatusEnum.InProgress
            };
        }

        public string PrioritiesLevelToString(PrioritiesLevelEnum priority)
        {
            return priority switch
            {
                PrioritiesLevelEnum.Высокий => "высокий",
                PrioritiesLevelEnum.Средний => "средний",
                PrioritiesLevelEnum.Низкий => "низкий",
                _ => "низкий"
            };
        }

        public string StatusToString(TaskStatusEnum status)
        {
            return status switch
            {
                TaskStatusEnum.InProgress => "в процессе",
                TaskStatusEnum.Pending => "в ожидание",
                TaskStatusEnum.Completed => "выполненно",
                _ => "в процессе"
            };
        }

    }
}
