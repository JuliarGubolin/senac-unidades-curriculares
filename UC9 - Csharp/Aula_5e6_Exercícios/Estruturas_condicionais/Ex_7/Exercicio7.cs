using System;

namespace Ex_7
{
    /*Exercício 7 - Verificar se uma pessoa é maior de 18 anos.
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18) {
                Console.Write($"{nome}, você é menor de 18 anos.");
            } else {
                Console.Write($"{nome}, você é maior de 18 anos, já pode dirigir e é obrigado a votar.");
            }
        }
    }
}
