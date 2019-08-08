using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOBRECARGAS
{
    class CCalculadora
    {
        //SOLO TOMA SUMA DE INTS PERO SI SE QUIEREN UNA DE DOUBLE O UNA DE TRES SE TENDRIA QUE HACER OTRA CON EL MISMO NOMBRE
        public int suma(int a , int b)
        {
            int r = 0;
            r = a + b;
            return r;
        }
        public double suma(double a, double b)
        {
            double r = 0;
            r = a + b;
            return r;
        }
        public double suma(double a, double b,double c)
        {
            double r = 0;
            r = a + b + c;
            return r;
        }
    }
}
