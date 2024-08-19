using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;


            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());

            if (a > b && a > c && a * a == b * b + c * c)
                Console.Write("É um triangulo retangulo");
            else
                if (b > a && b > c && b * b == a * a + c * c)
                Console.Write("É um triangulo retangulo");
            else
                    if (c > a && c > b && c * c == a * a + b * b)
                Console.Write("É um triangulo retangulo");
            else
                Console.Write("Não é um triangulo retangulo");

            Console.WriteLine();
        }
    }
}
