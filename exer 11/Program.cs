using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1;
            double p2;

            Console.Write("Digite a nota da P1: ");
            p1 = double.Parse(Console.ReadLine());

            p2 = (15 - p1) / 2;

            if (p2 >= 0 && p2 <= 10)
                Console.Write("Para ser aprovado com média 5, você precisa tirar {0} na p2", p2);
            else
                Console.Write("Não é possível atingir a média 5 com a nota informada para a primeira avaliação");

            Console.WriteLine();

        }
    }
}
