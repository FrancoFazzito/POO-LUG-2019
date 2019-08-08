using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Reptil : ANIMAL
    {
        public override void moverse()
        {
            Console.WriteLine("reptil {0} arrastra", Nombre);
        }
    }
}
