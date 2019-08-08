using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            //METODO ANONIMO PERO SU EJECUCION DEPENDE DEL CONTEXTO
            //PARAMETROS SEGUIDO DE EJECUCION

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 4, 5, 6, 1, 2, 3, });
            /*expresion*/ /*parametro i ( pero=> implicita solo i)*/
            List<int> pares = numeros.FindAll(i => (i % 2) == 0); /*si (numero) i entre dos da cero se pone en la lista*/

            //muestra
            foreach (int item in pares)
            {
                Console.WriteLine(item);
            }

            List<int> NumerosPares = numeros.FindAll(i =>
            {
                if (i % 2 == 0)
                {
                    Console.Write("- par -");
                    return true;
                }
                else
                {
                    Console.Write("- impar -");
                    return false;
                }
            } );
            Console.WriteLine();
            foreach (int item in NumerosPares)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
