using System;

namespace Ex_9
{
    /*Exercício 9 -  Calular a série de Fibonacci para valores acima de 20
    Data: 21/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Verificação: o valor digitado deve ser maior que 20
            if (num < 20) {
                Console.Write("O número deve ser maior do que 20.");
            } else {
                //Utilizei um vetor para sempre possuir as 2 posições anteriores
                //a que deve ser calculada.
                int[] aux = new int[num];
                Console.Write("Série de Fibonacci: 0, 1,");
                //Como os primeiro 2 valores não sofrem a ação da soma, 
                //eles apenas foram armazenados no vetor.
                for (int i=0;i<num;i++) {
                    if (i == 0){
                        aux[0] = 0;
                    }else if (i == 1){
                        aux[1] = 1;
                    }else{
                        aux[i] = aux[i-1] +aux[i-2];
                        Console.Write($" {aux[i]}, ");
                    }
                }
            }
        }
    }
}
