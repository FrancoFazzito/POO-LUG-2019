using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            CCALCULADORA cCALCULADORA = new CCALCULADORA();

            cCALCULADORA.a = 5;
            cCALCULADORA.b = 6;

            //NO PUEDE MOSTRAR POR SU PRIVACIDAD
            //cCALCULADORA.Mostrar();

            cCALCULADORA.Suma();

            Console.Read();
        }
    }
}
