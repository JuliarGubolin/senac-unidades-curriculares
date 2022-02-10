using System;

namespace Ex_3
{
    /*Exercício 3 - Calcular a circunferência e a área de um círculo
    Data: 18/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis. A variável pi recebe o valor que o C# definiu para 'pi'
            double pi = Math.PI;
            double raio, circunf, area;

            //Obtenção dos dados
            Console.Write("Digite o raio do cículo: ");
            raio = Convert.ToDouble(Console.ReadLine());

            //Cálculo da circunferência e da área do círculo
            circunf = 2*pi*raio;
            area = pi*(raio*raio);
            //Apresentação do resultado
            Console.Write($"A área do círculo vale: {area:N4}. A circunferência do círculo vale: {circunf:N4}");
        }
    }
}
