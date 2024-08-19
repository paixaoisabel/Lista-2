using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.Write("digite o valor do lado 1: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("digite o valor do lado 2: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("digite o valor do lado 3: ");
            c = double.Parse(Console.ReadLine());

            if (a + b > c)
                if (a + c > b)
                    if (b + c > a)
                        if (a == b)
                            if (a == c)
                                Console.Write("Equilátero");
                            else
                                Console.Write("Isósceles");
                        else
                            if (b == c)
                            Console.Write("Isósceles");
                        else
                                  if (a == c)
                            Console.Write("Isósceles");
                        else
                            Console.Write("Escaleno");
                    else
                        Console.Write("Não forma triângulo");
                else
                    Console.Write("Não forma triângulo");
            else
                Console.Write("Não forma triângulo");

            Console.WriteLine();
        }
    }
}
