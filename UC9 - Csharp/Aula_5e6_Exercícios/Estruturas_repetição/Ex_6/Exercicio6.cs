using System;

namespace Ex_6
{
    /*Exercício 6 - Maior e menor valor lido
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[30];
            int maior=0, menor=0;
            for (int i=0;i<30;i++) {
                Console.Write($"Digite o valor {i+1}/{30}: ");
                vetor[i]= Convert.ToInt32(Console.ReadLine());
                if (vetor[i] > maior){
                    maior = vetor[i];
                }
                if (vetor[i]< menor){
                    menor = vetor[i];
                }
            }
            Console.Write($"O maior e o menor valor, respectivamente, é: {maior} e {menor}.");
        }
    }
}
