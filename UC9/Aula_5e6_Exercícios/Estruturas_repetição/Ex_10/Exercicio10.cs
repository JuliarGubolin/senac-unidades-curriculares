using System;

namespace Ex_10
{
    /*Exercício 10 - Calcular o fatorial de um número digitado.
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {   
            int num, fat = 1;
            Console.Write("Digite o número que deseja saber o fatorial: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num == 1){
                Console.Write("O valor do fatorial é 1.");
            } else{
                for (int i=1;i<=num;i++) {
                    fat = fat * i;
                }
                Console.Write($"O fatorial de {num} é: {fat}");
            }
        }
    }
}
