using Gerenciador.Communication.Enums;

namespace Gerenciador.Communication.Responses;
public class ResponseGetByIdJson
{
    public int id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PrioridadeGerenciador Prioridade { get; set; }
    public DateOnly DataLimite { get; set; }
    public GerenciadorStatus Status { get; set; }
}
