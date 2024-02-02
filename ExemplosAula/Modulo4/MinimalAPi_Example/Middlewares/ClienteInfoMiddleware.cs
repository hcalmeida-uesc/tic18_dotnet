namespace Modulo4.Middlewares;
public class ClienteInfoMiddleware
{
      private readonly RequestDelegate _next;
      public ClienteInfoMiddleware(RequestDelegate next)
      {
         _next = next;
      }
      public async Task Invoke(HttpContext context)
      {
         var time = DateTimeOffset.Now;
         var ip = context.Connection.RemoteIpAddress;
         
         context.Response.Headers.Add("X-Cliente-Info", $"{time} - {ip}");
         await _next(context);
      }
}
