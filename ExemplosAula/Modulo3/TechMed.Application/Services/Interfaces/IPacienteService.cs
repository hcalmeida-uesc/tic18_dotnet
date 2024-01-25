namespace TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
public interface IPacienteService
{
      public List<PacienteViewModel> GetAll();
      public PacienteViewModel? GetById(int id);
      public int Create(NewPacienteInputModel medico);
      public void Update(int id, NewPacienteInputModel medico);
      public void Delete(int id);
}
