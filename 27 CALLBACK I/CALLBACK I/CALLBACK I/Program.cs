using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLBACK_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALL BACK -> CREAR MANEJO DE EVENTOS PERMITIENDO LA COMUNICACION ENTRE EVENTOS (NO SE USA MUCHO)
            //SINK -> OBJETO QUE LLEVA A CABO EL EVENTO 
            //SINK -> METODO HANDLER QUE SE INVOCA CUANDO EL EVENTO SUCEDE
            //EVENTO -> CUANDO ALGO SUCEDE 
            //NECESITAMOS SABER QUE EVENTOS HAY QUE HACER
            //REFRIGERADOR -> CUANDO HAY POCOS ALIMENTOS Y CUANDO SE DESCONGELA CUANDO SE CUMPLA
            Refri heladera = new Refri(50, -20);
            Random rnd = new Random();
            RefriSink Sink1 = new RefriSink();
            //conectar sink y heladera
            heladera.AgregarSink(Sink1);
            //add sink a la lista 
            //sink1 queda en la lista y cuando se ejecute el evento su metodo va ser invocado

            //el refri hace su trabajo
            while(heladera.KilosAlimentos > 0)
            {
                //el refri trabaja y sacamos kilos al azar
                heladera.Trabajar(1);
            }
            Console.ReadKey();

        }
    }
}
