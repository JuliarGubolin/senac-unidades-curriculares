using System;

namespace Ex_8
{
    /*Exercício 8 - Verificar aprovação de um aluno pela média aritmética
    de suas notas.
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            Console.Write("Nota 1: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 3: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            media = (n1+n2+n3)/3;
            if (media >= 6) {
                Console.Write("Você foi aprovado.");
            } else {
                Console.Write("Você foi reprovado.");
            }
        }
    }
}
