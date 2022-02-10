using System;

namespace Ex_2
{
    /*Exercício 2 - Informar se as expressões abaixo são verdadeiras ou falsas
    Data: 19/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de atribuição de valores às variáveis
            int a = 5, b = 4, c = 3, d = 6;

            //Cálculo e apresentação dos resultados
            Console.WriteLine($"Alternativa a) {(a>c) && (c <= d)}.");
            Console.WriteLine($"Alternativa b) {(a+b) > 10 || (a+b) == (c+d)}.");
            Console.WriteLine($"Alternativa c) {(a>=c) && (d >= c)}.");
            Console.WriteLine($"Alternativa d) {!((a-c)>(b-d))}.");
            Console.WriteLine($"Alternativa e) {!((c+d+a) != (b+c+d))}.");
        }
    }
}
