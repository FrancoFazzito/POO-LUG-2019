using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXER
{
    class TiendaAuto
    {

        private Auto[] disponibles;

        public TiendaAuto()
        {
            disponibles = new Auto[4];

            disponibles[0] = new Auto(22200.56, "soul");
            disponibles[1] = new Auto(25000.78, "fit");
            disponibles[2] = new Auto(27000.56, "spark");
            disponibles[3] = new Auto(29000.45, "ford");
        }

        public Auto this[int indice]
        {
            get
            {
                //obtenemos el elemento de ese indice
                return disponibles[indice];
            }
            set
            {
                //escribimos en ese elemento
                disponibles[indice] = value;
            }
        }
    }
}
