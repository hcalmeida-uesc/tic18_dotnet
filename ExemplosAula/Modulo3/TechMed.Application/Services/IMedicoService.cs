namespace TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
public interface IMedicoService
{
      public List<OutMedico> GetAll();
      public OutMedico GetById(int id);
      public OutMedico GetByCrm(string crm);
      public void Create(NewMedico medico);
      public void Update(int id, NewMedico medico);
      public void Delete(int id);
}
