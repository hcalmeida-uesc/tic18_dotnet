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
            context.Response.Headers.Add("X-Error", ex.Message);
            context.Response.Redirect("/erro");
         }
      }
}
