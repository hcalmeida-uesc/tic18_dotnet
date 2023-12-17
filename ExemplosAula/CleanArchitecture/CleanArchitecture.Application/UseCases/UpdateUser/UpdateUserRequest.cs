using MediatR;

namespace CleanArchitecture.Application.UseCases.UpdateUser;
public sealed record UpdateUserRequest(Guid ID, string Email, string Name): IRequest<UpdateUserResponse>;
