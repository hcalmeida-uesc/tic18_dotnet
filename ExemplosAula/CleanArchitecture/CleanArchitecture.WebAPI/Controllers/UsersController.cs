using CleanArchitecture.Application.UseCases.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace CleanArchitecture.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
   private readonly IMediator _mediator;

   public UsersController(IMediator mediator)
   { 
      _mediator = mediator;
   }

   [HttpPost]
   public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request, CancellationToken cancellationToken)
   {
      
      var response = await _mediator.Send(request, cancellationToken);
      return Ok(response);
   }

}
