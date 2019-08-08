using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class claseEstatica
    {
        private static int numero;

        static claseEstatica() 
        {
            Console.WriteLine("estas en contructor");
            numero = 33; 
        }

        public static void imprimir()
        {
            Console.WriteLine("el numero es {0}", numero);
        }
    }
}
