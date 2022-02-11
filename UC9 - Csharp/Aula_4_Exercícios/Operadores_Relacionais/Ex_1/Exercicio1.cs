using System;

namespace Ex_1
{
    /*Exercício 1 - Verificar o resultado das expressões com operadores relacionais
    Data: 19/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de atribuição de valores às variáveis
            int a = 3, b = 7, c = 4;

            //Cálculo e apresentação dos resultados
            Console.WriteLine($"Alternativa a) {(a+c)>b}.");
            Console.WriteLine($"Alternativa b) {b >= (a+2)}.");
            Console.WriteLine($"Alternativa c) {c == (b-a)}.");
            Console.WriteLine($"Alternativa d) {(b+a) <= c}.");
            Console.WriteLine($"Alternativa e) {(c+a)>b}.");

        }
    }
}
