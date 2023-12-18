using MediatR;

namespace CleanArchitecture.Application.UseCases;
public sealed record DeleteUserRequest(Guid ID): IRequest<BaseUserResponse>;
