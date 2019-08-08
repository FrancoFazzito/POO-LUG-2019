using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLBACK_I
{
    class Refri
    {
        //CLASE DE TRABAJO LA CUAL REALIZA LAS ACCIONES QUE DETECTA EL EVENTO
        //ARREGLO DINAMICO EN CUAL ADICIONAMOS ELEMENTOS
        private ArrayList listaSinks = new ArrayList();
        //listasinks es una lista de eventos
        private int kilosAlimentos = 0;
        private int grados = 0;

        public Refri(int kilosAlimentos, int grados)
        {
            //VALORES INICIALES
            this.kilosAlimentos = kilosAlimentos;
            this.grados = grados;
        }

        //2 METODOS UNO PARA AGREGAR UN SINK Y UNO PARA ELIMINAR UN SINK
    
        //ADD
        public void AgregarSink(IEventoRefri sink)
        {
            //NO SEA NULO ES DECIR QUE TENGA UNA INSTANCIA
            if(sink != null)
            {
                listaSinks.Add(sink);
            }
        }

        //REMOVE
        public void EliminarSink(IEventoRefri sink)
        {
            //SI EXISTE EN LA LISTA
            if (listaSinks.Contains(sink))
            {
                listaSinks.Remove(sink);
            }
        }

        public int KilosAlimentos
        {
            get
            {
                return kilosAlimentos;
            }
        }

        public int Grados
        {
            get
            {
                return grados;
            }
        }

        public void Trabajar(int consumo)
        {
            kilosAlimentos -= consumo;
            //REFRI ES QUIEN EJECUTA LA LOGICA SIENDO INDEPENDIENTE DEL MAIN
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} kilos , {1} grados", kilosAlimentos, grados);

            //SI SE CUMPLE LA FUNCION PARA HACERLO INVOCAR LOS HANDLERS DEL EVENTO
            //EVENTO DE KILOS
            if (kilosAlimentos < 10) //ESTA ES LA CONDICION
            {
                //RECORRE LA LISTA DE HANDLERS PARA RECORRER EL INDICADO COMO RESERVASBAJAS
                foreach(IEventoRefri handler in listaSinks)
                {
                    handler.EventReservasBajas(kilosAlimentos);
                }
            }
            //EVENTO DE GRADOS
            if (grados >= 0) //ESTA ES LA CONDICION
            {
                //RECORRE LA LISTA DE HANDLERS PARA RECORRER EL INDICADO COMO RESERVASBAJAS
                foreach (IEventoRefri handler in listaSinks)
                {
                    handler.EventDescongelado(grados);
                }
            }
        }
    }
}
