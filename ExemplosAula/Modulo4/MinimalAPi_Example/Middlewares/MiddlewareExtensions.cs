using Modulo4.LinhaDeMontagem;

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
    }
}
