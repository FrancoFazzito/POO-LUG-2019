using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR_NULEABLE_DYNAMIC
{
    class Program
    {
        static void Main(string[] args)
        {
            //delcaracion implicita de variables con var

            var a = 6; /*solo en locales ni generales ni en retorno*/
            var b = "aaa"; /*cuando no sabemos el tipo que llegara */
            var c = 6.589; /*una vez asigando ya esta tipificado //d = 58;// */
            var d = true;
            
            /* var t = null; VAR NO ES NULO */
            
            Console.WriteLine(a);

            Console.WriteLine("a es {0}", a.GetType().Name);

            /*los nulleables pueden representar los valores mas el valor de null*/
            /*se asgina con ?*/
            
            int ? dato = 5;

            /*si ?? si dato es distinto de nulo*/
            int y = dato ?? -1;
            string example = "juan";

            string bar = (example == null ? example = "positivo" : example = "negativo");
            Console.WriteLine(bar);
            Console.WriteLine("valor de dato {0} valor y es {1}", dato, y);
            dato = null;

            if (dato.HasValue)
            {
                Console.WriteLine("dato {0} no nulo", dato.Value);
            }
            else
            {
                Console.WriteLine("nulo");
            }

            //string? aaa = "aa"; string no es nuleable ya que acpeta null
            //el ?? nos permite asignar si es nulo

            double? numero = Asignador() ?? 5.55;

            Console.WriteLine("dato {0} no nulo", numero.Value);

            dynamic DatoDinamico = 7; /*guarda cualquier valor pero no es fuertemente tipificado*/

            Console.WriteLine("tipo {0}, valor : {1}", DatoDinamico.GetType(), DatoDinamico);

            DatoDinamico = "hola"; /*dinamicamente cambia conociendo su tipo solo en ejecucion*/
            /*podemos poner retorno en dinamic*/
            Console.WriteLine("tipo {0}, valor : {1}", DatoDinamico.GetType(), DatoDinamico);


            Console.ReadKey();
        }

        public static double? Asignador()
        {
           // return 9.07;
            return null;
        }


    }
}
