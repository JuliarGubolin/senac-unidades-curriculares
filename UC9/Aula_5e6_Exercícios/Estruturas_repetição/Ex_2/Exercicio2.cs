using System;

namespace Ex_2
{
    /*Exercício 2 - Média entre 10 valores
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            double valores, media, soma = 0;
            for (int i=0;i<10;i++) {
                Console.Write($"Digite o número: {i+1}/{10}: ");
                valores = Convert.ToDouble(Console.ReadLine());
                soma = soma + valores;
            }
            media = soma/10;
            Console.Write($"A média dos valores é: {media}.");
        }
    }
}
