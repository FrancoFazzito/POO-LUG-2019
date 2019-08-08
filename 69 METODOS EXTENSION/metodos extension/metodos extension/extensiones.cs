using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_extension
{
    /*tiene que ser estatica para la extension*/
    static class extensiones
    {
        public static bool espar(this int i)
        {
            if (i % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double DoubleTea( this double d)
        {
            return d * 2;
        }
        /*recibe como parametro algo que esta implementado por interfaz */
        /*sino puedo mandar una clase*/
        public static void hola(this ISaludaador s)
        {
            Console.WriteLine("hola");
        }
    }
}
