using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;

namespace TechMed.Application.Services.Interfaces;
public interface ILoginService
{
   LoginViewModel? Authenticate(LoginInputModel login);
}
