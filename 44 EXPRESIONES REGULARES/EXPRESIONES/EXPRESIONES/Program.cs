using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace EXPRESIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            //expresion en el texto
            string texto = "casa de juan";
            string buscar = "casa "; /*espacio para solo casa*/

            MatchCollection matchCollection = Regex.Matches(texto, buscar);

            foreach (Match item in matchCollection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(">-------<");

            // string buscar2 = "cas."; el punto es la consecutiva de cualquier caracter
            //busqueda solo de una especifica
            string texto2 = "casanova de alfonso";
            string buscar2 = "casa";

            Regex regex = new Regex(buscar2);

            matchCollection = regex.Matches(texto2);

            foreach (Match item in matchCollection)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
