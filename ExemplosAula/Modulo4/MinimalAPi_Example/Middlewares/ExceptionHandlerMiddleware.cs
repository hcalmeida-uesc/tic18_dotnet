using System.Text;

namespace Modelo4.Middlewares;
public class ExceptionHandlerMiddleware
{
      private readonly RequestDelegate _next;
      public ExceptionHandlerMiddleware(RequestDelegate next)
      {
         _next = next;
      }
      public async Task Invoke(HttpContext context)
      {
         try
         {
               await _next(context);
         }
         catch (Exception ex)
         {
               context.Response.StatusCode = 200;
               var strBuilder = new StringBuilder();
               strBuilder.Append("<h1>Erro</h1>");
               strBuilder.Append($"<h2>{ex.Message}</h2>");
               strBuilder.Append($"<h3>{ex.Source}</h3>");
               await context.Response.WriteAsync(strBuilder.ToString());
         }
      }
}
