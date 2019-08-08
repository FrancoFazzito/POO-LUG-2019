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
            juan.set_sueldo(7000);
            juan.calcularimpuesto();
            juan.muestra();
            juan.mostrarlog();

            Console.WriteLine("-------");

            EMPLEADO jose = new EMPLEADO();
            jose.set_sueldo(50000);
            jose.set_sueldo(30000);
            jose.set_sueldo(10000);

            Console.WriteLine("el sueldo es {0}", jose.get_sueldo(56));

            jose.muestra();
            jose.mostrarlog();

            Console.WriteLine("-------");

            Console.WriteLine("el sueldo es {0}", jose.get_sueldo(12345));

            Console.ReadKey();
        }
    }
}
