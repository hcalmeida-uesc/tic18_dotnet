namespace TechMed.Infrastructure.Persistence.Interfaces;
public interface IBaseCollection<T>
{  
   int Create(T obj);
   ICollection<T> GetAll();
   T? GetById(int id);
   void Update(int id, T obj);
   void Delete(int id);
}
