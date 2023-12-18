using MediatR;

namespace CleanArchitecture.Application.UseCases;
public sealed record GetAllUserRequest : IRequest<List<BaseUserResponse>>;
