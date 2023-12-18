using AutoMapper;
using MediatR;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases;
public sealed class DeleteUserHandler : IRequestHandler<DeleteUserRequest, BaseUserResponse>
{
   private readonly IUnitOfWork _unitOfWork;
   private readonly IUserRepository _userRepository;
   private readonly IMapper _mapper;

   public DeleteUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper){
      _unitOfWork = unitOfWork;
      _userRepository = userRepository;
      _mapper = mapper;
   }
   public async Task<BaseUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
   {
      var user = await _userRepository.Get(request.ID, cancellationToken);
      if(user is null){
         throw new Exception($"User {nameof(User)}, with Id '{request.ID}' not found.");
      }
      _userRepository.Delete(user);
      await _unitOfWork.Commit(cancellationToken);
      return _mapper.Map<BaseUserResponse>(user);
   }
}
