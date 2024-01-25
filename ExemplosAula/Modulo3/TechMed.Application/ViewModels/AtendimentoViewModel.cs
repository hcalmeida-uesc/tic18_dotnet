namespace TechMed.Application.ViewModels
{
   public class AtendimentoViewModel
   {
      public int AtendimentoId { get; set; }
      public DateTime DataHora { get; set; }
      public PacienteViewModel Paciente { get; set; } = null!;
      public MedicoViewModel Medico { get; set; } = null!;
   }
}
