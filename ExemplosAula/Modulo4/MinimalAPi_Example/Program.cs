using Modulo4.ExampleMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.UseHttpsRedirection();

app.UseExampleMiddleware();

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello, World!\n");
});

app.Run();
