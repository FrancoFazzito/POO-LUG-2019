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
            //CLONACION LO QUE HACE ES HACER OTRO OBJETO CON EL MISMO ESTADO CADA UNO CON LA VIDA DIFERENTE
            //LUEGO PUEDEN CAMBIAR

            Auto auto1 = new Auto(2000, "fiat");
            Auto auto2 = auto1;
            Console.WriteLine("----------------");
            Console.WriteLine("SIN CLONACION");
            Console.WriteLine("----------------");
            auto1.CalculaTenencia(0.10);
            auto2.CalculaTenencia(0.10);
            auto1.MuestraInfo();
            auto2.MuestraInfo();
            Console.WriteLine("-----");
            //SI HUBIERA SIDO UNA COLNACION SOLO UNO CAMBIA 
            //COMO NO SE HIZO ASI LOS DOS CAMBIAN
            auto1.Costo = 60000;
            auto1.MuestraInfo();
            auto2.MuestraInfo();
            Console.WriteLine("----------------");
            Console.WriteLine("CLONACION");
            Console.WriteLine("----------------");
            Auto auto3 = (Auto)auto1.Clone();
            auto1.MuestraInfo();
            auto3.MuestraInfo();
            Console.WriteLine("----------------");
            auto1.Costo = 120000;
            auto1.MuestraInfo();
            auto3.MuestraInfo();
            Console.ReadKey();

        }
    }
}
