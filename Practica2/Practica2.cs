using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Practica2
    {
        static void Main(string[] args)
        {
            //2.- Escriba un algoritmo que invierta la sucesión s1, . . . , sn.Ejemplo:
            //Si la sucesión es AMY BRUNO ELIE la sucesión invertida es ELIE BRUNO AMY.
            
            Console.WriteLine("Frase: ");
            string frase = Console.ReadLine();

            string[] palabras = frase.Split(' ');                      

            Console.WriteLine();

            for (int i = (palabras.Length - 1); i >= 0; i--)
            {
                Console.Write(palabras[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
