using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTRUCTOR -> INICIALIZACION DE LOS ATRIBUTOS DE UNA CLASE
            //Persona p1 = new Persona();
            //NEW ES LA INVOACION AL CONSTRUCTOR
            //p1.Nombre = "juan";
            //p1.Edad = 10;
            //p1.muestra();

            Persona p1 = new Persona();
            p1.muestra();

            Persona P2 = new Persona(15, "jose");
            P2.muestra();


            Console.ReadKey();
        }
    }
}
