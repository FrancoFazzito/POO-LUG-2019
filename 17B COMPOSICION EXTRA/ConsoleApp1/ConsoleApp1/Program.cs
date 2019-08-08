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
            Escuela escuela = new Escuela("pepeli");

            escuela.calculaAula();

            Console.WriteLine(escuela);
            // IDEM A ARRIBA Console.WriteLine(escuela.ToString());
            Console.ReadKey();

            //SI ELIMINAMOS ESCUELA NO HAY FORMA DE LEER LAS AULAS
            escuela = null;
            escuela.ToString();
        }
    }
}
