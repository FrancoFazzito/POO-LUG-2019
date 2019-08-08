using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Caldera caldera = new Caldera(marca: "escorial" , temperatura: 10);

            //for (int i = 0; i < 10; i++)
            //{
            //    caldera.Trabajar(20);
            //}
            //*se quiere seguir trabajdno aunque no funcione*/
            //

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    caldera.Trabajar(20);
                }
                /*try riesgo  de producir exepcion*/
            }
            catch (Exception e/*tipos*/)
            {
                Console.WriteLine("sucedio la excepcion");
                Console.WriteLine("en este metodo {0}", e.TargetSite);
                Console.WriteLine("el trhow {0}", e.Message);
                Console.WriteLine("aplicacion que genero {0}", e.Source);
                Console.WriteLine("clase {0}",e.TargetSite.DeclaringType);
                Console.WriteLine("que es donde hubo error{0}",e.TargetSite.MemberType);
                Console.WriteLine("seguir el stack {0}",e.StackTrace);
                Console.WriteLine("anda a help link {0} y busca el error", e.HelpLink);

                if(e.Data != null)
                {
                    foreach (DictionaryEntry item in e.Data)
                    {
                        Console.WriteLine("key {0} y su valor {1}", item.Key, item.Value);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
