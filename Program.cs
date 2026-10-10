
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
        vantagens = new[]
    {
        "- Desempenho de alto nível.",
        "- Linguagem moderna com tipagem forte",
        "- Forte presença no mercado corporativo"
    },

    exemploDeCaso = "Em C# e .NET Core, um Caso de Uso (Use Case) ideal segue os princípios da Clean Architecture (Arquitetura Limpa). Ele deve representar uma única ação de negócio, ser completamente isolado de frameworks (como banco de dados ou APIs) e ser facilmente testável",

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
