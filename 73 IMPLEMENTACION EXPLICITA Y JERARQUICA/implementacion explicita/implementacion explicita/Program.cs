using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacion_explicita
{
    class Program
    {
        static void Main(string[] args)
        {
            /*dos interfaces con el mismo nombre de atributo*/

            cuadrado cuadrado = new cuadrado(5);

            ((IPerimetro)cuadrado).calcular(); /*tipe cast a perimetro para poder invocar el metodo de esa interfaz*/
            ((IArea)cuadrado).calcular(); /*tipe cast a perimetro para poder invocar el metodo de esa interfaz*/
            /*interfaz que necesita de otra interfaz*/
            Console.ReadKey();
        }
    }
}
