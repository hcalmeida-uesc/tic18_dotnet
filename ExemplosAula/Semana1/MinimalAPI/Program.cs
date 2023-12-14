
using Semana1.Domain;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/helder/", () => User.View());

app.Run();
