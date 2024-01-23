using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Application.Services;
public class MedicoService : IMedicoService
{ 
   private readonly ITechMedContext _context;
   public MedicoService(ITechMedContext context){
      _context = context;
   }
    public void Create(NewMedico medico)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<OutMedico> GetAll()
    {
      return Map(_context.MedicosCollection.GetAll().ToList());
    }

    public OutMedico GetByCrm(string crm)
    {
        throw new NotImplementedException();
    }

    public OutMedico GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, NewMedico medico)
    {
        throw new NotImplementedException();
    }
    public static OutMedico Map(Medico medico)
    {
      return new OutMedico
      {
        MedicoId = medico.MedicoId,
        Nome = medico.Nome
      };
    }
    
    public static List<OutMedico> Map(List<Medico> medicos)
    {
      return medicos.Select(medico => Map(medico)).ToList();
    }
}
