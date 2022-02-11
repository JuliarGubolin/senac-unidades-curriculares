using System;

namespace Trabalho_Final_JuliaGubolin
{
    /*Trabalho final da UC9 do curso "Assistente de Desenvolvimento de Aplicativos Computacionais" do SENAC
    Data: 01/06/2021
    Programadora: Julia Gubolin
    GitHub: https://github.com/JuliarGubolin/SENAC.git
    */
    class Program
    {
        static string temp;
        static int opcao = 1;
        static void Main(string[] args)
        {
            while(opcao >= 1 && opcao < 26)
            {
                //MENU----------------------------------------------
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("-------------------------------\n");
                Console.Write("Digite o número do exercício: ");
                Console.Write("\n-------------------------------\n");
                Console.ResetColor();
                //Exercícios introdutórios
                Console.WriteLine("1 - Calcular a área de um retângulo.");
                Console.WriteLine("2 - Calcular a idade que casou.");
                Console.WriteLine("3 - Calcular a circunferência e o raio de um círculo.");
                Console.WriteLine("4 - Calcular a área de um triângulo.");
                Console.WriteLine("5 - Calcular a hipotenusa de um triângulo.");
                Console.WriteLine("6 - Calcular o salário final de um funcionário.");
                Console.WriteLine("7 - Calcular o custo final do carro para o consumidor.");
                //Exercícios com expressões lógicas e relacionais
                Console.WriteLine("8 - Expressões com operadores lógicos.");
                Console.WriteLine("9 - Expressões com operadores relacionais.");
                //Exercícios estruturas condicionais    
                Console.WriteLine("10 - Verificar se o valor digitado é maior do que 10.");
                Console.WriteLine("11 - Calcular média e produto se os valores digitados forem diferentes.");
                Console.WriteLine("12 - Verificar se dois nomes são iguais.");
                Console.WriteLine("13 - Verificar se uma pessoa é maior de 18 anos.");
                Console.WriteLine("14 - Simular um menu de opções.");
                //Exercícios estruturas de repetição 
                Console.WriteLine("15 - Calcular a tabuada de um valor A até um valor B.");
                Console.WriteLine("16 - Calcular a média entre 10 valores digitados.");
                Console.WriteLine("17 - Somar os pares existentes em um intervalo.");
                Console.WriteLine("18 - Apresentar um vetor na sequência e na ordem inversa.");
                Console.WriteLine("19 - Somar e multiplicar valores em um vetor.");
                Console.WriteLine("20 - Encontrar o menor e o maior valor entre 30 entradas.");
                Console.WriteLine("21 - Ler 15 números e calular sua soma, subtração e multiplicação");
                Console.WriteLine("22 - Ler 10 valores e somar os maiores de 20 e multiplicar os menores que 10.");
                Console.WriteLine("23 - Série de Fibonacci.");
                Console.WriteLine("24 - Fatorial.");
                Console.WriteLine("25 - Sequência de quadrados.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("26 - Sair");
                Console.ResetColor();
                //MENU----------------------------------------------
                Console.Write("-> ");
                temp = Console.ReadLine();
                while (Int32.TryParse(temp, out opcao) == false || opcao < 1 || opcao > 30) 
                {
                    Console.Write("Opção inválida. Digite novamente: ");
                    temp = Console.ReadLine();
                }
                // Menu para escolha dos exercícios
                switch (opcao) 
                {
                    case 1:
                        Console.Clear();
                        Ex01();
                        espera();
                        break;
                    case 2:
                        Console.Clear();
                        Ex02();
                        espera();
                        break;
                    case 3:
                        Console.Clear();
                        Ex03();
                        espera();
                        break;
                    case 4:
                        Console.Clear();
                        Ex04();
                        espera();
                        break;
                    case 5:
                        Console.Clear();
                        Ex05();
                        espera();
                        break;
                    case 6:
                        Console.Clear();
                        Ex06();
                        espera();
                        break;
                    case 7:
                        Console.Clear();
                        Ex07();
                        espera();
                        break;
                    case 8:
                        Console.Clear();
                        Ex08();
                        espera();
                        break;
                    case 9:
                        Console.Clear();
                        Ex09();
                        espera();
                        break;
                    case 10:
                        Console.Clear();
                        Ex10();
                        espera();
                        break;
                    case 11:
                        Console.Clear();
                        Ex11();
                        espera();
                        break;
                    case 12:
                        Console.Clear();
                        Ex12();
                        espera();
                        break;
                    case 13:
                        Console.Clear();
                        Ex13();
                        espera();
                        break;
                    case 14:
                        Console.Clear();
                        Ex14();
                        espera();
                        break;
                    case 15:
                        Console.Clear();
                        Ex15();
                        espera();
                        break;
                    case 16:
                        Console.Clear();
                        Ex16();
                        espera();
                        break;
                    case 17:
                        Console.Clear();
                        Ex17();
                        espera();
                        break;
                    case 18:
                        Console.Clear();
                        Ex18();
                        espera();
                        break;
                    case 19:
                        Console.Clear();
                        Ex19();
                        espera();
                        break;
                    case 20:
                        Console.Clear();
                        Ex20();
                        espera();
                        break;
                    case 21:
                        Console.Clear();
                        Ex21();
                        break;
                    case 22:
                        Console.Clear();
                        Ex22();
                        espera();
                        break;
                    case 23:
                        Console.Clear();
                        Ex23();
                        break;
                    case 24:
                        Console.Clear();
                        Ex24();
                        espera();
                        break;
                    case 25:
                        Console.Clear();
                        Ex25();
                        espera();
                        break;
                    case 26:
                        Console.WriteLine("Saindo...Programa encerrado.");
                        break;
                    default:
                    Console.WriteLine("Valor inválido.");
                        break;
                }
            }
        } // Fim da função Main()
        //Criei a função 'espera' pois o menu estava muito grande. 
        //Com isso, o usuário não conseguiria ver a resposta pois o menu 'jogaria'
        //ela para o topo do terminal. Portanto, tentei facilitar a visualização.
        static void espera(){
            Console.Write("Para voltar ao menu principal, pressione <Enter>..." ); 
            Console.WriteLine();
            while(Console.ReadKey().Key != ConsoleKey.Enter){
                if ( Console.ReadKey().Key == ConsoleKey.Enter )
                {
                    break;
                }
            }
        }
        //Método criado para o exercício 1
        static void Ex01(){
            //Declaração de variáveis
            double altura, area, baseR;

            //Obtenção dos dados
            Console.Write("Programa calculador de área de retângulo!\nDigite a Base: ");
            baseR = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Cálculo da área e aprensentação do resultado
            area = altura*baseR;
            Console.WriteLine("A área do retângulo é: "+area);
        }
        //Método criado para o exercício 2
        static void Ex02(){
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
            Console.WriteLine(nome+", você tinha "+idade_casou+" anos quando se casou em "+ano_casamento);
        }
        //Método criado para o exercício 3
        static void Ex03(){
             //Declaração das variáveis. A variável pi recebe o valor que o C# definiu para 'pi'
            double pi = Math.PI;
            double raio, circunf, area;

            //Obtenção dos dados
            Console.Write("Digite o raio do cículo: ");
            raio = Convert.ToDouble(Console.ReadLine());

            //Cálculo da circunferência e da área do círculo
            circunf = 2*pi*raio;
            area = pi*(raio*raio);
            //Apresentação do resultado
            Console.WriteLine($"A área do círculo vale: {area:N4}. A circunferência do círculo vale: {circunf:N4}");
        }
        //Método criado para o exercício 4
        static void Ex04(){
            //Declaração das variáveis
            double baseT, altura, area;

            //Obtenção dos dados
            Console.Write("Digite a altura do triângulo: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a base do triângulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());

            //Cálculo da circunferência e da área do círculo
            area = (baseT*altura)/2;
            //Apresentação do resultado
            Console.WriteLine($"A área do triângulo é: {area:N4}.");
        }
        //Método criado para o exercício 5
        static void Ex05(){
            //Declaração das variáveis 
            double baseT, altura, hipotenusa;

            //Obtenção dos valores
            Console.Write("Digite a altura do triângulo: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a base do triângulo: ");
            baseT = Convert.ToDouble(Console.ReadLine());

            //Cálculo da hipotenusa e apresentação do resultado
            hipotenusa = Math.Sqrt((Math.Pow(altura, 2)+Math.Pow(baseT, 2)));
            Console.WriteLine($"A hipotenusa do triângulo é: {hipotenusa:N4}.");
        }
        //Método criado para o exercício 6
        static void Ex06(){
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
            Console.WriteLine("Salário final com acréscimos (se existirem): "+salarioTotal);
        }
        //Método criado para o exercício 7
        static void Ex07(){
             //Declaração de variáveis
            double soma, custo_fabrica;

            //Obtenção dos valores
            Console.Write("Digite o custo de fábrica do carro: ");
            custo_fabrica = Convert.ToDouble(Console.ReadLine());
            
            //Cálculo do custo total com os acréscimos de fábrica 
            soma = custo_fabrica + (0.45*custo_fabrica) + (0.28*custo_fabrica);
            //Apresentação dos dados
            Console.WriteLine($"Custo final para o consumidor: {soma}");
        }
        //Método criado para o exercício 8
        static void Ex08(){
            //Declaração e atribuição de valores às variáveis
            bool a = true, b = true, c = false;
            
            //Calculo e apresentação dos resultados
            Console.WriteLine($"Alternativa a) (a && b) || (a && c) {((a && b) || (a && c))}.");
            Console.WriteLine($"Alternativa b) (a || b) && (a || c) {((a || b) && (a || c))}.");
            Console.WriteLine($"Alternativa c) a || c && b || a && !b {a || c && b || a && !b}.");
        }
        //Método criado para o exercício 9
        static void Ex09(){
            //Declaração de atribuição de valores às variáveis
            int a = 3, b = 7, c = 4;

            //Cálculo e apresentação dos resultados
            Console.WriteLine($"Alternativa a) (a+c)>b {(a+c)>b}.");
            Console.WriteLine($"Alternativa b) b >= (a+2) {b >= (a+2)}.");
            Console.WriteLine($"Alternativa c) c == (b-a) {c == (b-a)}.");
            Console.WriteLine($"Alternativa d) (b+a) <= c {(b+a) <= c}.");
            Console.WriteLine($"Alternativa e) (c+a)>b {(c+a)>b}.");
        }
        //Método criado para o exercício 10
        static void Ex10(){
            int num;
            Console.Write("Digite um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 10) {
                Console.WriteLine($"O número {num} é maior que 10.");
            }
        }
        //Método criado para o exercício 11
        static void Ex11(){
            double num1, num2, media, produto;
            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Se os números digitados pelo usuário forem diferentes, o código dentro da condicional
            //irá calcular a média e o produto deles e apresentar ao usuário.
            if (num1 != num2) {
                media = (num1+num2)/2;
                produto = num1*num2;
                Console.WriteLine($"A média e o produto entre os valores {num1} e {num2} é, respectivamente: {media} e {produto}.");
            //Se não, apenas indica que eles são iguais e finaliza a aplicação.
            } else {
                Console.WriteLine("Valores iguais, portanto nenhuma operação é feita.");
            }
        }
        //Método criado para o exercício 12
        static void Ex12(){
            string nome1, nome2;
            Console.Write("Digite um nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite outro nome: ");
            nome2 = Console.ReadLine();
            if (nome1 != nome2) {
                Console.WriteLine($"Os nomes {nome1} e {nome2} são diferentes.");
            } else {
                Console.WriteLine($"Os nomes {nome1} e {nome2} são iguais.");
            }
        }
        //Método criado para o exercício 13
        static void Ex13(){
             string nome;
            int idade;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18) {
                Console.WriteLine($"{nome}, você é menor de 18 anos.");
            } else {
                Console.WriteLine($"{nome}, você é maior de 18 anos, já pode dirigir e é obrigado a votar.");
            }
        }
        //Método criado para o exercício 14
        static void Ex14(){
            //Declaração de variáveis
            int var;

            //Obtenção da opção desejada
            Console.Write("1 - Cadastro\n2 - Vendas\n3 - Compras\n4 - Relatórios\n5 - Sair\n-> ");
            var = Convert.ToInt32(Console.ReadLine());

            //Switch irá verificar o valor que foi digitado e atribuído a variável 'var'
            switch (var){
                case 1:
                    Console.WriteLine("Você selecionou a opção 1 - Cadastro.");
                    break;
                case 2:
                    Console.WriteLine("Você selecionou a opção 2 - Vendas.");
                    break;
                case 3:
                    Console.WriteLine("Você selecionou a opção 3 - Compras.");
                    break;
                case 4:
                    Console.WriteLine("Você selecionou a opção 4 - Relatórios.");
                    break;
                case 5: 
                    Console.WriteLine("Você selecionou a opção 5 - Sair. Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Entrada inválida.");
                    break;
            }
        }
        //Método criado para o exercício 15
        static void Ex15(){
            int a, b;
            Console.Write("Digite o valor que deseja saber a tabuada: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite até qual valor será calulada a tabuada: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=b;i++) {
                Console.WriteLine($"Tabuada do {a}. {a} x {i} = {a*i}");
            }
        }
        //Método criado para o exercício 16
        static void Ex16(){
             double valores, media, soma = 0;
            for (int i=0;i<10;i++) {
                Console.Write($"Digite o número: {i+1}/{10}: ");
                valores = Convert.ToDouble(Console.ReadLine());
                soma = soma + valores;
            }
            media = soma/10;
            Console.WriteLine($"A média dos valores é: {media}.");
        }
        //Método criado para o exercício 17
        static void Ex17(){
             int v1, v2, soma=0;
            Console.Write("Digite o valor inicial: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor final: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            for (int i=v1;i<=v2;i++) {
                if (i % 2 == 0){
                    soma = soma + i;
                }
            }
            Console.WriteLine("A soma dos pares entre os números lidos é: "+soma);
        }
        //Método criado para o exercício 18
        static void Ex18(){
            int[] h = new int[6] {10, 35, 48, 19, 76, 99};
            /* Console.Write("Na sequência: ");
            for (int i=0; i<6; i++) {
                Console.Write($"{h[i]}.");
            }*/
            //Ou, também:
            Console.WriteLine("Na sequência: ");
            foreach (var i in h) {
                Console.WriteLine($"{i}.");
            }
            //Na ordem inversa: 
            Console.WriteLine("\nNa ordem inversa: ");
            for (int i=5; i>=0; i--) {
                Console.WriteLine($"{h[i]}.");
            }
        }
        //Método criado para o exercício 19
        static void Ex19(){
            int soma=0;
            long mult=1;
            int[] a = new int[7] {10, 15, 20, 25, 30, 35, 40};
            for (int i=0;i<7;i++) {
                soma = soma + a[i];
                mult = mult * a[i];
            }
            Console.WriteLine($"Soma e multiplicação dos valores do vetor, respectivamente: {soma} e {mult}.");
        }
        //Método criado para o exercício 20
        static void Ex20(){
            int soma=0;
            long mult=1;
            int[] a = new int[7] {10, 15, 20, 25, 30, 35, 40};
            for (int i=0;i<7;i++) {
                soma = soma + a[i];
                mult = mult * a[i];
            }
            Console.WriteLine($"Soma e multiplicação dos valores do vetor, respectivamente: {soma} e {mult}.");
        }
        //Método criado para o exercício 21
        static void Ex21(){
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
        //Método criado para o exercício 22
        static void Ex22(){
            int[] vetor = new int[10];
            long soma=0, mult=1;
            for (int i=0;i<10;i++) {
                Console.Write($"Digite o número {i+1}/{10}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                if (vetor[i] > 20) {
                    soma = soma + vetor[i];
                }
                if (vetor[i] < 10) {
                    mult = mult * vetor[i];
                }
            }
            Console.WriteLine($"Soma: {soma}\nMultiplicação: {mult}.");
        }
        //Método criado para o exercício 23
        static void Ex23(){
            int op=0;
            while (op != 3){
                Console.WriteLine("Você deseja: ");
                Console.WriteLine("1 - Ver um número de valores da sequência.");
                Console.WriteLine("2 - Ver a sequência até o valor digitado.");
                Console.Write("3 - Voltar ao menu principal.\n-> ");
                op = Convert.ToInt32(Console.ReadLine());
            
                switch (op) {
                    case 1: 
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
                            Console.WriteLine("fim.");
                        }
                        break;
                    case 2:
                        int num1, x=0, j=2;
                        Console.Write("Digite um número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 < 20) {
                            Console.Write("O número deve ser maior do que 20.");
                        } else {
                            Console.Write("Série de Fibonacci: 0, 1, ");
                            int[] aux = new int[num1];
                            aux[0] = 0;
                            aux[1] = 1;
                            while (x < num1){
                                Console.Write($"{x}, ");
                                aux[j] = aux[j-1] + aux[j-2];
                                x = aux[j];
                                j++;
                            }
                            Console.WriteLine("fim.");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Valor inválido, leia novamente o menu.");
                        break;
                }
            }
        }
        //Método criado para o exercício 24
        static void Ex24(){
            int num, fat = 1;
            Console.Write("Digite o número que deseja saber o fatorial: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num == 1){
                Console.WriteLine("O valor do fatorial é 1.");
            } else{
                for (int i=1;i<=num;i++) {
                    fat = fat * i;
                }
                Console.WriteLine($"O fatorial de {num} é: {fat}");
            }
        }
        //Método criado para o exercício 25
        static void Ex25(){
            int n, i=0;
            Console.Write("Digite um valor: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n) {
                Console.Write($"{i*i}, ");
                i++;
            }
            Console.WriteLine("fim.");
        }
    } // FIM do programa
}
