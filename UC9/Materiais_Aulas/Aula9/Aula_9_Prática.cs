using System;

namespace Aula9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int j=0;
            //Cada posição so vetor será usada para salvar os valores calculados do
            //fatorial de 2 até 10.
            int[] vetor = new int[9]  {1, 1, 1, 1, 1, 1, 1, 1, 1};
            Console.Write("O fatorial de 0 é 1.\n");
            Console.Write("O fatorial de 1 é (0!)*1: 1\n");
            for (int i=1;i<=2;i++) {
                vetor[j] = vetor[j] * i;
            }
            //A cada cálculo, ele mostra o valor resultante 
            Console.Write($"O fatorial de 2 é ({j+1}!)*2: {vetor[j]}\n");
            j++;
            for (int i=1;i<=3;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 3 é ({j+1}!)*3: {vetor[j]}\n");
            j++;
            for (int i=1;i<=4;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 4 é ({j+1}!)*4: {vetor[j]}\n");
            j++;
            for (int i=1;i<=5;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 5 é ({j+1}!)*5: {vetor[j]}\n");
            j++;
            for (int i=1;i<=6;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 6 é ({j+1}!)*6: {vetor[j]}\n");
            j++;
            for (int i=1;i<=7;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 7 é ({j+1}!)*7: {vetor[j]}\n");
            j++;
            for (int i=1;i<=8;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 8 é ({j+1}!)*8: {vetor[j]}\n");
            j++;
            for (int i=1;i<=9;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 9 é ({j+1}!)*9: {vetor[j]}\n");
            j++;
            for (int i=1;i<=10;i++) {
                vetor[j] = vetor[j] * i;
            }
            Console.Write($"O fatorial de 10 é ({j+1}!)*10: {vetor[j]}\n");
            j++;*/
            /*int total = 0;
            Console.Write("Quantos números sua sequência terá?: ");
            total = int.Parse(Console.ReadLine());
            // Declarando array para armazenar a sequencia
                string[] sequencia = new string[total];
                Console.WriteLine("----------------------------------------------------");
                for (int i = 0; i < total; i++)            
                {
                    // Armazenando cada sequencia          
                    Console.Write("Informe um valor da sequência: ");
                    sequencia[i] = Console.ReadLine();
                }    
                //Retornando lista das sequencia
                Console.WriteLine("Sua sequência foi: ");
                foreach (var itemNome in sequencia)
                {
                    Console.Write($"{itemNome} , ");
                }   
                Console.WriteLine("fim.");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Sua sequência inversa é: ");
                for (int inversa = total - 1; inversa >= 0; inversa--)
                {
                Console.Write($"{sequencia[inversa]} , ");    
                }
                Console.WriteLine("fim.");
                Console.WriteLine("----------------------------------------------------"); */
                //Números perfeitos
                int[] soma = new int[52] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0};
                for (int i=1; i <= 50; i++) {
                    for (int j=1; j <= 50; j++) {
                        if ((i % j) == 0 && (i != j)) {
                            soma[i] = soma[i] + j;
                        }
                    }
                }
                for (int k=1; k <= 50; k++) {
                    if (soma[k] == k){
                        Console.WriteLine($"O número {k} é perfeito.");
                    }
                }
        }
    }
}
