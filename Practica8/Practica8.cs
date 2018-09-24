using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    class Practica8
    {
        static void Main(string[] args)
        {
            /*8.- Un palíndromo es una secuencia de caracteres que se lee igual de derecho y al reves.Por
            ejemplo : 12321, 55555,45554,11611, . Escriba una aplicación que Lea un entero de 5 digitos y
            determine si es palíndromo. SI el numero no es 5 digitos el programa debe mostrar un error, y
            permitir que el usuario ingrese de nuevo el valor, si el número es palíndromo debe mostrar un
            mensaje de que es palíndromo, sino es palíndromo de igual manera*/

            int entero;
            string numero;
            string numInverso = "";
           
            do
            {
                Console.WriteLine("Entero de 5 digitos");
                entero = Int32.Parse(Console.ReadLine());

                numero = entero.ToString();

                if (numero.Length != 5)
                {
                    Console.WriteLine("Error: Entero NO es de 5 digitos");
                }
            } while (numero.Length != 5);

            for (int i = numero.Length-1; i >=0; --i)
            {
                numInverso += numero[i];
            }

            if (numero == numInverso)
            {
                Console.WriteLine("El entero ingresado es un Palindromo, {0} IGUAL A {1}", numero, numInverso);
            }
            else
            {
                Console.WriteLine("El entero ingresado NO es un Palindromo, {0} DESIGUAL A {1}", numero, numInverso);
            }

            Console.WriteLine(numInverso);

            Console.ReadKey();

        }
    }
}
