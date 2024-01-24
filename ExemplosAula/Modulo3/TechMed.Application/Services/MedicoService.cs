using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Application.Services;
public class MedicoService : IMedicoService
{
  private readonly ITechMedContext _context;
  public MedicoService(ITechMedContext context)
  {
    _context = context;
  }

  public int Create(NewMedicoInputModel medico)
  {
    return _context.MedicosCollection.Create(new Medico{
      Nome = medico.Nome
      });

  }

  public void Delete(int id)
  {
    _context.MedicosCollection.Delete(id);
  }

  public List<MedicoViewModel> GetAll()
  {
    var medicos = _context.MedicosCollection.GetAll().Select(m => new MedicoViewModel{
      MedicoId = m.MedicoId,
      Nome = m.Nome
    }).ToList();

    return medicos;

  }

  public MedicoViewModel? GetByCrm(string crm)
  {
    throw new NotImplementedException();
  }

  public MedicoViewModel? GetById(int id)
  {
    var medico = _context.MedicosCollection.GetById(id);
    
    if(medico is null)
      return null;

    var MedicoViewModel = new MedicoViewModel{
      MedicoId = medico.MedicoId,
      Nome = medico.Nome
    };
    return MedicoViewModel;
  }

  public void Update(int id, NewMedicoInputModel medico)
  {
    _context.MedicosCollection.Update(id, new Medico{
      Nome = medico.Nome
    });
  }
}
