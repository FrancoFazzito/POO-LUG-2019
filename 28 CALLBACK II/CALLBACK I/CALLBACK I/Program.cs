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
            RefriSink Sink1 = new RefriSink(); //REFRI
            TiendaSink Sink2 = new TiendaSink(); //TIENDA
            //conectar sink y heladera
            heladera.AgregarSink(Sink1);
            heladera.AgregarSink(Sink2);
            //add sink a la lista 
            //sink1 queda en la lista y cuando se ejecute el evento su metodo va ser invocado

            //el refri hace su trabajo
            while(heladera.KilosAlimentos > 0 && Sink1.Paro == false)
            {
                //el refri trabaja y sacamos kilos al azar
                heladera.Trabajar(1);
                }
    //36 kilos , -6 grados
    //35 kilos , -5 grados
    //34 kilos , -4 grados
    //33 kilos , -3 grados
    //32 kilos , -2 grados
    //31 kilos , -1 grados
    //30 kilos , 0 grados
    //--->se descongela CUANDO REFRI SE DESGONGELA EL PARO ES POSITIVO
    //29 kilos , 1 grados
    //--->se descongela
            Console.ReadKey();

        }
    }
}
