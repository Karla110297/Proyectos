using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Practica3
    {
        static void Main(string[] args)
        {
            /*3.- Escriba un algoritmo que regrese el índice de la última ocurrencia del elemento más grande en
            la sucesión s1, . . . , sn. Ejemplo: Si la sucesión es
            6.2 8.9 4.2 8.9,
            el algoritmo regresa el valor 4*/

            Console.WriteLine("Tamaño de la sucesión");
            int tamanioSucesion = Int32.Parse(Console.ReadLine());

            double[] sucesion = new double[tamanioSucesion];
            double numMayor = 0;
            int indice = 0;
           
            for (int i = 0; i < tamanioSucesion; i++)
            {
                Console.WriteLine("Numero  " + (i + 1));
                sucesion[i] = double.Parse(Console.ReadLine());

                if (sucesion[i] >= numMayor)
                {
                    numMayor = sucesion[i];
                    indice = i + 1;
                }
               
            }

            Console.WriteLine("Indice del ultimo numero mayor= " + indice);
            Console.ReadKey();
        }
    }
}
