using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS_II
{
    class Tienda
    {
        public static void MandaViveres(int kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("estoy en clase tienda");
            Console.WriteLine("seran {0}", kilos);
        }
    }
}
