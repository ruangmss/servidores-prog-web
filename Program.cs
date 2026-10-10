
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    comandos = new[]
    {
        "Instalação do .NET",
        "Instalação da extensão C# no VS Code",
        "Não é necessário nenhum código para resgatar os arquivos necessários",
        "dotnet run é o comando para inicializar o app"
    },

    conclusao = new[]
    {
        "A principal dificuldade do grupo foi a configuração do ambiente",
        "A principal recomendação é se atentar ao modo como o código funciona, pois é uma linguagem de compilação, ou seja, é necessário encerrar e inicializá-lo novamente para atualizá-lo."
    }
});

app.Run();
