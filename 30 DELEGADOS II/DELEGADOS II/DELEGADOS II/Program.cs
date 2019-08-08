using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADOS_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Refri refri = new Refri(70, -20);

            Random rnd = new Random();
                                          //ADICION DE LOS METODOS QUE SE TIENEN QUE EJECUTAR
            refri.adicionarMetodoReservas(new Refri.DReservasBajas(InformeKilos));
            refri.adicionarMetodoCongelado(new Refri.DDescongelado(InformeGrados));

            while(refri.Kilos > 0)
            {
                refri.trabajar(rnd.Next(1,3));
            }
            Console.ReadKey();
        }
        //CON LOS DELEGADOS TENEMOS COMUNICACION DEL OBJETO A COSAS DE PROGRAM
        //NO DE PROGRAM HACIA LOS OBJETOS SOLAMENTE SINO AL REVES
        //UN DELEGADO
        public static void InformeKilos(int kilo)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("estoy en main y me quedan {0} kilos", kilo);
            //aqui se puede colocar codigo 
        }
        //UN DELEGADO
        public static void InformeGrados(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("estoy en main y tengo {0} grados ", grados);
        }
    }


}
