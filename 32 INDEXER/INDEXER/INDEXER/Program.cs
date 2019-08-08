using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXER
{
    class Program
    {
        static void Main(string[] args)
        {
            //EL INDEXER NOS PERMITE ACCEDER AL INDEX DE UN ARREGLO COMO UNA PROPIEDAD
            TiendaAuto tiendaAuto = new TiendaAuto();

            Auto auto = tiendaAuto[1];
            auto.MuestraInfo();
            Console.WriteLine("----");

            Auto auto2 = new Auto(100000, "fitito");
            tiendaAuto[1] = auto2;
            tiendaAuto[1].MuestraInfo();
            Console.WriteLine("----");


            for (int i = 0; i < 4 /*cantidad de autos*/; i++)
            {
                tiendaAuto[i].MuestraInfo();
            }

            Console.ReadKey();
        }
    }
}
