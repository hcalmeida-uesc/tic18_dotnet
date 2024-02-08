using Microsoft.AspNetCore.Mvc;
using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;

namespace TechMed.WebAPI.Controllers;


[ApiController]
[Route("/api/v0.1/")]
public class LoginController : ControllerBase
{
   private readonly ILoginService _loginService;
   public LoginController(ILoginService service)
   {
      _loginService = service;
   } 

   [HttpPost("login")]
   public IActionResult Post([FromBody] LoginInputModel login)
   {
      var result = _loginService.Authenticate(login);
      if (result is not null)
         return Ok(result);
      else
         return BadRequest("Usuário ou senha inválidos");
   }
}

