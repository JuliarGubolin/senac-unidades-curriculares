using System;

namespace Ex_2
{
    /*Exercício 2 - Média e produto se entradas não forem iguais
    Data: 21/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, media, produto;
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Se os números digitados pelo usuário forem diferentes, o código dentro da condicional
            //irá calcular a média e o produto deles e apresentar ao usuário.
            if (num1 != num2) {
                media = (num1+num2)/2;
                produto = num1*num2;
                Console.Write($"A média e o produto entre os valores {num1} e {num2} é, respectivamente: {media} e {produto}.");
            //Se não, apenas indica que eles são iguais e finaliza a aplicação.
            } else {
                Console.Write("Valores iguais.");
            }
        }
    }
}
