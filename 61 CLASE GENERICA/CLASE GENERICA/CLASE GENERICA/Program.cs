using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_GENERICA
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto<int> puntoint = new Punto<int>(3, 5);
            Punto<float> puntofloat = new Punto<float>(3.12f, 5.4f);
            Punto<double> puntodouble = new Punto<double>(3.54, 5.2);
            Console.WriteLine(puntoint);
            Console.WriteLine(puntofloat);
            Console.WriteLine(puntodouble);
            puntoint.Reset();
            Console.WriteLine(puntoint);
            Console.ReadKey();
        }
    }
}
