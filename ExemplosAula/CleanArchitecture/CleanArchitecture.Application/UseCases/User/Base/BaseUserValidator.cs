using FluentValidation;

namespace CleanArchitecture.Application.UseCases;
public sealed class BaseUserValidator : AbstractValidator<BaseUserRequest>
{
   public BaseUserValidator()
   {
      RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
      RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
   }

}
