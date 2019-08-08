using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Compu compu1 = new Compu("i3", 8, 3000);
            Compu compu2 = new Compu("i5", 10, 5000);
            compu1.Cambio =35;
            compu1.muestradolares();
            compu1.muestrapesos();
            compu2.muestradolares();
            compu2.muestrapesos();
            Console.WriteLine("------");
            compu1.Cambio = 70;
            compu1.muestradolares();
            compu1.muestrapesos();
            compu2.muestradolares();
            compu2.muestrapesos();
            Console.ReadKey();
        }
    }
}
