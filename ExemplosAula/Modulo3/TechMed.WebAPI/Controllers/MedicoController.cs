using Microsoft.AspNetCore.Mvc;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class MedicoController : ControllerBase
{
   [HttpGet("medicos")]
   public IActionResult Get()
   {
      var medico = Enumerable.Range(1, 5).Select(index => new Medico
        {
            MedicoId = index,
            Nome = $"Medico {index}"
        })
        .ToArray();
      return Ok(medico);
   }

   [HttpGet("medico/{id}")]
   public IActionResult GetById(int id)
   {
      var medico = new Medico
      {
         MedicoId = id,
         Nome = $"Medico {id}"
      };
      return Ok(medico);
   }

   [HttpPost("medico")]
   public IActionResult Post([FromBody] Medico medico)
   {
      return CreatedAtAction(nameof(GetById), new { id = 1 }, medico);
   }

   [HttpPut("medico/{id}")]
   public IActionResult Put(int id, [FromBody] Medico medico)
   {
      //TODO: Buscar um medico pelo id e atualizar os dados
      // caso não encontre, retorna NotFound()
      return NoContent();
   }

   [HttpDelete("medico/{id}")]
   public IActionResult Delete(int id)
   {
      //TODO: Buscar um medico pelo id e apagar
      // caso não encontre, retorna NotFound()
      return NoContent();
   }

   [HttpGet("medico/{id}/atendimentos")]
   public IActionResult GetAtendimentos(int id)
   {
      var atendimento = Enumerable.Range(1, 5).Select(index => new Atendimento
        {
            AtendimentoId = index,
            DataHora = DateTime.Now,
            MedicoId = id,
            Medico = new Medico
            {
                MedicoId = id,
                Nome = $"Medico {id}"
            }
        })
        .ToArray();
      return Ok(atendimento);
   }
}
