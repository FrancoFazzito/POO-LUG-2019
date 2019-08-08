using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Perro : ANIMAL
    {
        public override void moverse()
        {
            Console.WriteLine("perro {0} camina", Nombre);
        }
    }
}
