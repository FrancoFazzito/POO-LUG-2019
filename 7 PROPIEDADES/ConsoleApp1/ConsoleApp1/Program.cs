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
            STATIC.imprimir();
            //solo una vez
            STATIC sTATIC = new STATIC();
            STATIC sTATIC1 = new STATIC();
            STATIC sTATIC2 = new STATIC();
            STATIC sTATIC3 = new STATIC();
            STATIC sTATIC4 = new STATIC();
            //

            /*si la clase es estatica no puedo crear una instancia de la clase*/
            //claseEstatica claseEstatica = new claseEstatica(); No se puede crear ninguna instancia de la clase estática 'claseEstatica'
            claseEstatica.imprimir();
            Console.ReadKey();
        }
    }
}
