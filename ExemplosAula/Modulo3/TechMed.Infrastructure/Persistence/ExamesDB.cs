using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence;
public class ExamesDB : IExameCollection
{
    private readonly List<Exame> _exames = new List<Exame>();
   private int _id = 0;  
    public int Create(Exame exame)
    {
        if(_exames.Count > 0)
         _id = _exames.Max(m => m.ExameId);
      exame.ExameId = ++_id;
      _exames.Add(exame);
      return exame.ExameId;
    }

    public void Delete(int id)
    {
        _exames.RemoveAll(m => m.ExameId == id);
    }

    public ICollection<Exame> GetAll()
    {
        return _exames.ToArray();
    }

    public Exame? GetById(int id)
    {
        return _exames.FirstOrDefault(m => m.ExameId == id);
    }

    public void Update(int id, Exame obj)
    {
        var exameDB = _exames.FirstOrDefault(m => m.ExameId == id);
        if(exameDB is not null)
        {
            exameDB.DataHora = obj.DataHora;
            exameDB.Nome = obj.Nome;
        }
    }
}
