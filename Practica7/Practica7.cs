using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class Practica7
    {
        static void Main(string[] args)
        {
            /*7.- De una lista de números random del 1 al 100 ordénelos en orden no decreciente.
              Mostrando los números random y los números ya ordenados.*/

            Random r = new Random();

            int [] listaNumeros = new int[100];
            for(int i = 0; i < 100; i++)
            {
                listaNumeros[i] = r.Next(1,100);
            }

            foreach(int num in listaNumeros)
            {
                Console.Write(num + " ");
            }

            Array.Sort(listaNumeros);

            Console.WriteLine("\nLos números ordenados son:");

            foreach (int num in listaNumeros)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();
        }
    }
}
