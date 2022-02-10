using System;

namespace Ex_11
{
    /*Exercício 11 - Calcular os quadrados dos valores de 0 a um
    valor digitado.
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            int n, i=0;
            Console.Write("Digite um valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n) {
                Console.Write($"{i*i}, ");
                i++;
            }
            Console.Write("fim.");
        }
    }
}
