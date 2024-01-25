using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;

namespace TechMed.Application.Services.Interfaces;
public interface IAtendimentoService
{
   public List<AtendimentoViewModel> GetAll();
   public List<AtendimentoViewModel> GetByPacienteId(int pacienteId);
   public List<AtendimentoViewModel> GetByMedicoId(int medicoId);
   public int Create(NewAtendimentoInputModel atendimento);
}
