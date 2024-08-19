using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double p;
            double r;

            Console.WriteLine("Escreva sua altura: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu peso: ");
            p = double.Parse(Console.ReadLine());

            r = p / (a * a);

            if (r < 20)
                Console.WriteLine("Abaixo do peso");
            else
                if (20 <= r && r < 25)
                Console.WriteLine("Peso ideal");
            else
                if (r >= 25)
                Console.WriteLine("Acima do peso");
        }
    }
}
