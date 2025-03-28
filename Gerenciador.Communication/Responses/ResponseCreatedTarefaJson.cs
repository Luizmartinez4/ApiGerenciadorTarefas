using Gerenciador.Communication.Enums;

namespace Gerenciador.Communication.Responses;
public class ResponseCreatedTarefaJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PrioridadeGerenciador Prioridade { get; set; }
    public GerenciadorStatus Status { get; set; }
}
