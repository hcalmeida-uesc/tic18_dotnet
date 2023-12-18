using FluentValidation;
using MediatR;

namespace CleanArchitecture.Application.Shared.Behavior;
public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
   where TRequest : IRequest<TResponse>
{
   private readonly IEnumerable<IValidator<TRequest>> _validators;
   
   public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
   {
      _validators = validators;
   }
   public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
   {
      if(!_validators.Any())
      {
         return await next();
      }

      var context = new ValidationContext<TRequest>(request);

      if(_validators.Any())
      {
         var validationResults = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
         var failures = validationResults.SelectMany(r => r.Errors).Where(f => f != null).ToList();

         if(failures.Count != 0)
         {
            throw new FluentValidation.ValidationException(String.Join("\n",failures.Select(f => f.ErrorMessage).ToList()));
         }
      }
      return await next();
   }
}
