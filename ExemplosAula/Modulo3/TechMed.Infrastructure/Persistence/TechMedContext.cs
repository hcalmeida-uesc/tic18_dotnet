using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Infrastructure.Persistence;
public class TechMedContext : ITechMedContext, IDatabaseFake
{
   public IMedicoCollection MedicosCollection { get; } = new MedicosDB();
   public IPacienteCollection PacientesCollection { get; } = new PacientesDB();
   public IAtendimentoCollection AtendimentosCollection { get; } = new AtendimentosDB();
}
