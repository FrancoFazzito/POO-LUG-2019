using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONS_Y_DEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona("a", 10);
            p1.muestra();
            p2.muestra();
            Console.Read();
        }
    }
}
