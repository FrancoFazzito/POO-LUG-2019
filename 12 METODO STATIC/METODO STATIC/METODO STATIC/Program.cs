using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODO_STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            //SIN NEW SOLO ESTATICOS
            //SE PUEDE LLAMAR A LOS METODOS SIN HACER NEW DE LA CLASE
            Console.WriteLine("suma es" + Calculadoracs.suma(4, 4.5));
            Console.WriteLine("suma es" + Calculadoracs.resta(4, 4.5));
            Console.ReadKey();

            //si se hace new se usan LOS METODOS NO ESTATICOS
            //Calculadoracs.saludo();
            //Se requiere una referencia de objeto para el campo, método o propiedad 'Calculadoracs.saludo()' no estáticos

        }
    }
}
