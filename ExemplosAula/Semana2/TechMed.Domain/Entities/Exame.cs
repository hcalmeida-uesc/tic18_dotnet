namespace TechMed.Domain.Entities;

public class Exame{
    public int ExameId {get; set;}
    public string Local {get; set;}
    public DateTime DataHora {get; set;}
    public ICollection<Atendimento>? Atendimentos {get; set;}
}
