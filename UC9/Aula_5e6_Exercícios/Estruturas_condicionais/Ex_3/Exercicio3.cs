using System;

namespace Ex_3
{
    /*Exercício 3 - Verificar se dois nomes são iguais
    Data: 21/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            Console.Write("Digite um nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite outro nome: ");
            nome2 = Console.ReadLine();
            if (nome1 != nome2) {
                Console.Write("Nomes diferentes.");
            } else {
                Console.Write("Nomes iguais.");
            }
        }
    }
}
