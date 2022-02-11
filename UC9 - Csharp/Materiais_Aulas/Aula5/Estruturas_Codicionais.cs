using System;

namespace Aula5
{
    /*Estruturas de controle e estruturas de repetição*/
    class Program
    {
        static void Main(string[] args)
        {
            /*decimal salario;
            Console.Write("Digite seu salário: ");
            salario = Convert.ToDecimal(Console.ReadLine());

            if (salario > 1200) {
                Console.Write("Seu salário é maior que o salário mínimo.");
            } else {
                Console.Write("Seu salário é menor que o salário mínimo.");
            }*/
            //Exercício 4:
            /*double n1, n2;
            Console.Write("Digite um número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite outro número: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            if (n1 > n2) {
                Console.Write($"O maior valor é: {n1}.");
            } else if (n2 > n1) {
                Console.Write($"O maior valor é: {n2}.");
            } else {
                Console.Write($"Os valores são iguais.");
            }*/
            //Switch case
            //Exemplo
            /*int mes;
            Console.Write("Digite o número do seu mês de nascimento: ");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes){
                case 1:
                    Console.Write("Janeiro.");
                    break;
                case 2:
                    Console.Write("Fevereiro");
                    break;
                default:
                    Console.Write("Mês inválido.");
                    break;
            }*/
            //Exercício 5
            /*int var;
            Console.Write("1 - Cadastro\n2 - Vendas\n3 - Compras\n4 - Relatórios\n5 - Sair\n-> ");
            var = Convert.ToInt32(Console.ReadLine());
            switch (var){
                case 1:
                    Console.Write("Você selecionou a opção 1 - Cadastro");
                    break;
                case 2:
                    Console.Write("Você selecionou a opção 2 - Vendas");
                    break;
                case 3:
                    Console.Write("Você selecionou a opção 3 - Compras");
                    break;
                case 4:
                    Console.Write("Você selecionou a opção 4 - Relatórios");
                    break;
                case 5: 
                    Console.Write("Você selecionou a opção 5 - Sair. Programa encerrado.");
                    break;
                default:
                    Console.Write("Mês inválido.");
                    break;
            }*/
            //Estruturas de repetição
            for (int x=0;x<=10;x+=2) {
                Console.WriteLine($"Número: {x}");
            }
            //Vetores em C#
            string[] letras = new string[5] {"a", "b", "c", "d", "e"};
            foreach (var item in letras){
                Console.WriteLine($"O valor da variável item é {item}.");
            }
            //Outros loops: While e do While
            //No do while a verificação ocorre após os comandos serem executados uma vez
            int i;
            Console.Write("Número: ");
            i = Convert.ToInt32(Console.ReadLine());
            do{
                Console.WriteLine($"O valor de i é {i}.");
                i--;
            } while (i > 0);
            //No while a verificação ocorre antes do início da repetição
            int mes = 0;
            while (!(mes > 0 && mes < 13)) {
                Console.WriteLine("Digite seu mês de nascimento: ");
                mes = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
