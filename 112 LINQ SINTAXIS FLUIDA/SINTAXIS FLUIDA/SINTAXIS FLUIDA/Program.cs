using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINTAXIS_FLUIDA
{
    class Program
    {
        static void Main(string[] args)
        {
            //ienumerable -> secuencia
            //element -> item en la secuencia
            //operador -> modificadores de las secuencias

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };
            /*predicado donde N es loq ue enumera la secuencia y tiene hacerlo en true o false*/

            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0); /*va a guardar donde N de 0 cuando se divida por dos*/

            foreach (int item in pares)
            {
                Console.WriteLine(item);
            }

            string[] palabras = { "casa", "casa de juannnn", "casa de jose", "pato", "caballo", "jose" };

            IEnumerable<string> Palabras = palabras.Where(p => p.Contains("jose"));

            foreach (string item in Palabras)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> casa = palabras.Where(p => p.Contains("casa")).OrderBy(p => p.Length).Select(p => p.ToUpper());

            foreach (string item in casa)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------");
            Console.ReadKey();
        }
    }
}
