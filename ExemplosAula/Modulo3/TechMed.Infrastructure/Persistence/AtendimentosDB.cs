using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence;
public class AtendimentosDB : IAtendimentoCollection
{
   private readonly List<Atendimento> _atendimentos = new List<Atendimento>();
   private int _id = 0;   
   public int Create(Atendimento atendimento)
   {
      if(_atendimentos.Count > 0)
         _id = _atendimentos.Max(m => m.AtendimentoId);
      atendimento.AtendimentoId = ++_id;
      _atendimentos.Add(atendimento);
      return atendimento.AtendimentoId;
   }
   public void Delete(int id)
   {
      _atendimentos.RemoveAll(m => m.PacienteId == id);
   }
   public ICollection<Atendimento> GetAll()
   {
      return _atendimentos.ToArray();
   }
   public Atendimento? GetById(int id)
   {
      return _atendimentos.FirstOrDefault(m => m.AtendimentoId == id);
   }
   public void Update(int id, Atendimento atendimento)
   {
      var atendimentoDB = _atendimentos.FirstOrDefault(m => m.PacienteId == id);
      if(atendimentoDB is not null)
      {
         atendimentoDB.DataHora = atendimento.DataHora;
      }
   }
}
