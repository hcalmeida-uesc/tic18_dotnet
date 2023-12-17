namespace CleanArchitecture.WebAPI.Extensions;
public static class CorsPolicyExtensions
{
   public static void ConfigureCorsPolicy(this IServiceCollection services)
   {
      services.AddCors(options =>
      {
         options.AddDefaultPolicy(builder => builder
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
      });
   }
}
