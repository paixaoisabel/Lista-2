using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b;
            double a;
            double area;

            Console.Write("digite o valor da base do retangulo: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da altura do rentangulo:");
            a = double.Parse(Console.ReadLine());

            area = b * a;

            if (area > 100)
                Console.Write("Terreno grande: {0}", area);
            else
                Console.Write("Terreno pequeno: {0}", area);

            Console.WriteLine();
        }
    }
}
