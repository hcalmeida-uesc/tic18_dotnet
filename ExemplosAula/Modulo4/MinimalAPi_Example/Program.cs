using System.Text;
using Middleware.Extensions;
using Modulo4.LinhaDeMontagem;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<LinhaDeMontagemDescricao>();

var app = builder.Build();
//app.UseHttpsRedirection();
app.Map("/erro", HandleMapTest1);

app.UseExceptionHandlerMiddleware();
app.UseRequisicaoInfoMiddleware();
app.UseClienteInfoMiddleware();
app.UseAddChassiMiddleware();
app.UseAddMotorMiddleware();
app.UseMiddleware<AddPortasMiddleware>();
app.UseMiddleware<AddPinturaMiddleware>();
app.UseMiddleware<AddInternoMiddleware>();

// app.Use(async (context, next) =>
// {
//     context.Response.ContentType = "text/html; charset=utf-8";
//     context.Response.StatusCode = 200;
//     var strBuilder = new StringBuilder();
//     strBuilder.Append("<h1>Linha de Montagem</h1>");
//     strBuilder.Append($"<h2>Montagem do carro finalizada</h2>");
//     await context.Response.WriteAsync(strBuilder.ToString());
//     await next.Invoke();
// });


app.Run(async context =>
{
    await context.Response.WriteAsync("");
});


app.Run();

static void HandleMapTest1(IApplicationBuilder app)
{
    app.Run(async context =>
    {
         var strBuilder = new StringBuilder();
         strBuilder.Append("<h1>Erro</h1>");
         strBuilder.Append($"<h2>Erro ao montar o carro</h2>");
         await context.Response.WriteAsync(strBuilder.ToString());
    });
}
