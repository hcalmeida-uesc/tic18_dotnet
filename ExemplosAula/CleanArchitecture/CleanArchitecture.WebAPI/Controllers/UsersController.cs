using CleanArchitecture.Application.UseCases.CreateUser;
using CleanArchitecture.Application.UseCases.DeleteUser;
using CleanArchitecture.Application.UseCases.GetAllUser;
using CleanArchitecture.Application.UseCases.UpdateUser;
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

   [HttpGet]
   public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
   {
      var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
      return Ok(response);
   }

   [HttpPost]
   public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request, CancellationToken cancellationToken)
   {
      
      var response = await _mediator.Send(request, cancellationToken);
      return Ok(response);
   }

   [HttpPut("{id}")]
   public async Task<ActionResult<UpdateUserResponse>> Update(Guid id, UpdateUserRequest request, CancellationToken cancellationToken)
   {
      if(id != request.ID)
      {
         return BadRequest("Id and request.Id must be the same");
      }
      var response = await _mediator.Send(request, cancellationToken);
      return Ok(response);
   }

   [HttpDelete("{id}")]
   public async Task<ActionResult<DeleteUserResponse>> Delete(Guid? id, CancellationToken cancellationToken)
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
