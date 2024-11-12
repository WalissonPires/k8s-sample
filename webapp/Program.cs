var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", async () =>
{
    var page = await File.ReadAllTextAsync("wwwroot/index.html");
    page = page.Replace("{{Host}}", System.Environment.MachineName);

    return Results.Content(page, "text/html");
});

app.UseStaticFiles();

app.Run();