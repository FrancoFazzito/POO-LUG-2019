using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortSet_y_observable
{
    /*IMPLEMENTAR ICOMPARABLE PARA SORT SET EN UNA CLASE PARTICULAR E IMPLEMENTAR EL GENERICO*/
    class Coordenadas : IComparable<Coordenadas>
    {
        private double X;
        private double Y;

        public Coordenadas(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("x = {0} y = {1}", X, Y);
        }
        public int CompareTo(Coordenadas a)
        {
            if(this.X > a.X)
            {
                return 1;
            }
            if (this.X < a.X)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
