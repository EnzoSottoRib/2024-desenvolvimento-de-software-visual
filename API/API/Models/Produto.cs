namespace API.Models; //equivalente ao package do Java

public class Produto
{

    //C# - Construtor da classe
    public Produto(){
        Id = Guid.NewGuid().ToString(); //Guid é um identificador universal
        CriadoEm = DateTime.Now;
    }

    //C# - Atributo com get e set

    public DateTime CriadoEm { get; set; }
    public string? Id {get; set;} // o "?" é só pra tirar a marcação falando q ta vazio
    public string? Nome { get; set;} //"nome" minúsculo quebra a regra
    public double Preco { get; set;}
    public int Quantidade { get; set;}
    

    //JAVA - Atributo com get e set
    /*
    public double preco;
    public double getPreco(){
        return preco;
    }
    public void setPreco(double preco){
        this.preco = preco * 3;
    }
    */
}
