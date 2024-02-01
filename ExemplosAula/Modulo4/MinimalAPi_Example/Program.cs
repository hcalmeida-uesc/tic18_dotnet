using Modulo4.ExampleMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.UseExampleMiddleware();

//app.UseMiddleware<ExampleMiddleware>();

app.Run();
