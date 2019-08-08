using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reconocimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //saber si un objeto implementa a un interfaz

            Ctelevisor TV = new Ctelevisor("jvc");
            Cpelota Pelota = new Cpelota("grande");
            IElectronico objeto = null;

            try
            {
                objeto = (IElectronico)TV;
                objeto.encender(true);
            }
            catch (InvalidCastException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                objeto = (IElectronico)Pelota;
                objeto.encender(true);
            }
            catch (InvalidCastException e)
            {

                Console.WriteLine(e.Message);
            }

            objeto = TV as IElectronico;

            /*si puede ser tratado hace la instancia sino null*/

            /*if(!null) es (null) no es */

            if(TV is IElectronico)
            {
                //implementa
            }
            else
            {
                //no implementa
            }
        }
    }
}
