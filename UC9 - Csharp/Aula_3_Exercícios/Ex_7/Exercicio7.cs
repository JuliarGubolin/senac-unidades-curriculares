using System;

namespace Ex_6
{
    /*Exercício 7 - Calcular o custo final do carro para o consumidor
    Data: 18/05/2021
    Programadora: Julia Gubolin*/

    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double soma, custo_fabrica;

            //Obtenção dos valores
            Console.Write("Digite o custo de fábrica do carro: ");
            custo_fabrica = Convert.ToDouble(Console.ReadLine());
            
            //Cálculo do salário com acréscimo pela hora extra
            soma = custo_fabrica + (0.45*custo_fabrica) + (0.28*custo_fabrica);
            //Apresentação dos dados
            Console.Write($"Custo final para o consumidor: {soma}");
        }
    }
}
