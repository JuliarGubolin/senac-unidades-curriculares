using System;

namespace Ex_1
{
    /*Exercício 1 - Verificar se valor maior que 10
    Data: 21/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 10) {
                Console.WriteLine($"O número {num} é maior que 10.");
            }
        }
    }
}
