using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS
{
    class Radio
    {
        //ACTUARA COMO DELEGADO
        public static void MetodoRdio(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("estamos en la clase radio");
            Console.WriteLine("el mensaje es {0}", mensaje);
        }
    }
}
