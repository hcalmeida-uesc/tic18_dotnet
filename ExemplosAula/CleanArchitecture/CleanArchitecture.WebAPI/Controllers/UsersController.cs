using MediatR;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.UseCases;
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

   [HttpGet]
   public async Task<ActionResult<List<BaseUserResponse>>> GetAll(CancellationToken cancellationToken)
   {
      var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
      return Ok(response);
   }

   [HttpPost]
   public async Task<ActionResult<BaseUserResponse>> Create(BaseUserRequest request, CancellationToken cancellationToken)
   {
      
      var response = await _mediator.Send(request, cancellationToken);
      return Ok(response);
   }

   [HttpPut("{id}")]
   public async Task<ActionResult<BaseUserResponse>> Update(Guid id, UpdateUserRequest request, CancellationToken cancellationToken)
   {
      if(id != request.ID)
      {
         return BadRequest("Id and request.Id must be the same");
      }
      var response = await _mediator.Send(request, cancellationToken);
      return Ok(response);
   }

   [HttpDelete("{id}")]
   public async Task<ActionResult<BaseUserResponse>> Delete(Guid? id, CancellationToken cancellationToken)
   {
      if(id is null)
      {
         return BadRequest("Id must be informed");
      }
      var deleteUserRequest = new DeleteUserRequest(id.Value);

      var response = await _mediator.Send(deleteUserRequest, cancellationToken);
      return Ok(response);
   }

}
