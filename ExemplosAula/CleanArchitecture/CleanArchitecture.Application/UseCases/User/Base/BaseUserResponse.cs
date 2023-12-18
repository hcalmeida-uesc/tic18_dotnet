namespace CleanArchitecture.Application.UseCases;

public class BaseUserResponse
{
      public Guid Id { get; init; }
      public string? Email { get; init; }
      public string? Name { get; init; }
}
