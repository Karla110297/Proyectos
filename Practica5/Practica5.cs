using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class Practica5
    {
        static void Main(string[] args)
        {
            /*5.- Escriba un algoritmo que regrese el índice de la primera ocurrencia del elemento más grande
            en la sucesión s, . . . , sn. Ejemplo: Si la sucesión es
            6.2 8.9 4.2 8.9,

            el algoritmo regresa el valor 2*/

            Console.WriteLine("Tamaño de la sucesión");
            int tamanio = Int32.Parse(Console.ReadLine());

            double[] sucesion = new double[tamanio];
            double numMayor = 0;
            int indice = 0;

            for (int i = 0; i <tamanio; i++)
            {
                Console.WriteLine("Numero  " + (i + 1));
                sucesion[i] = double.Parse(Console.ReadLine());
            }

            for (int i = tamanio-1; i >= 0; i--)
            {
                
                if (sucesion[i] >= numMayor)
                {
                    numMayor = sucesion[i];
                    indice = i + 1;
                }

            }

            Console.WriteLine("Indice del primer numero mayor= " + indice);
            Console.ReadKey();
        }
    }
}
