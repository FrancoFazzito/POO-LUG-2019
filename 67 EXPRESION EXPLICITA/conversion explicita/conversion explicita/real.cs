using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion_explicita
{
    class real
    {
        private double r;

        public real(double r)
        {
            this.r = r;
        }
        public real()
        {
            
        }
        public double R { get => r; set => r = value; }

        public override string ToString()
        {
            return string.Format("r = {0}", r);
        }

        public static implicit operator Complejo(real real)
        {
            Complejo temporal = new Complejo((int)real.r, 0);

            return temporal;
        }
    }
}
