using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepciones_multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            caldera caldera = new caldera(marca: "escorial", temperatura: 10);
            while (caldera.Funciona)
            {
                try
                {
                    caldera.Trabajar(-100);
                }
                //catch (Exception e)
                //{

                //    Console.WriteLine("el mensaje {0}", e.Message);
                //}
                catch (calderaExepcion e) /*no puede recibir exeption solo su tipo*/
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.Momemto);
                    Console.WriteLine(e.Causa);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    /*saltea los catch que no son de esa clase*/

                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("se hace al final luego del try catch sea donde fuere");
                }
            }

            /*EXEPCIONES TIENEN QUE SER DESDE LA MAS CHICA HASTA LA MAS GRANDE*/
            /*POR TEMAS DE HERENCIA SI ES EXCEPTION SIEMPRE VA SER ELLA*/
            /*CAPTURANDO TODO*/
            /*POR ESO TIENE QUE SER DESDE EL MAS CHCIO HASTA EL MAS GRANDE*/
            /*DE LO PARTICULAR A LO GENERAL*/
            /*TRY CATCH (SIN NADA) ES GENERICO SOLO DICE CUANDO FALLO*/
            /*SE PUEDE ANIDAR*/
            //try
            //{
            //    try
            //    {

            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            Console.ReadKey();
        }
    }
}
