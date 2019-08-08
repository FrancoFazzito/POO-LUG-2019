using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATIC
{
    class Compu
    {
        private static double cambio;

        private string nombre;
        private int memoria;
        private double costo;

        public Compu(string nombre, int memoria, double costo)
        {
            this.nombre = nombre;
            this.memoria = memoria;
            this.costo = costo;
        }

        public double Cambio
        {
            set
            {
                cambio = value;
            }
        }

        public void muestrapesos()
        {
            Console.WriteLine("procesador: {0}, memoria {1}", nombre, memoria);
            Console.WriteLine("costo {0}", costo);
        }

        public void muestradolares()
        {
            Console.WriteLine("procesador: {0}, memoria {1}", nombre, memoria);
            Console.WriteLine("costo {0} cambio {1}", costo * cambio, cambio);
        }
    }
}
