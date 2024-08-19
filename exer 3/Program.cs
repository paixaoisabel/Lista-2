using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;

            Console.Write("Digite o 1° valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3° valor: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 == n2)
                if (n1 == n3)
                    Console.Write("Iguais");
                else
                    if (n1 > n3)
                    Console.Write("1°/2°");
                else
                    Console.Write("3°");
            else
                if (n1 == n3)
                if (n1 > n2)
                    Console.Write("1°/3°");
                else
                    Console.Write("2°");
            else
                       if (n2 == n3)
                if (n2 > n1)
                    Console.Write("2°/3°");
                else
                    Console.Write("1°");
            else
                            if (n1 > n2)
                if (n1 > n3)
                    Console.Write("1°");
                else
                    Console.Write("3°");
            else
                               if (n2 > n3)
                Console.Write("2°");
            else
                Console.Write("3°");
            Console.WriteLine();
        }
    }
}
