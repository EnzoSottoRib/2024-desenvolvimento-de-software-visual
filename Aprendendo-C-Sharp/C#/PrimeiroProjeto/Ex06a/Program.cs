
//1- criar um vetor para receber os valores inteiros
//2- colocar os valores no vetor aleatoriamente
//3- ordenar os valores bubble sort
//4- printar eles ordenados

//public class Ex06a{
    //public void Executar(){
        Random random = new Random();
        int[] vetor = new int[10];
        for(int i = 0; i < vetor.Length; i++){
            vetor[i] = random.Next(1000);
            Console.Write(vetor[i] + " ");
        }

        int temp = 0;

        bool houveTroca;

        do{
            for(int i = 0; i< vetor.Length - 1; i++){
            
                houveTroca = false;

                for(int j=0; j<vetor.Length - i - 1; j++){
                    if(vetor[j] > vetor[j+1]){
                    temp = vetor[j];
                    vetor[j] = vetor[j+1];
                    vetor[j+1] = temp;
                    houveTroca = true;
                    }
                }
            }

        }while (houveTroca = false);
        
        Console.Write("Ordenado ↓\n\n");
        for(int i= 0; i< vetor.Length; i++){
            Console.Write(vetor[i] + " ");
        }
    //}
//}

