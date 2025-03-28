using Gerenciador.Communication.Responses;

namespace Gerenciador.Application.UseCase.Tarefas.GetAll;
public class GetAllTarefasUseCase
{
    public List<ResponseGetAllTarefasJson> Execute()
    {
        return new List<ResponseGetAllTarefasJson>
        {
            new ResponseGetAllTarefasJson
            {
                Name = "Academia",
                Prioridade = Communication.Enums.PrioridadeGerenciador.Baixa,
                Status = Communication.Enums.GerenciadorStatus.Aguardando
            },

            new ResponseGetAllTarefasJson
            {
                Name = "Estudar",
                Prioridade = Communication.Enums.PrioridadeGerenciador.Alta,
                Status = Communication.Enums.GerenciadorStatus.Concluida
            }
        };
    }
}
