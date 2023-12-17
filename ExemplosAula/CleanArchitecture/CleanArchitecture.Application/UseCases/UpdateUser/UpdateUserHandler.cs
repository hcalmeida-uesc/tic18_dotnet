using AutoMapper;
using MediatR;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases.UpdateUser;
public sealed class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
{
   private readonly IUnitOfWork _unitOfWork;
   private readonly IUserRepository _userRepository;
   private readonly IMapper _mapper;

   public UpdateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper){
      _unitOfWork = unitOfWork;
      _userRepository = userRepository;
      _mapper = mapper;
   }
   public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
   {
      var user = _mapper.Map<User>(request);
      _userRepository.Update(user);
      await _unitOfWork.Commit(cancellationToken);
      return _mapper.Map<UpdateUserResponse>(user);
   }
}
