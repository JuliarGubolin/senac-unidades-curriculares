using System;

namespace Ex_1
{
    /*Exercício 1 - Calcular área de um retângulo
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double altura, area, baseT;

            //Obtenção dos dados
            Console.Write("Programa calculador de área de retângulo!\nDigite a Base: ");
            baseT = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Cálculo da área e aprensentação do resultado
            area = altura*baseT;
            Console.WriteLine("A área do retângulo é: "+area);
        }
    }
}
