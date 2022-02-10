using System;

namespace Ex_1
{
    /*Exercício 1 - Calcular a tabuada de A até B
    Data: 21/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Digite o valor que deseja saber a tabuada: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite até qual valor será calulada a tabuada: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=b;i++) {
                Console.WriteLine($"Tabuada do {a}. {a} x {i} = {a*i}");
            }
        }
    }
}
