namespace TechMed.WebAPI.Model;
public class Atendimento
{
    public int AtendimentoId { get; set; }
    public DateTime DataHora { get; set; }
    public int MedicoId { get; set; }
    public required Medico Medico { get; set; }
    public int PacienteId { get; set; }
    public required Paciente Paciente {get; set;}
    //public ICollection<Exame>? Exames {get;set;}
}
