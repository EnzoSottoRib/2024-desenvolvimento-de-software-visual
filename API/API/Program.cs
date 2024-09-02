//Testar as APIs
// - Rest Client - Extensão do VSCode
// - Postman 
// - Insomnia

public class Endereco {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
}


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

app.MapGet("/receber_informacao_url/{nome}", (string nome) => {
    return $"O nome recebido foi: {nome}";
});

app.MapPost("/receber_informacao_corpo", (Endereco endereco) => {
    return $"Endereço recebido: {endereco.Rua}, {endereco.Numero}, {endereco.Cep}";
});


app.Run();
