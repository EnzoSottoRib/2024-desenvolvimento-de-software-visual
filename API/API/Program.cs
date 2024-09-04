//Testar as APIs
// - Rest Client - Extensão do VSCode
// - Postman 
// - Insomnia

using API.Models; //equivalente ao "import" de Java


//MINIMAL APIs

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades dentro das APIs
//Request - Configurar a URL e o método/verbo HTTP
//Response - Retornar os dados (json/xml) e 

app.MapGet("/", () => "API de Produtos");

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto(){
    Nome = "Notebook",
    Preco = 5000,
    Quantidade = 54
});
produtos.Add(new Produto(){
    Nome = "Desktop",
    Preco = 3500,
    Quantidade = 66
});
produtos.Add(new Produto(){
    Nome = "Monitor",
    Preco = 350,
    Quantidade = 74
});
produtos.Add(new Produto(){
    Nome = "Caixa de som Junkboxy",
    Preco = 630,
    Quantidade = 27
});

//GET: /produto/listar
app.MapGet("/produto/listar", () => {
    return Results.Ok(produtos);
});

//GET: /produto/cadastrar
app.MapPost("/produto/cadastrar/{nome}", (string nome) => {
    Produto produto = new Produto();
    produto.Nome = nome;
    produtos.Add(produto);
    return Results.Ok(produtos);
});


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

/*
app.MapGet("/receber_informacao_url/{nome}", (string nome) => {
    return $"O nome recebido foi: {nome}";
});

app.MapPost("/receber_informacao_corpo", ([FromBody] UserInfo endereco) => {
    listaEndereco.Add(endereco);
    return $"Endereço recebido: {endereco.Rua}, {endereco.Numero}, {endereco.Cep}";
});

//teste teste teste
*/

app.Run();

//C# - Utilização dos gets e sets
Produto produto = new Produto();
produto.Preco = 5;
Console.WriteLine("Preço: " + produto.Preco);


//Java - Utilizacao dos gets e sets
/*
Produto produto = new Produto();
produto.setPreco(5);
Console.WriteLine("Preço: " + produto.getPreco());
*/


/*
public class Endereco {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
} */