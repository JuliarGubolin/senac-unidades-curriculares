using System;

namespace Ex_4
{
    /*Exercício 4 - Calcular a área do triângulo
    Data: 18/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double baseT, altura, area;

            //Obtenção dos dados
            Console.Write("Digite a altura do triângulo: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a base do triângulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());

            //Cálculo da circunferência e da área do círculo
            area = (baseT*altura)/2;
            //Apresentação do resultado
            Console.Write($"A área do triângulo é: {area:N4}.");
        }
    }
}
