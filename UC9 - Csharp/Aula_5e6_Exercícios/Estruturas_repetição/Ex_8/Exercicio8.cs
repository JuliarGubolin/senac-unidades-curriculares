using System;

namespace Ex_8
{
    /*Exercício 7 - Ler 10 números, somar os acima de 20,
    multiplicar os inferiores a 10 e apresentar os resultados.
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            long soma=0, mult=1;
            for (int i=0;i<10;i++) {
                Console.Write($"Digite o número {i+1}/{10}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                if (vetor[i] > 20) {
                    soma = soma + vetor[i];
                }
                if (vetor[i] < 10) {
                    mult = mult * vetor[i];
                }
            }
            Console.WriteLine($"Soma: {soma}\nMultiplicação: {mult}.");
        }
    }
}
