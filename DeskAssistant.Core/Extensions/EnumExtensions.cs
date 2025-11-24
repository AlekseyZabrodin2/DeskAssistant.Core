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
                "выполняется" => TaskStatusEnum.InProgress,
                "ожидание" => TaskStatusEnum.Pending,
                "завершено" => TaskStatusEnum.Completed,
                "просрочено" => TaskStatusEnum.Expired,
                _ => TaskStatusEnum.InProgress
            };
        }

        public string PrioritiesLevelToString(PrioritiesLevelEnum priority)
        {
            return priority switch
            {
                PrioritiesLevelEnum.Высокий => "Высокий",
                PrioritiesLevelEnum.Средний => "Средний",
                PrioritiesLevelEnum.Низкий => "Низкий",
                _ => "Низкий"
            };
        }

        public string StatusToString(TaskStatusEnum status)
        {
            return status switch
            {
                TaskStatusEnum.InProgress => "Выполняется",
                TaskStatusEnum.Pending => "Ожидание",
                TaskStatusEnum.Completed => "Завершено",
                TaskStatusEnum.Expired => "Просрочено",
                _ => "Выполняется"
            };
        }

    }
}
