using Modelo4.Middlewares;
using Modulo4.LinhaDeMontagem;
using Modulo4.Middlewares;

namespace Middleware.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseAddChassiMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AddChassiMiddleware>();
        }

        public static IApplicationBuilder UseAddMotorMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AddMotorMiddleware>();
        }
        public static IApplicationBuilder UseClienteInfoMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ClienteInfoMiddleware>();
        }

        public static IApplicationBuilder UseRequisicaoInfoMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RequisicaoInfoMiddleware>();
        }
        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
