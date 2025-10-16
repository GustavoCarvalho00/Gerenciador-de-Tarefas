using ManagerTask.Communication.Enum;
using System.ComponentModel.DataAnnotations;

namespace ManagerTask.Communication.Requests;
public class RequestManagerTask
{
    [Required(ErrorMessage = "O Nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome do autor deve ter no máximo 100 caracteres.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "A Descrição é obrigatória.")]
    [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = "A Data de Vencimento é obrigatória.")]
    public DateTime DueDate { get; set; }

    [Required(ErrorMessage = "A Prioridade é obrigatória e somente com valores permitidos 0-1-2")]
    public PriorityTaskType Priority { get; set; }

    [Required(ErrorMessage = "O Status é obrigatório e somente com valores permitidos 1-2-3")]
    public StatusTask Status { get; set; }
}
