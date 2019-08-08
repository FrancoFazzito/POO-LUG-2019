using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS_II
{
    class Refri
    {
        //DECLARACION DE DELEGADOS
        public delegate void DReservasBajas(int kilos);
        public delegate void DDescongelado(int grados);
        //solo public de ejemplo

        private int kilos = 0;
        private int grados = 0;

        private DReservasBajas DelegadoReservas;
        private DDescongelado DelegadoCongelado;

        public Refri(int kilos, int grados)
        {
            this.kilos = kilos;
            this.grados = grados;
        }
        //DELEGADORESERVAS YA QUEDO REFERENCIA A ESE METODO QUE ENTRA POR PARAMETRO
        public void adicionarMetodoReservas( DReservasBajas dReservas)
        {
            DelegadoReservas = dReservas;
        }
        //DELEGADOCONGELADO YA QUEDO REFERENCIA A ESE METODO QUE ENTRA POR PARAMETRO
        public void adicionarMetodoCongelado( DDescongelado dDescongelado)
        {
            DelegadoCongelado = dDescongelado;
        }

        public int Kilos
        {
            get
            {
                return kilos;
            }
        }

        public int Grados
        {
            get
            {
                return grados;
            }
        }
        public void trabajar(int consumo)
        {
            kilos -= consumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} kilos , {1} grados", kilos, grados);

            //INVOCAR LOS EVENTOS
            if (kilos < 10)
            {
                DelegadoReservas(kilos);
            }

            if (grados > 0)
            {
                DelegadoCongelado(grados);
            }
        }

    }

}
