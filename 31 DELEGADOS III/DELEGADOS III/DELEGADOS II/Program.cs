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
            //VAMOS A VER VARIOS METODOS
            Refri refri = new Refri(70, -20);

            Random rnd = new Random();

            DReservasBajas kilos = new DReservasBajas(InformeKilos);/*NEW DELEGADO DE DE METODO INFORME KILOS*/
            DReservasBajas viveres = new DReservasBajas(Tienda.MandaViveres); /*NEW DELEGADO DE LA FUNCION DEL METODO DE LA CLASE TIENDA*/
            DDescongelado grados = new DDescongelado(InformeGrados);/*NEW DELEGADO DE DE METODO INFORME GRADOS*/

            refri.adicionarMetodoReservas(kilos); /*ADICION DE DELEGADO A LA CLASE DONDE GUARDAN SUS DELEGADOS*/
            refri.adicionarMetodoReservas(viveres); /*ADICION DE DELEGADO A LA CLASE DONDE GUARDAN SUS DELEGADOS*/
            refri.adicionarMetodoCongelado(grados); /*ADICION DE DELEGADO A LA CLASE DONDE GUARDAN SUS DELEGADOS*/

            while (refri.Kilos > 0)
            {
                refri.trabajar(/*CONSUMO*/ 1);
            }
            Console.ReadKey();
        }

        public static void InformeKilos(int kilo)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("estoy en main y me quedan {0} kilos", kilo);
        }


        public static void InformeGrados(int grados)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("estoy en main y tengo {0} grados ", grados);
        }
    }


}
