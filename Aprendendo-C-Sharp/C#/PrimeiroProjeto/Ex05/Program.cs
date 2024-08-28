// See https://aka.ms/new-console-template for more information
/* Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. Por exemplo: caso o usuário insira o número 15, o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13.*/

//a = 0; b = 1; c = a+b = 1
//a = 1; b = 1; c = a+b = 2
//a = 1; b = 2; c = a+b = 3


int a = 0, b = 1, c;
bool flag = true;
Console.Write("Digite o valor: ");
int val = int.Parse(Console.ReadLine());

//enquanto flag for true
while (flag){
    //se a for maior que o valor lido
    if (a <= val){
        //se b for maior que o valor lido, printa o "a + ." (no caso o último valor), e coloca flag como falso, pois pode terminar o loop while
        if (b > val){
            Console.Write(a + ".");
            flag = false;
        }
        //se b nao for maior que o valor lido, printa o "a + ," (o valor mais alto da sequência)
        else{
            Console.Write(a + ", ");
        }

        //o terceiro valor é o anterior do anterior + o anterior
        c = a + b;
        //primeiro numero recebe b, o antigo numero do meio
        a = b;
        //segundo numero recebe a soma dos antigos dois primeiros, e se torna o mais alto
        b = c;

    //se o if (a <= val) não for verdadeiro, ele coloca flag como falso e finaliza o loop while
    } else{ 
        flag = false;
    }
    
}
    
