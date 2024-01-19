namespace TechMed.WebAPI.Model;

public class Paciente : Pessoa{
   public int PacienteId {get; set;}
    // public string? Endereco {get; set;}
    // public string? Telefone {get; set;}
    public ICollection<Atendimento>? Atendimentos {get;}
}
