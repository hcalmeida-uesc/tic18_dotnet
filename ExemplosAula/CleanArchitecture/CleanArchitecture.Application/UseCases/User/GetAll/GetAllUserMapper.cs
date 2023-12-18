using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases;
public sealed class GetAllUserMapper : Profile
{
   public GetAllUserMapper()
   {
      CreateMap<User, BaseUserResponse>();
   }

}
