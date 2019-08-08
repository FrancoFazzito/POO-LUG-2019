using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOBRECARGAS
{
    class Program
    {
        static void Main(string[] args)
        {
            CCalculadora cCalculadora = new CCalculadora();

            //MISMA FUNCION CON 3 SOBRECARGAS
            Console.WriteLine("resultado de {0}", cCalculadora.suma(5, 3));
            Console.WriteLine("resultado de {0}", cCalculadora.suma(5.1, 3.2));
            Console.WriteLine("resultado de {0}", cCalculadora.suma(5, 3, 4));

            Console.ReadKey();
        }
    }
}
