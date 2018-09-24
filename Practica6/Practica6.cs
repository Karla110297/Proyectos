using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    class Practica6
    {
        static void Main(string[] args)
        {
            /*6.- Escriba un algoritmo que regrese el índice del primer elemento que es mayor que su
            predecesor en la sucesión s1, . . . , sn.Si s está en orden no decreciente, el algoritmo regresa el
            valor 0.Ejemplo: Si la sucesión es

            AMY BRUNO ELIE DAN ZEKE,
    
            el algoritmo regresa el valor 2*/

            Console.WriteLine("Frase: ");
            string frase = Console.ReadLine();

            string[] palabras = frase.Split(' ');

            int indice = 0;

            Console.WriteLine();

            int i = 1;
            while(i < palabras.Length && indice == 0)
            {
                if (palabras[i].Length > palabras[i - 1].Length)
                {
                    indice = i+1;
                }

                i++;
            }

            Console.WriteLine("Indice del primer elemento mayor a su predecedor = "+indice);

            Console.ReadKey();

        }
    }
}
