using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data.Interfaces;
public interface IBaseCollection<T>
{  
   void Create(T obj);
   ICollection<T> GetAll();
   T? GetById(int id);
   void Update(int id, T obj);
   void Delete(int id);
}
