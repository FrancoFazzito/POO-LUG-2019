using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESORS
{
    class Program
    {
        static void Main(string[] args)
        {

            EMPLEADO juan = new EMPLEADO();

            juan.Sueldo = 1000;
            juan.calcularimpuesto();


            Console.WriteLine("el impuesto es {0}" , juan.Impuesto);


            Console.ReadKey();
        }
    }
}
