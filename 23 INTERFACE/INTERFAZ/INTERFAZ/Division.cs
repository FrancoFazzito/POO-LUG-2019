using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFAZ
{
    class Division : IOperacion
    {
        private double r = 0;
        public void calcular(double a, double b)
        {
            r = a / b;
        }

        public void mostrar()
        {
            Console.WriteLine("el resultado es {0}", r);

        }
    }
}
