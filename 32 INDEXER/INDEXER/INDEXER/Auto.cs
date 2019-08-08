using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXER
{
    class Auto
    {
        double costo;
        double tenencia;
        string modelo;

        public Auto(double costo,string modelo)
        {
            this.costo = costo;
            this.modelo = modelo;
        }

        public void MuestraInfo()
        {
            Console.WriteLine("costo {0} tenencia {1} y modelo {2}", costo, tenencia, modelo);
        }
    }
}
