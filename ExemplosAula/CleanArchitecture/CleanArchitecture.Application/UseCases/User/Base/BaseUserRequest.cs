using MediatR;

namespace CleanArchitecture.Application.UseCases;
public class BaseUserRequest : IRequest<BaseUserResponse>{
   public string Email { get; init;}
   public string Name { get; init;}

   public BaseUserRequest(string email, string name)
   {
      Email = email;
      Name = name;
   }
}
