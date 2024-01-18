namespace TechMed.WebAPI.Model;

public class Medico : Pessoa{
    public int MedicoId {get; set;}
    // public required string CRM {get; set;}
    // public string? Especialidade {get; set;}
    // public decimal? Salario {get; set;}
    public ICollection<Atendimento>? Atendimentos {get;}
}
