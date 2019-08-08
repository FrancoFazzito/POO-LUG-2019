using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLBACK_I
{
    class RefriSink : IEventoRefri
    {
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
    }
}
