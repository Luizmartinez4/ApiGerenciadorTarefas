using Gerenciador.Communication.Requests;
using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCase.Tarefas.Register;

public class RegisterTarefaUseCase
{
    public ResponseCreatedTarefaJson Execute(RequestTarefaJson request)
    {
        return new ResponseCreatedTarefaJson
        {
            Id = 1,
            Name = request.Name,
            Status = request.Status,
            Prioridade = request.Prioridade
        };
    }
}
