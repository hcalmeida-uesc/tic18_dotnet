using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;

namespace TechMed.Application.Services.Interfaces;
public interface IExameService
{
   public List<ExameViewModel> GetAll();
   public int Create(NewExameInputModel exame);
}
