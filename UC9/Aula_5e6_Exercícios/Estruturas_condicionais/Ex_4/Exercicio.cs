using System;

namespace Ex_4
{
    /*Exercicio 4 - Mostrar o maior número digitado ou indicar se eles são iguais 
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.Write("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2) {
                Console.Write($"O maior valor é: {n1}.");
            } else if (n2 > n1) {
                Console.Write($"O maior valor é: {n2}.");
            } else {
                Console.Write($"Os valores são iguais.");
            }
        }
    }
}
