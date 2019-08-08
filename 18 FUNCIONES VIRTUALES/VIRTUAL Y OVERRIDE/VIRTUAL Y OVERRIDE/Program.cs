using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL_Y_OVERRIDE
{
    class Program
    {
        static void Main(string[] args)
        {
            Productocs bici = new Productocs("bici", 100.50 );
            bici.CalculaPrecio();
            bici.muestraVemta();

            Console.WriteLine("----");

            productoImportado biciI= new productoImportado("bici importada", 100.50 , 0.5);

            biciI.CalculaPrecio();
            biciI.muestraVemta();

            ProductoDetenido biciM = new ProductoDetenido("bici detenida", 100.50, 0.5, 500);

            Console.WriteLine("----");

            biciM.CalculaPrecio();
            biciM.muestraVemta();

            Console.ReadKey();
            
        }
    }
}
