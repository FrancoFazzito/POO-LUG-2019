using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS_II
{
    delegate void DReservasBajas(int kilos); /*SE DECLARA EL DELEGADO CON SU VALOR DE RETORNO Y SU PARAMETRO INT*/
    delegate void DDescongelado(int grados);

    class Refri
    {
        private int kilos = 0;
        private int grados = 0;

        private DReservasBajas DelegadoReservas; /*ACA SE INICIALIZA CON SU NOMBRE*/
        private DDescongelado DelegadoCongelado; /*ACA SE INICIALIZA CON SU NOMBRE*/

        public void adicionarMetodoReservas(DReservasBajas dReservas)
        {
            /*DELEGADO       += DELEGADO A ENTRAR*/
            DelegadoReservas += dReservas; /*ENTRA POR PARAMETRO UN DELEGADO DE RESERVAS*/
        }

        public void EliminarMetodoReservas(DReservasBajas dReservas)
        {
            /*DELEGADO       -= DELEGADO A ENTRAR*/
            DelegadoReservas -= dReservas; /*ELIMINA EL DELEGADO DE RESERVAS*/
        }

        public void adicionarMetodoCongelado(DDescongelado dDescongelado)
        {
            /*DELEGADO        += DELEGADO A ENTRAR*/
            DelegadoCongelado += dDescongelado;
        }
   
        public void EliminarMetodoCongelado(DDescongelado dDescongelado)
        {
            /*DELEGADO        += DELEGADO A ENTRAR*/
            DelegadoCongelado -= dDescongelado;
        }
        public Refri(int kilos, int grados)
        {
            this.kilos = kilos;
            this.grados = grados;
        }

        public int Kilos
        {get { return kilos; }set { kilos = value; } }
        public int Grados
        { get { return grados; }set{ grados = value;}}



        public void trabajar(int consumo)
        {
            kilos -= consumo;
            grados += 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} kilos , {1} grados", kilos, grados);
            if (kilos < 10)
            {
                DelegadoReservas(kilos); /*SE INVOCA AL DELEGADO Y SE MANDA POR PARAMETRO EL INT KILOS*/
                /*SE ENVIA EL ELEMENTO DE LA LISTA DE LOS DELEGADOS*/
            }

            if (grados > 0)
            {
                DelegadoCongelado(grados); /*SE INVOCA AL DELEGADO Y SE MANDA POR PARAMETRO EL INT KILOS*/
            }
        }

    }

}
