using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGREGACION
{
    class Program
    {
        static void Main(string[] args)
        {
            //MIENTRAS JUAN EXISTA EXISTE EDIFICIO

            Propietario juan = new Propietario("juan");


            juan.MostrarPropiedad();

            Console.WriteLine("-------");

            //INFO SALTANDO LA ENCAPSULACION DE ANA
            //Edificio edificio = juan.Propiedad;
            //edificio.muestra();

            //juan = null;
            //GC.Collect();
            //juan.MostrarPropiedad();

            //CAMBIOS A PROPIEDAD DESDE PROPIETARIO
            Console.ReadKey();

        }
    }
}
