using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLBACK_I
{
    class TiendaSink : IEventoRefri
    {
        //EL IEVENTO ES LA TAREA QUE SE DEBE HACER Y EL SINK ES SU IMPLEMENTACION
        //AL TENER UN ARRAYLIST AQUI SE GUARDAN LOS SINKS QUE SERIAN LAS TAREAS
        //BIEN AHORA SE HARA UNA NUEVA SINK CON EL MISMO EVENTO DE IEVENTOREFRI

        public void EventReservasBajas(int Kilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---> le vamos a enviar sus vivere");
            Console.WriteLine("---> seran {0} kilos", Kilos);
        }

        public void EventDescongelado(int grados)
        {
            //handler vacio ya que a la tienda no le interesa el congelamiento
        }
    }
}
