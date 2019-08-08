using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIALIZACION
{
    [Serializable]
    class Auto
    {
        private double costo;
        private string modelo;

        public Auto(double costo, string modelo)
        {
            this.costo = costo;
            this.modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
        }

        public void muestra()
        {
            Console.WriteLine("{0} vale {1}", modelo, costo);
        }
    }
}
