using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_generico
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("x = {0} , y = {1}", x, y);

            Intercambio<int>(ref x, ref y); /*version de intercambio donde tenemos un int para todas las T*/

            Console.WriteLine("x = {0} , y = {1}", x, y);

            double a = 1;
            double r = 12.54;

            Console.WriteLine("x = {0} , y = {1}", x, y);

            Intercambio<double>(ref a, ref r);

            Console.WriteLine("x = {0} , y = {1}", x, y);
        }

        /*ejecutar en main para static*/
        static /*T return generico*/ void /*sin return*/ Intercambio<T>/*utiliza generico*/(ref T a/*generico*/, ref T b/*generico*/)
        {
            T temporal;

            temporal = a;

            a = b;

            b = temporal;

            //return temporal;
            /*haciendo un swap*/

        }
    }
}
