using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class OpeningTimeController : ControllerBase
{
      private readonly OpeningTime _openingTime;
   
      public OpeningTimeController(IOptions<OpeningTime> openingTime)
      {
         _openingTime = openingTime.Value;
      }
   
      [HttpGet]
      [Route("openingtime")]
      public IActionResult Get()
      {
         return Ok(_openingTime);
      }
}
