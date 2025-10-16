namespace ManagerTask.Communication.Responses;
public class ResponseAllTasks
{
    public List<ResponseShortsTask> Tasks { get; set; } = [];
    //essa classe foi feita para retornar todas as tasks que estão cadastradas no sistema
}
