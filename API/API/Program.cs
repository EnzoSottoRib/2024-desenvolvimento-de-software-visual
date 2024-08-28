//Testar as APIs
// - Rest Client - Extensão do VSCode
// - Postman 
// - Insomnia
//MINIMAL APIs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades dentro das APIs
//Configurar a URL e o método/verbo
app.MapGet("/", () => "Hello World em C#!");

app.MapGet("/segunda_funcionalidade", () => "Hello World em C#!");

app.MapGet("/retornar_endereco", () => {
    dynamic endereco = new {
        rua = "Parigot de Souza",
        numero = 5300,
        cep = "81290-350"
    };
    return endereco;
});

//Criar uma funcionalidade para receber informações
// - Receber informações pela URL
// - Receber informações pelo corpo da requisição
// - Guardar as informações em uma lista

app.Run();
