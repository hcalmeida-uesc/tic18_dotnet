using AutoMapper;
using MediatR;
using CleanArchitecture.Domain.Interfaces;


namespace CleanArchitecture.Application.UseCases;
public sealed class GetAllUserHandler : IRequestHandler<GetAllUserRequest, List<BaseUserResponse>>
{
   private readonly IUserRepository _userRepository;
   private readonly IMapper _mapper;

   public GetAllUserHandler(IUserRepository userRepository, IMapper mapper){
      _userRepository = userRepository;
      _mapper = mapper;
   }
   public async Task<List<BaseUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
   {
      var users = await _userRepository.GetAll(cancellationToken);
      
      return _mapper.Map<List<BaseUserResponse>>(users);
   }
}
