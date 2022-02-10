using System;

namespace Ex_2
{
    /*Exercício 2 - Calcular a idade em que casou
    Data: 18/05/2021
    Programadora: Julia Gubolin*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis sem atribuição
            string nome;
            int idade, ano_casamento, idade_casou;

            //Obtenção dos dados 
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o ano em que casou: ");
            ano_casamento = Convert.ToInt32(Console.ReadLine());

            //Cálculo da idade em que o usuário casou e apresentação do resultado
            idade_casou = idade - (2021-ano_casamento);
            Console.Write(nome+", você tinha "+idade_casou+" anos quando se casou em "+ano_casamento);
        }
    }
}
