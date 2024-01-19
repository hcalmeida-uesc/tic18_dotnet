using TechMed.WebAPI.Infra.Data.Interfaces;
using TechMed.WebAPI.Infra.Data;
public class DatabaseFake : IDatabaseFake
{
   public IMedicoCollection MedicosCollection { get; } = new MedicosDB();
   public IPacienteCollection PacientesCollection { get; } = new PacientesDB();
   public IAtendimentoCollection AtendimentosCollection { get; } = new AtendimentosDB();
}
