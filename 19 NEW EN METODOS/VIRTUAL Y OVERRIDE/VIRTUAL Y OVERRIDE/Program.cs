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
            //CUANDO SE QUIERE HACER OVERRIDE DE UNA FUNCION NO VIRTUAL
            //SE TIENE QUE HACER NEW
            //PERDEMOS POLIMORFISMO 
            //VIRTUAL MANTIENE LO POLIMORFICO Y NEW NO
            productoImportado biciI = new productoImportado("bici importada", 100.50, 0.5);

            biciI.CalculaPrecio();
            biciI.muestraVemta();

            Console.WriteLine("---");

            Productocs tele = new Productocs("television", 10500);
            tele.CalculaPrecio();
            tele.muestraVemta();

            Console.WriteLine("---");

            // NEW DE OTRA CLASE POR TEMAS DE POLIMORFISMO
            Productocs p3 = new productoImportado("bicicleta", 2200, 0.2);
            //IMPRIME EL CALCULA PRECIO DE IMPORTADO
            p3.CalculaPrecio();
            //IMPRIME EL MUESTRA DE PRODCUTO COMUN (CLASE BASE) YA QUE SE PIERDE EL POLIMORFISMO EN NEW 
            p3.muestraVemta();
            //CON OVERRIDE HUBIERA SIDO IGUAL A PRIMERO 
            Console.ReadKey();
            
        }
    }
}
