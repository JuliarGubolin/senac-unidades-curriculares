using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores lógicos: OR e AND
            /*bool a, b, c;
            a = true;
            b = true;
            c = false;
            Console.Write((a||b) && (a||c));*/
            //Operadores relacionais
            /*Igualdade: ==
            Diferença: !=
            Maior: >
            Maior igual: >=
            Menor: <
            Menor igual: <=
            */
            /*Operadores Relacionais
            Exercício 2
            Sabendo que A=5 , B=4 e C=3 e D=6 , informe se
            as expressões abaixo são verdadeiras ou falsas
            a) (A > C) && (C <= D)
            b) (A+B) > 10 || (A+B) = (C+D)
            c) (A>=C) && (D >= C)
            d) ! ((A C) > (B D))
            e) ! ((C+D+A) <> (B+C+D))*/
            int a = 5, b = 4, c = 3, d=6;
            Console.WriteLine((a>c) && (c <= d));
            Console.WriteLine((a+b)> 10 || (a+b) == (c+d));
            Console.WriteLine((a>=c) && (d >= c));
            Console.WriteLine(! ((a - b)>(b - d)));
            Console.WriteLine(!((c+d+a) != (b+c+d)));

        }
    }
}
