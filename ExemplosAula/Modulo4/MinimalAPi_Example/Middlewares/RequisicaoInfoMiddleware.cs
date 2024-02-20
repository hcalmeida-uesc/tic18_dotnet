using System.Diagnostics;

namespace Modulo4.Middlewares;
public class RequisicaoInfoMiddleware
{
   private readonly RequestDelegate _next;
   public RequisicaoInfoMiddleware(RequestDelegate next)
   {
      _next = next;
   }
   public async Task Invoke(HttpContext context)
   {
      var clock = new Stopwatch();
      clock.Start();
      await _next(context);
      clock.Stop();
      var ticks = clock.ElapsedTicks;
      var miliseconds = clock.ElapsedMilliseconds;
      var microseconds = (ticks / 1000);
      await context.Response.WriteAsync($"<br><br>Tempo de resposta: {miliseconds}ms ou {microseconds}µs");
   }
}
