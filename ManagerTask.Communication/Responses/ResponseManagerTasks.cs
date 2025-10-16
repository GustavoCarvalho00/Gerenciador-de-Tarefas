using ManagerTask.Communication.Enum;

namespace ManagerTask.Communication.Responses;
public class ResponseManagerTasks
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public StatusTask Status { get; set; } public string StatusMessage { get; set; } = string.Empty;

    public DateTime DueDate { get; set; } = DateTime.UtcNow;
    public PriorityTaskType Priority { get; set; }

}
