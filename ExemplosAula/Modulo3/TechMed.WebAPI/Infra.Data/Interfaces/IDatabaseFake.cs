namespace TechMed.WebAPI.Infra.Data.Interfaces;
public interface IDatabaseFake
{
   public IMedicoCollection MedicosCollection { get; }
   public IPacienteCollection PacientesCollection { get; }
   public IAtendimentoCollection AtendimentosCollection { get; }
}
