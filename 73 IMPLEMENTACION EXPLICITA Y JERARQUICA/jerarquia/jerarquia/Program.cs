using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jerarquia
{
    class Program
    {
        static void Main(string[] args)
        {
            suma suma = new suma();
            suma.calculo(5,3);
            suma.mostrar();
            Console.ReadKey();
        }
    }
}
