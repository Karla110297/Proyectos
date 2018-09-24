using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Practica1
    {
        static void Main(string[] args)
        {
            // 1.- Escriba un algoritmo cuya salida sea el valor menor y mayor en la sucesión S1, . . . , Sn.

            Console.WriteLine("Tamaño de la sucesión");
            int tamanioSucesion = Int32.Parse(Console.ReadLine());

            double[] sucesion = new double[tamanioSucesion];
            double numMayor = 0;
            double numMenor = 0;

            for (int i = 0; i < tamanioSucesion; i++)
            {
                Console.WriteLine("Numero  " + (i + 1));
                sucesion[i] = double.Parse(Console.ReadLine());

                if (sucesion[i] >= numMayor)
                {
                    numMayor = sucesion[i];
                }

                if (i == 0 || sucesion[i] <= numMenor)
                {
                    numMenor = sucesion[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine("El numero mayor es " + numMayor);
            Console.WriteLine("El numero menor es " + numMenor);

            Console.ReadKey();

        }
    }
}
