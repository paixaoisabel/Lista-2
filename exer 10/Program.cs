using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;
            double media;

            Console.Write("Digite a nota da P1: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da P2: ");
            p2 = double.Parse(Console.ReadLine());

            media = (p1 + 2 * p2) / 3;

            if (media >= 5)
            {
                Console.Write("Aprovado media: {0}", media);
            }
            else
            {
                Console.Write("Reprovado media: {0}", media);
            }
            Console.WriteLine();
        }
    }
}
