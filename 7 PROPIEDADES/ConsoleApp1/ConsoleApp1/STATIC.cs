using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class STATIC
    {
        /*EL ATRIBUTO ESTATICO ES IGUAL A TODAS SUS CLASES A 10 B 10 C 10 ES UN VALOR IGUAL PARA TODAS LAS CLASES*/
        /*CAMBIA EN UNA Y CAMBIAN EN TODAS A 10 B 10 C 10 CAMBIO DEL ATRIBUTO STATIC A 15 B 15 C 15 */
        /*se puede usar sin intancia*/
        private static int numero;

        static STATIC() /*constructor estatico */
        {
            Console.WriteLine("estas en contructor");
            numero = 33; /*SOLO SE CREA EL CONSTRUCTOR SOLO 1 VEZ*/
        }

        /*se puede usar sin intancia*/
        public static void imprimir()
        {
                     /*se tiene que usar un atributo estatico*/
            Console.WriteLine("el numero es {0}", numero);
        }
    }
}
