using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLBACK_I
{
    class RefriSink : IEventoRefri
    {
        private bool paro = false;

        public bool Paro
        {
            get
            {
                return paro;
            }
        }
        //CLASE SINK
        //AQUI COLOCAMOS LOS HANDLERS DE LOS EVENTOS DEFINIDOS POR LA INTERFAZ
        public void EventReservasBajas(int Kilos)
        {
            //AQUI CODIGO NECESARIO PARA EJECUTAR CUANDO EL EVENTO SUCEDA

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---> reservas bajas de alimentos");
            Console.WriteLine("---> quedan {0}", Kilos);
            //SE PUEDE TENER MULTIPLES
        }

        //SE PUEDE HACER UN EVENTO DE AGREGAR EVENTOS
        public void EventDescongelado(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---> se descongela");

            if(grados > 0)
            {
                paro = true;
            }
        }
       


    }
}
