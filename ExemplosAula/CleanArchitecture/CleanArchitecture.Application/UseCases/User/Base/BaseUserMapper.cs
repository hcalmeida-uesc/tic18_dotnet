using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases;
public sealed class BaseUserMapper : Profile
{
   public BaseUserMapper()
   {
      CreateMap<BaseUserRequest, User>();
      CreateMap<User, BaseUserResponse>();
   }

}
