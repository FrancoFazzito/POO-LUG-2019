using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion_explicita
{
    class Complejo
    {
        private int a;
        private int b;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public Complejo(int a, int b)
        {
            A = a;
            B = b;
        }

        public override string ToString()
        {
            return string.Format("{0} + {1}", a, b);
        }
        /*colocan codigo de la cual sale el valor y se lleva a la otra clase COMPLEJO HACIA OTRA*/

        public static explicit operator real(Complejo complejo)
        {
            real temp = new real();
            temp.R = complejo.a;
            return temp;
        }
    }
}
