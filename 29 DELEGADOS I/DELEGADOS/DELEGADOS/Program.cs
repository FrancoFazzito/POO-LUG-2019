using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS
{
    //CREACION DEL DELEGADO SE PUEDEN CREAR EN LA CLASE O FUERA 
    public delegate void Delegado(string m);
    //           TIPO VOID Y PARAMETRO UN STRING

    class Program
    {
        static void Main(string[] args)
        {
            //DELEGADO ACTUA COMO SI FUERA UNA REFERENCIA A UNA FUNCION TENIENDO CIERTAS CARACTERISTICAS
            //EL DELEGADO ACTUA COMO UNA REFERENCIA QUE TENGA SUS MISMA CARACTERICAS 
            //ASO                        (EL DELEGADO)               (REFERENCIA A ESTOS 2)
            //DELEGADOS -> TENEMOS METODO VOID FUNCION (INT A, INT B) VOID IMPUESTO(INT CANT, INT IMP) VOID CALORIAS(INT KM, INT TIEMPO) 
            //DELEGADO PUEDE HACER LAS FUNCIONES A LAS QUE ESTA REFERENCIADA 

            //CREAMOS UN OBJETO DELEGADO Y LO REFERENCIAMOS A UN METODO
            Delegado MiDelegado = new Delegado(Radio.MetodoRdio);

            MiDelegado("hola a todos");
            //invoca a la radio

            Console.WriteLine("------");

            MiDelegado = new Delegado(Tortacs.MostrarMensaje);

            MiDelegado("feliz cumple");
            //invoca a la torta
            Console.ReadKey();
        }
    }
}
