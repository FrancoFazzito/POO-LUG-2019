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
            while (caldera.Funciona)
            {
                try
                {
                    caldera.Trabajar(100);
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
            }


            Console.ReadKey();
        }
    }
}
