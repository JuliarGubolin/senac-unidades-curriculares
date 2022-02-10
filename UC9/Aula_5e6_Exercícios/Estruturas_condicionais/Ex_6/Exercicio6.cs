using System;

namespace Ex_6
{
    /* Exercício 6 - Informar se um triângulo é Equilátero, Isósceles e Escaleno 
    através da dimensão dos seus 3 lados.
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            double d1, d2, d3;

            //Obtenção dos lados do triângulo
            Console.Write("Digite um lado do triângulo: ");
            d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro lado do triângulo:");
            d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o último lado do triângulo:");
            d3 = Convert.ToDouble(Console.ReadLine());

            //Verificação: se todos os lados são diferentes, ele é escaleno
            if ((d1 != d2) && (d2 != d3) && (d1 != d3)) {
                Console.Write("O triângulo é escaleno.");
            //Verificação: se todos os lados são iguais, ele é equilátero
            } else if ((d1 == d2)  && (d2 == d3) && (d3 == d1)) {
                Console.Write("O triângulo é equilátero.");
            //Verificação: se apenas 2 lados são iguais, ele é isósceles
            } else{
                Console.Write("O triângulo é isósceles.");
            }
        }
    }
}
