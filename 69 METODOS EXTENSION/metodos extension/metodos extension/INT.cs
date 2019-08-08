using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_extension
{
    class INT : ISaludaador
    {
        private int a;

        public INT(int a)
        {
            this.a = a;
        }

        public int A { get => a; set => a = value; }

        public override string ToString()
        {
            return string.Format("tu int es {0}", a);
        }

        public void saludar()
        {
            Console.WriteLine("hola desde int {0}", a);
        }
    }
}
