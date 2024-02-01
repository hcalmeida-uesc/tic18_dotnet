using Modulo4.LinhaDeMontagem;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddScoped<LinhaDeMontagemDescricao>();

//app.UseHttpsRedirection();

app.UseMiddleware<AddChassiMiddleware>();
app.UseMiddleware<AddMotorMiddleware>();
app.UseMiddleware<AddPortasMiddleware>();
app.UseMiddleware<AddPinturaMiddleware>();
app.UseMiddleware<AddInternoMiddleware>();

app.Run();
