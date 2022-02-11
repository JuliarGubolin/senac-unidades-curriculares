using System;

namespace Ex_3
{
    /*Exercício 3 - Soma dos pares entre dois números
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma=0;
            Console.Write("Digite o valor inicial: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor final: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            for (int i=v1;i<=v2;i++) {
                if (i % 2 == 0){
                    soma = soma + i;
                }
            }
            Console.Write("A soma dos pares entre os números lidos é: "+soma);
        }
    }
}
