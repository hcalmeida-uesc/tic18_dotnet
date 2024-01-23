using Microsoft.AspNetCore.Mvc;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class AtendimentoController : ControllerBase
{
   private readonly IAtendimentoCollection _atendimentos;
   public List<Atendimento> Atendimentos => _atendimentos.GetAll().ToList();
   public AtendimentoController(ITechMedContext context) => _atendimentos = context.AtendimentosCollection;
   [HttpGet("atendimentos")]
   public IActionResult Get()
   {
      return Ok(Atendimentos);

   }



}
