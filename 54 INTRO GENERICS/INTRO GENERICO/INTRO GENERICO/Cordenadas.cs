using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTRO_GENERICO
{
    class Cordenadas
    {
        private double X;
        private double Y;

        public Cordenadas(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("x = {0} y = {1}", X, Y);
        }
    }
}
