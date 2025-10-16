using ManagerTask.Application.UseCases.Manager.Delete;
using ManagerTask.Application.UseCases.Manager.GetAll;
using ManagerTask.Application.UseCases.Manager.GetById;
using ManagerTask.Application.UseCases.Manager.Register;
using ManagerTask.Application.UseCases.Manager.Update;
using ManagerTask.Communication.Requests;
using ManagerTask.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ManagerTaks.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ManagerTaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterManagerTask),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestManagerTask request)
    {
        var response = new RegisterManagerTaskUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id,[FromBody] RequestManagerTask request)
    {
        var useCase = new UpdateManagerTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasks), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCase();
        var response = useCase.Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseManagerTasks), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetById(int id)
    {

        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);
        //implementar a logica de pegar a task pelo id
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {

        var useCase = new DeleteTaskByIdUseCase(); // criar uma instancia do caso de uso
        useCase.Execute(id); // chamar o metodo execute do caso de uso
        //implementar a logica de deletar a task pelo id
        return NoContent();
    }
}
