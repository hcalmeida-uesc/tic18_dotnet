namespace TechMed.Infrastructure.Persistence.Interfaces;
public interface IDatabaseFake
{
   public IMedicoCollection MedicosCollection { get; }
   public IPacienteCollection PacientesCollection { get; }
   public IAtendimentoCollection AtendimentosCollection { get; }
   public IExameCollection ExamesCollection { get; }
}
