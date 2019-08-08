using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long byteheap = GC.GetTotalMemory(false); /*full selection en false*/
            Console.WriteLine("heap tiene {0}", byteheap);

            int maximaGeneracion = GC.MaxGeneration + 1;
            Console.WriteLine("tiene {0}", maximaGeneracion);

            prueba prueba = new prueba(5);
            long byteheap2 = GC.GetTotalMemory(false);
            Console.WriteLine("heap tiene {0}", byteheap2);

            int GeneracionInstancia = GC.GetGeneration(prueba);

            GC.Collect();
            /*forzar la recoleccion de basura*/
            /*cuando se crean muchas instancias*/
            GC.WaitForPendingFinalizers();


            Console.ReadKey();
        }
    }
}
