// See https://aka.ms/new-console-template for more information
/* Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso.*/

Console.WriteLine("Digite a idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 0){
    Console.WriteLine("Idade inválida!");
}else if(idade != 0 && idade <= 13){
    Console.WriteLine("É criança!");
} else if(idade > 13 && idade <= 18){
    Console.WriteLine("É adolescente!");
} else if(idade > 18 && idade <= 60){
    Console.WriteLine("É adulto!");
} else {
    Console.WriteLine("É idoso!");
}
