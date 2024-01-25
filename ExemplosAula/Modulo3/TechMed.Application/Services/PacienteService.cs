using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Application.Services;
public class PacienteService : IPacienteService
{
  private readonly ITechMedContext _context;
  public PacienteService(ITechMedContext context)
  {
    _context = context;
  }

    public int Create(NewPacienteInputModel medico)
    {
        return _context.PacientesCollection.Create(new Paciente{
        Nome = medico.Nome
        });
    }

    public void Delete(int id)
    {
        _context.PacientesCollection.Delete(id);
    }

    public List<PacienteViewModel> GetAll()
    {
        var pacientes = _context.PacientesCollection.GetAll().Select(m => new PacienteViewModel{
        PacienteId = m.PacienteId,
        Nome = m.Nome
        }).ToList();

        return pacientes;
    }

    public PacienteViewModel? GetById(int id)
    {
        var paciente = _context.PacientesCollection.GetById(id);
        
        if(paciente is null)
        return null;

        var PacienteViewModel = new PacienteViewModel{
        PacienteId = paciente.PacienteId,
        Nome = paciente.Nome
        };
        return PacienteViewModel;
    }

    public void Update(int id, NewPacienteInputModel medico)
    {
        _context.PacientesCollection.Update(id, new Paciente{
        Nome = medico.Nome
        });
    }
}
