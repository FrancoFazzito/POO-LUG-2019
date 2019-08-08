using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punteros
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int valor = 5;

                int* puntero; /*creo apuntador que tiene la direccion de memoria de esto*/ /*a donde apunta*/
                /*apuntador de tipo entero y en su interior guarda valor de tipo entero*/
                puntero = &valor; /*direccion */ /*apunta apunta al valor del int valor*/

                Console.WriteLine(*puntero);

                /*cambio de valor*/
                *puntero = 67; /*ahora en la direccion de memoria donde apunta puntero queda cargado con 67*/

                Console.WriteLine(*puntero);
                Console.WriteLine(valor);

            }

            Console.WriteLine();

            int a = 2;
            int b = 3;
            Console.WriteLine("{0} {1}", a, b);

            unsafe
            {
                /*envio de sus direciones de memoria*/
                Swap(&a, &b);
            }

            Console.WriteLine("{0} {1}", a, b);
            Console.ReadKey();
        }

        unsafe public static void Swap(int * n, int * m)
        {
            int temp = *m; /*temp recibe valor de a donde apunta M*/
            *m = *n;
            *n = temp;
        }
    }
}
