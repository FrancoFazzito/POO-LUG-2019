using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Gato : ANIMAL
    {
        public override void moverse()
        {
            Console.WriteLine("dato {0} camina", Nombre);
        }
    }
}
