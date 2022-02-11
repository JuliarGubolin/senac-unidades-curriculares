using System;

namespace Ex_7
{
    /*Exercício 7 - Ler 15 números e calular sua soma, subtração e multiplicação.
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[15];
            long soma=0, sub=0, mult=1;
            for (int i=0;i<15;i++) {
                Console.Write($"Digite o número {i+1}/{15}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + vetor[i];

                //Verificação: se for o primeiro loop, apenas salvamos o valor.
                //A partir do segundo, já podemos subtrair os valores.
                if (i == 0){
                    sub = vetor[i];
                } else {
                    sub = sub - vetor[i];
                }
                mult = mult * vetor[i];
            }
            Console.WriteLine($"Soma dos números: {soma}\nMultiplicação dos números: {mult}\nSubtração dos números: {sub}.");
        }
    }
}
