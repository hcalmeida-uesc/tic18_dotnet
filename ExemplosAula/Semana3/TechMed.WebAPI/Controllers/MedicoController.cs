using Microsoft.AspNetCore.Mvc;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/medicos")]
public class MedicoController : ControllerBase
{
   [HttpGet]
   public IActionResult Get()
   {
      var medico = Enumerable.Range(1, 5).Select(index => new Medico
        {
            Nome = $"Medico {index}"
        })
        .ToArray();
      return Ok(medico);
   }
}
