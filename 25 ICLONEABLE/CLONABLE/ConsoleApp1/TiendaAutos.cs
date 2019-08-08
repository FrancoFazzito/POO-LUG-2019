using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TiendaAutos
    {
        private Auto[] Disponibles;

        public TiendaAutos()
        {
            Disponibles = new Auto[4];

            Disponibles[0] = new Auto(30000, "fiat");
            Disponibles[1] = new Auto(32000, "ford");
            Disponibles[2] = new Auto(34000, "chevrolet");
            Disponibles[3] = new Auto(36000, "nissan");
        }

        //using System.Collections;
        public IEnumerator GetEnumerator()
        {
            return Disponibles.GetEnumerator();
        }
    }
}
