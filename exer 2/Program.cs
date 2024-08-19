using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.Write("os valores são iguais: {0}", n1);
            }
            else
            {
                if (n1 > n2)
                {
                    Console.Write("o primeiro é maior: {0}", n1);
                }
                else
                {
                    Console.Write("O segundo é maior: {0}", n2);
                }
            }
            Console.WriteLine();
        }
    }
}
