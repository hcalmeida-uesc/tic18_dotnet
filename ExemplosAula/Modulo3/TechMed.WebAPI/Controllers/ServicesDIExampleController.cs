using Microsoft.AspNetCore.Mvc;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class ServicesDIExampleController : ControllerBase
{
   private readonly ServiceTransient _firstServiceTransient;
   private readonly ServiceTransient _secondServiceTransient;
   public ServicesDIExampleController(ServiceTransient firstServiceTransient, ServiceTransient secondServiceTransient)
   {
      _firstServiceTransient = firstServiceTransient;
      _secondServiceTransient = secondServiceTransient;
   }

   [HttpGet("services")]
   public IActionResult Get()
   {
      var message = "abra outra aba e acesse novamente essa rota";
      var response = new
      {
         message,
         _firstServiceTransient,
         _secondServiceTransient
      };
      return Ok(response);
   }
}
