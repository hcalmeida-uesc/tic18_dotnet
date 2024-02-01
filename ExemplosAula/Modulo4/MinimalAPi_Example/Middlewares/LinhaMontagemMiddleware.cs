namespace Modulo4.LinhaDeMontagem;
public class AddChassiMiddleware
{
    private readonly RequestDelegate _next;
    public AddChassiMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        await context.Response.WriteAsync("Chassi adicionado\n");
        await _next(context);
    }
}

public class AddMotorMiddleware
{
    private readonly RequestDelegate _next;
    public AddMotorMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Motor adicionado\n");
        await _next(context);
    }
}

public class AddPortasMiddleware
{
    private readonly RequestDelegate _next;
    public AddPortasMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Portas adicionadas\n");
        await _next(context);
    }
}

public class AddPinturaMiddleware
{
    private readonly RequestDelegate _next;
    public AddPinturaMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        await context.Response.WriteAsync("Pintura adicionada\n");
        await _next(context);
    }
}
public class AddInternoMiddleware
{
    private readonly RequestDelegate _next;
    public AddInternoMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context, LinhaDeMontagemDescricao descricao)
    {
        await context.Response.WriteAsync("Acabarmento interno adicionado\n");
    }
}

public class LinhaDeMontagemDescricao
{
    List <string> descricao = new List<string>();
}
