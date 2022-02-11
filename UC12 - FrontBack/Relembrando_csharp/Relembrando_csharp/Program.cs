using System;

namespace Relembrando_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string texto;
            int numero;
            double numeroDecimal;
            bool logico;

            //Inicializar uma variável
            texto = "Título";
            numero = 1;
            numeroDecimal = 1.3;
            logico = true; //Verdadeiro
            logico = false; //Falso

            //Programa => fluxo de dados
            //Entrada -> processamento -> saída
            //Saída -> processamento -> entrada

            //Comandos de entrada ou saída
            //Objetos => entrada e saída de dados
            //Comandos => propriedades => métodos => eventos
            //Console.ReadKey();
            //Propriedade
            Console.Title = "Meu prorgrama de revisão do C#";
            //Método
            //Console.ReadKey();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Meu texto na tela.");

            //Evento: o único em C#
            Console.CancelKeyPress += Console_CancelKeyPress;
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine($"Key pressed: {e.SpecialKey}.");
            Console.WriteLine($"Cancel property: {e.Cancel}.");
            Console.WriteLine("Setting the Cancel Property to true...");
            e.Cancel = true;
            Console.WriteLine($"Cancel property: {e.Cancel}.");
            Console.WriteLine($"A operação vai resume...");
        }
    }
}
