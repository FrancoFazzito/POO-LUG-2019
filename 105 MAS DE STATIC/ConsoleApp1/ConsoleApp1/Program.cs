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
            //AMBITO EN DONDE SE CONOCE ALGO
            //NIVELES: LOCAL OBJETO STATIC
            int a = 5;
            a = a * 10;
            Console.WriteLine("a = {0}", a);
            MICLASEcs mICLASEcs = new MICLASEcs();
            Console.WriteLine("-----------");
            mICLASEcs.muestra();
            mICLASEcs.Multiplicador();
            Console.WriteLine("-----------");
            mICLASEcs.muestra();
            Console.Read();
        }
    }
}
