using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Practica4
    {
        static void Main(string[] args)
        {
            //4.-Escriba un algoritmo que encuentre el elemento menor entre a, b y c.

            double a, b, c;

            Console.WriteLine("Numero a " );
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero b ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero c ");
            c = double.Parse(Console.ReadLine());

            if (a <= b && a <= c)
            {
                Console.WriteLine("a es el menor con {0} ", a);
            }
            if (b <= a && b <= c)
            {
                Console.WriteLine("b es el menor con {0} ", b);
            }
            if (c <= b && c <= a)
            {
                Console.WriteLine("c es el menor con {0} ", c);
            }
            Console.ReadKey();
        }
    }
}
