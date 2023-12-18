using MediatR;

namespace CleanArchitecture.Application.UseCases;
public sealed class UpdateUserRequest : BaseUserRequest, IRequest<BaseUserResponse>{
   public Guid ID { get; init;}
   
   public UpdateUserRequest(Guid id, string email, string name) : base(email, name)
   {
      ID = id;
   }
}
