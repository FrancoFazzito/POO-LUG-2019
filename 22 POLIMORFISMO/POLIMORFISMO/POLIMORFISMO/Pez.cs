using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Pez : ANIMAL
    {
        public override void moverse()
        {
            Console.WriteLine("pez {0} nada", Nombre);
        }
    }
}
