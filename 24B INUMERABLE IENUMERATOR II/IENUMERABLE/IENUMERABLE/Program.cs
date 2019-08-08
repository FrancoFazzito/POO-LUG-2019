using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IENUMERABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Contenedor contenedor = new Contenedor();

            foreach(int valor /* Y SE HACE EL CAST EN LA VARIABLES*/ in contenedor)
            {
                Console.WriteLine(valor);
            }

            //1 NECESITA EL ENUMERATOR DE DATOS
            Console.ReadKey();
        }
    }
}
