using ManagerTask.Communication.Enum;

namespace ManagerTask.Communication.Responses;
public class ResponseShortsTask
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityTaskType Priority { get; set; }
    public StatusTask Status { get; set; }

    public DateTime DueDate { get; set; } = DateTime.UtcNow;

}
