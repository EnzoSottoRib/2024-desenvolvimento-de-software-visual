public class OutraClasse
{
    public void CalcularArea(){
        Console.WriteLine("Bem vindo(a) ao calculador de área de retângulo!");
        Console.WriteLine("Digite a altura do retângulo: ");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a largura do retângulo: ");
        float largura = float.Parse(Console.ReadLine());
        float area = altura * largura;
        Console.WriteLine("A área do retângulo é: " + area);
    }
}
