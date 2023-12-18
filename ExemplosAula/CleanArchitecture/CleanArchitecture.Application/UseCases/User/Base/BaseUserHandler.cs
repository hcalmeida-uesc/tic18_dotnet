using AutoMapper;
using MediatR;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases;
public abstract class BaseUserHandler
{
   protected readonly IUnitOfWork _unitOfWork;
   protected readonly IUserRepository _userRepository;
   protected readonly IMapper _mapper;

   public BaseUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper){
      _unitOfWork = unitOfWork;
      _userRepository = userRepository;
      _mapper = mapper;
   }
}
