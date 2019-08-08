using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Ave : ANIMAL
    {
        public override void moverse()
        {
            Console.WriteLine("ave {0} vuela", Nombre);
        }
    }
}
