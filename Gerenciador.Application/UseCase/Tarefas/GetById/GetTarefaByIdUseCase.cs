using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCase.Tarefas.GetById;
public class GetTarefaByIdUseCase
{
    public ResponseGetByIdJson Execute(int id)
    {
        return new ResponseGetByIdJson
        {
            id = id,
            Name = "Academia",
            Description = "Ir para a academia treinar peito",
            Prioridade = 0,
            Status = Communication.Enums.GerenciadorStatus.EmAndamento,
            DataLimite = new DateOnly(year: 2025, month: 03, day: 28)
        };
    }
}
