using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data.Interfaces;
public interface IMedicoCollection
{  
   void Create(Medico medico);
   ICollection<Medico> GetAll();
   Medico? GetById(int id);
   void Update(int id, Medico medico);
   void Delete(int id);
}
