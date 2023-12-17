using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.CreateUser;
public sealed class CreateUserMapper : Profile
{
   public CreateUserMapper()
   {
      CreateMap<CreateUserRequest, User>();
      CreateMap<User, CreateUserResponse>();
   }

}
