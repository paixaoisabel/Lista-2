using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exer_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f;
            double m;
            double r;
            double a;
            double p;


            Console.WriteLine("Escreva seu sexo: masculino (1), feminino (2) ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva sua altura: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu peso: ");
            p = double.Parse(Console.ReadLine());



            m = p / (a * a);
            f = p / (a * a);

            if (r == 1)
                if (m < 20)
                    Console.WriteLine("Abaixo do peso");
                else
                if (20 <= m && m < 25)
                    Console.WriteLine("Peso ideal");
                else
                if (m >= 25)
                    Console.WriteLine("Acima do peso");

            if (r == 2)
                if (f < 19)
                    Console.WriteLine("Abaixo do peso");
                else
                if (19 <= f && f < 24)
                    Console.WriteLine("Peso ideal");
                else
                if (f >= 24)
                    Console.WriteLine("Acima do peso");

        }
    }
}
