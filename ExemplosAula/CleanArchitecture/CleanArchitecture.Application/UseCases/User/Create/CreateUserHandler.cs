using AutoMapper;
using MediatR;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.UseCases;
public sealed class CreateUserHandler : BaseUserHandler,IRequestHandler<BaseUserRequest, BaseUserResponse>
{
    public CreateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper) : base(unitOfWork, userRepository, mapper)
    {}

    public async Task<BaseUserResponse> Handle(BaseUserRequest request, CancellationToken cancellationToken)
   {
      var user = _mapper.Map<User>(request);
      _userRepository.Create(user);
      await _unitOfWork.Commit(cancellationToken);
      return _mapper.Map<BaseUserResponse>(user);
   }
}
