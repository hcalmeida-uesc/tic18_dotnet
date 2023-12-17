using FluentValidation;

namespace CleanArchitecture.Application.UseCases.DeleteUser;
public sealed class DeleteUserValidator : AbstractValidator<DeleteUserRequest>
{
   public DeleteUserValidator()
   {
      RuleFor(x => x.ID).NotEmpty().NotEqual(Guid.Empty);
   }

}
