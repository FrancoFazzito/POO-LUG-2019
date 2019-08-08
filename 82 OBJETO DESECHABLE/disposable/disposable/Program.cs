using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disposable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*recursos no administrados y queremos liberar haciendose con GC (sln anterior)*/
            /*si queeremos liberarlo de forma rapida y lo antes posible*/
            /*hay que implementar disposable*/

            prueba prueba = new prueba(5);
            Console.WriteLine(prueba);
            /*ya no lo necesito*/
            if(prueba is IDisposable)
            {
               // prueba.Dispose();
            }
            try
            {
                Console.WriteLine(prueba);
            }
            finally
            {
                prueba.Dispose();
            }
            using (prueba prueba2 = new prueba(3))
            {
                Console.WriteLine(prueba2);
                /*luego del using se garantiza el dispose*/
            }
            prueba prueba3 = new prueba(8);
            Console.WriteLine("---fin---");
            Console.ReadKey();
        }
    }
}
