// See https://aka.ms/new-console-template for more information
/* Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior. */

Console.WriteLine("Digite o primeiro número: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int num2 = int.Parse(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine("O primeiro é maior!");
} else if (num1 == num2){
    Console.WriteLine("Os dois são iguais!");
} else {
    Console.WriteLine("O segundo é maior!");
}
