
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    mensagem = "Minha primeira API em C#!",
    linguagem = "C#",
    framework = "ASP.NET Core",
    status = "Funcionando"
});

app.Run();
