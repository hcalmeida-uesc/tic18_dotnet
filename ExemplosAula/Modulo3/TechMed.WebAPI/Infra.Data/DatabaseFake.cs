using TechMed.WebAPI.Infra.Data.Interfaces;
using TechMed.WebAPI.Infra.Data;
public class DatabaseFake : IDatabaseFake
{
   public IMedicoCollection Collection { get; } = new MedicosDB();
}
