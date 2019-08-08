using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS
{
    class Tortacs
    {
        //ACTUARA COMO DELEGADO
        public static void  MostrarMensaje(string anuncio)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("estamos en la clase pastel");
            Console.WriteLine("el mensaje es {0}", anuncio);
        }

    }
}
