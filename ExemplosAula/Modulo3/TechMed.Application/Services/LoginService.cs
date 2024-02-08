using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Auth;

namespace TechMed.Application.Services;
public class LoginService : ILoginService
{
   private readonly IAuthService _authService;
   public LoginService(IAuthService authService)
   {
      _authService = authService;
   }
   public LoginViewModel? Authenticate(LoginInputModel login)
   {
      string _token = "";
      var _passHashed = _authService.ComputeSha256Hash(login.Password);

      if (login.Username == "admin" && _passHashed == _authService.ComputeSha256Hash("admin"))
         _token = _authService.GenerateJwtToken(login.Username, "Admin");
      
      else if (login.Username == "medico" && _passHashed == _authService.ComputeSha256Hash("medico"))
         _token = _authService.GenerateJwtToken(login.Username, "Medico");
      
      else if (login.Username == "paciente" && _passHashed == _authService.ComputeSha256Hash("paciente"))
         _token = _authService.GenerateJwtToken(login.Username, "Paciente");

      if (_token != ""){
         return new LoginViewModel
         {
            Username = login.Username,
            Token = _token
         };
      }

      return null;

   }
}


