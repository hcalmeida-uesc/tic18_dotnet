using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Core.Exceptions;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Application.Services;
public class AtendimentoService : BaseService, IAtendimentoService
{
   private readonly IMedicoService _medicoService;
   private readonly IPacienteService _pacienteService;
   public AtendimentoService(ITechMedContext context, IMedicoService medicoService, IPacienteService pacienteService) : base(context)
   {
      _medicoService = medicoService;
      _pacienteService = pacienteService;
   }
   public int Create(NewAtendimentoInputModel atendimento)
   {
      return _medicoService.CreateAtendimento(atendimento.MedicoId, atendimento);
   }
   public List<AtendimentoViewModel> GetAll()
   {
      return _context.AtendimentosCollection.GetAll().Select(a => new AtendimentoViewModel
      {
         AtendimentoId = a.AtendimentoId,
         DataHora = a.DataHora,
         Medico = new MedicoViewModel
         {
            MedicoId = a.Medico.MedicoId,
            Nome = a.Medico.Nome
         },
         Paciente = new PacienteViewModel
         {
            PacienteId = a.Paciente.PacienteId,
            Nome = a.Paciente.Nome
         }
      }).ToList();
   }

   public AtendimentoViewModel? GetById(int id)
   {
      var atendimentoDB = _context.AtendimentosCollection.GetById(id);
      if (atendimentoDB is null)
         throw new AtendimentoNotFoundException();
      
      var medicoVM = _medicoService.GetById(atendimentoDB.Medico.MedicoId);
      var pacienteVM = _pacienteService.GetById(atendimentoDB.Paciente.PacienteId);
      
      if (medicoVM is null || pacienteVM is null)
         return null;

      return new AtendimentoViewModel{
         AtendimentoId = atendimentoDB.AtendimentoId,
         DataHora = atendimentoDB.DataHora,
         Medico = medicoVM,
         Paciente = pacienteVM
      };
      
   }
    public List<AtendimentoViewModel> GetByMedicoId(int medicoId)
    {
        throw new NotImplementedException();
    }

    public List<AtendimentoViewModel> GetByPacienteId(int pacienteId)
    {
        throw new NotImplementedException();
    }
}
