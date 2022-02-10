using System;

namespace Ex_4
{
    /*Exercício 4 - vetor na sequência e na ordem inversa
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] h = new int[6] {10, 35, 48, 19, 76, 99};
            /* Console.Write("Na sequência: ");
            for (int i=0; i<6; i++) {
                Console.Write($"{h[i]}.");
            }*/
            //Ou, também:
            Console.Write("Na sequência: ");
            foreach (var i in h) {
                Console.WriteLine($"{i}.");
            }
            //Na ordem inversa: 
            Console.Write("\nNa ordem inversa: ");
            for (int i=5; i>=0; i--) {
                Console.WriteLine($"{h[i]}.");
            }
        }
    }
}
