using System;

namespace Ex_6
{
    /*Exercício 6 - Calcular o salário final do funcionário
    Data: 18/05/2021
    Programadora: Julia Gubolin*/

    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double salarioNormal, salarioPorHora, salarioTotal, valorHorasExtras, salarioExtra;
            int qtdHorasExtras, qtdHorasTrabalhadas;

            //Obtenção dos valores
            Console.Write("Digite seu salário por hora: ");
            salarioPorHora = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite as horas trabalhadas no mês: ");
            qtdHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());

            //Cálculo do salário com acréscimo pela hora extra
            if (qtdHorasTrabalhadas <= 160){
                salarioNormal = salarioPorHora * qtdHorasTrabalhadas;
                valorHorasExtras = 0;
                salarioExtra = 0;
            } else { 
                salarioNormal = salarioPorHora * 160;
                qtdHorasExtras = qtdHorasTrabalhadas - 160;
                valorHorasExtras = salarioPorHora + (salarioPorHora*0.5);
                salarioExtra = valorHorasExtras * qtdHorasExtras;
            }
            salarioTotal = salarioNormal + salarioExtra;
            //Apresentação dos dados
            Console.Write("Salário final com acréscimos (se existirem): "+salarioTotal);
        }
    }
}
