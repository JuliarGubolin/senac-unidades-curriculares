using System;

namespace Ex_5
{
    /*Exercício 5 - Calcular a hipotenusa do triângulo
    Data: 18/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis 
            double baseT, altura, hipotenusa;

            //Obtenção dos valores
            Console.Write("Digite a altura do triângulo: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a base do triângulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());

            //Cálculo da hipotenusa e apresentação do resultado
            hipotenusa = Math.Sqrt((Math.Pow(altura, 2)+Math.Pow(baseT, 2)));
            Console.Write($"A hipotenusa do triângulo é: {hipotenusa:N4}.");
        }
    }
}
