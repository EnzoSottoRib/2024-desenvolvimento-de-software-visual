// See https://aka.ms/new-console-template for more information
/* Crie um algoritmo que permita fazer três conversões monetárias. O algoritmo deve receber o valor em real (R$) e apresentar os valores convertidos em:

1. Dólar (1 dólar = 5,17 reais)
2. Euro (1 euro = 6,14 reais)
3. Peso argentino (1 peso argentino = 0,05 reais) */

Console.WriteLine("Digite o valor em reais: ");
float reais = float.Parse(Console.ReadLine());
Console.WriteLine(reais + " reais são: ");
Console.WriteLine((reais * 5.17) + " dólares.");
Console.WriteLine((reais * 6.14) + " euros.");
Console.WriteLine((reais * 0.05) + " pesos argentinos.");
