using System;

namespace Ex_1
{
    /*Exercício 1 - Verificar o resultado das expressões com operadores lógicos
    Data: 19/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração e atribuição de valores às variáveis
            bool a = true, b = true, c = false;
            
            //Calculo e apresentação dos resultados
            Console.WriteLine($"Alternativa a) {((a && b) || (a && c))}.");
            Console.WriteLine($"Alternativa b) {((a || b) && (a || c))}.");
            Console.WriteLine($"Alternativa c) {a || c && b || a && !b}.");
        }
    }
}
