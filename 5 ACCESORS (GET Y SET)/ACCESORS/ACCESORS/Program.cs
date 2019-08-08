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

            //AL SER PRIVADO ESTO NO SE PUEDE HACER
            //juan.sueldo = 1000;

            juan.set_sueldo(10500.50);
            juan.muestra();

            juan.calcularimpuesto();
            double impuesto;

            impuesto = juan.get_impuesto();

            Console.WriteLine("------");

            Console.WriteLine("impuesto es {0}", impuesto);

            Console.WriteLine("------");

            juan.muestra();
            Console.ReadKey();
        }
    }
}
