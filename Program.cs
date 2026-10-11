var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    secao1 = new
    {
        vantagens = new[]
        {
            "Alto desempenho.",
            "C# com tipagem forte.",
            "Compatível com Windows, Linux e macOS."
        },
        casoDeUsoIdeal = "API de pedidos para um sistema de comércio eletrônico."
    },
    secao2 = new
    {
        software = ".NET SDK 10",
        instalacao = "Baixe e instale o .NET SDK 10 do site oficial da Microsoft. A instalação é feita diretamente através de interface gráfica, sem necessidade de linha de comando.",
    },
    secao3 = new
    {
        codigoFonte = File.ReadAllText(Path.Combine(app.Environment.ContentRootPath, "Program.cs")),
        comandoServidor = "dotnet run",
        explicacao = "Execute dotnet run na pasta do projeto para compilar e iniciar o servidor."
    },
    secao4 = new
    {
        dificuldadeInicial = "Configurar o ambiente de desenvolvimento.",
        recomendacaoDoGrupo = "Recomendamos atentar-se à compilação para verificar as alterações no código e garantir que o servidor esteja funcionando corretamente."
    }
});

app.Run();
