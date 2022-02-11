using System;

namespace Exercício_Final
{
    /*Exercício final UC9
    Programadora: Julia Rodrigues Gubolin
    Data: 01/06/2021*/
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            string nome, resposta;
            double raio, circunferenciaTerra;

            //Obtenção do nome do usuário
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            //Verificando se o usuário é terraplanista ou não
            Console.Write($"Olá, {nome}. Você é terraplanista <sim> ou <não>?: ");
            resposta = Console.ReadLine();

            //Verificação: se o usuário for terraplanista, o programa apenas é finalizado
            if (resposta == "sim" || resposta == "Sim") {
                Console.WriteLine("Programa finalizado.");
            
            //Verificação: se o usuário não for terraplanista, precisaremos
            //obter o raio da Terra
            } else if (resposta == "não" || resposta == "Não"){

                //Obtenção do valor do raio da Terra
                Console.Write("Digite o raio da Terra (em km): ");
                raio = Convert.ToDouble(Console.ReadLine());

                //Cálculo da circunferência da Terra a partir da fórmula 2*raio*PI e apresentação do resultado
                circunferenciaTerra = 2 * raio * Math.PI;
                Console.Write($"A circunferência da Terra é: {circunferenciaTerra:N2}");

                //Verificação: caso o usuário digite alguma opção diferente de "sim" ou "não"
            } else{
                 Console.WriteLine("Opção inválida.");
            }
        }
    }
}
