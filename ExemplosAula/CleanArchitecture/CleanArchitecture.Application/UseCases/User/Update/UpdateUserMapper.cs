using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases;
public sealed class UpdateUserMapper : Profile
{
   public UpdateUserMapper()
   {
      CreateMap<UpdateUserRequest, User>();
      CreateMap<User, BaseUserResponse>();
   }

}
