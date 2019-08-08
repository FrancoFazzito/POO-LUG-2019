using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lasclases; /*cargamos otro namespace*/
using otraclases;
/*todo lo del proyecto esta referenciado por el namespace*/
//using pruebaCreacion.lasclases;
using alias = lasclases.clases2;
using secundario = otraclases.clases2;



namespace namespace_propio
{
    /*clases no estan en el mismo namespace*/
    class Program
    {
        static void Main(string[] args)
        {
            otraclases.clases clases = new otraclases.clases(); /*ambiguo por que no sabe cual es*/
            /*si estan en el mismo proyecto*/
            lasclases.clases2 clases2 = new lasclases.clases2(); /*asi se resuelve*/
            /*totalmente calificado*/

            alias alias = new alias();
            
            Console.ReadKey();
        }
    }
}
