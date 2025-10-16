using ManagerTask.Communication.Enum;

namespace ManagerTask.Communication.Responses;
public class ResponseRegisterManagerTask
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public StatusTask Status { get; set; }          // status inicial (ex: "Pending")
    public PriorityTaskType Priority { get; set; }  // prioridade inicial

    public DateTime DueDate { get; set; } = DateTime.UtcNow; 
}



