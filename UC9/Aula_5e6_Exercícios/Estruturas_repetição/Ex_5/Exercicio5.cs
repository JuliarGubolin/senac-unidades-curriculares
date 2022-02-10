using System;

namespace Ex_5
{
    /*Exercício 5 - Soma e multiplicação dos valores do vetor;
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0;
            long mult=1;
            int[] a = new int[7] {10, 15, 20, 25, 30, 35, 40};
            for (int i=0;i<7;i++) {
                soma = soma + a[i];
                mult = mult * a[i];
            }
            Console.WriteLine($"Soma e multiplicação dos valores do vetor, respectivamente: {soma} e {mult}.");
        }
    }
}
