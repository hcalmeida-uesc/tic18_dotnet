using Microsoft.AspNetCore.Server.IIS.Core;

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

         if(context.Request.Query.ContainsKey("exception"))
         {
            var erro = context.Request.Query["exception"];
            throw new Exception(erro);
         }
         
         context.Response.Headers.Add("X-Cliente-Info", $"{time} - {ip}");
         await _next(context);
      }
}
