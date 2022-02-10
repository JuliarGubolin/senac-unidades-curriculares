using System;

namespace Ex_5
{
    /*Exercício 5 - Simulação de um Menu simples
    Data: 21/05/2021
    Programadora: Julia Gubolin
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int var;

            //Obtenção da opção desejada
            Console.Write("1 - Cadastro\n2 - Vendas\n3 - Compras\n4 - Relatórios\n5 - Sair\n-> ");
            var = Convert.ToInt32(Console.ReadLine());

            //Switch irá verificar o valor que foi digitado e atribuído a variável 'var'
            switch (var){
                case 1:
                    Console.Write("Você selecionou a opção 1 - Cadastro.");
                    break;
                case 2:
                    Console.Write("Você selecionou a opção 2 - Vendas.");
                    break;
                case 3:
                    Console.Write("Você selecionou a opção 3 - Compras.");
                    break;
                case 4:
                    Console.Write("Você selecionou a opção 4 - Relatórios.");
                    break;
                case 5: 
                    Console.Write("Você selecionou a opção 5 - Sair. Programa encerrado.");
                    break;
                default:
                    Console.Write("Entrada inválida.");
                    break;
            }
        }
    }
}
