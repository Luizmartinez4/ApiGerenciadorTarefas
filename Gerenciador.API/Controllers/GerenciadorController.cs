using Gerenciador.Application.UseCase.Tarefas.Delete;
using Gerenciador.Application.UseCase.Tarefas.GetAll;
using Gerenciador.Application.UseCase.Tarefas.GetById;
using Gerenciador.Application.UseCase.Tarefas.Register;
using Gerenciador.Application.UseCase.Tarefas.Update;
using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GerenciadorController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ErrorsListJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestTarefaJson request)
    {
        var useCase = new RegisterTarefaUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty ,response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseGetAllTarefasJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorsListJson), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTarefasUseCase();

        var response = useCase.Execute();

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseGetByIdJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorsListJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var useCase = new GetTarefaByIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(updateTarefaUseCase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorsListJson), StatusCodes.Status404NotFound)]
    public IActionResult Update(int id, [FromBody] RequestTarefaJson request)
    {
        var useCase = new updateTarefaUseCase();

        var response = useCase.Execute(id, request);

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(DeleteTarefaUseCase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorsListJson), StatusCodes.Status404NotFound)]
    public IActionResult Update(int id)
    {
        var useCase = new DeleteTarefaUseCase();

        var response = useCase.Execute(id);

        return Ok(response);
    }
}
