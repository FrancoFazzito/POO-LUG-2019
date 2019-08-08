using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            /*refleccion -> info sobre el assmebly*/
            try
            {
                Type T = Type.GetType("System.Console");
                Caracteristicas(T);
                campos(t: T);
                //Type T2 = Type.GetType("using System.Collections.ArrayList");
                //Caracteristicas(T2);
                //campos(t: T2);
            }
            catch (Exception)
            {

                throw;
            }

            Console.ReadKey();
        }

        public static void Caracteristicas(Type t)
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", t.BaseType, t.IsClass, t.IsSealed, t.IsGenericTypeDefinition, t.IsSealed);
        }
        public static void campos(Type t)
        {
            /*guarda en F los campos de T y selecciona el nombre de esta F*/
            var nombres = from f in t.GetFields() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
            var nombresmethod = from f in t.GetMethods() select f.Name;
            foreach (var nombre in nombresmethod)
            {
                Console.WriteLine("{0}", nombre);
            }
            var nombresInterfaz = from f in t.GetInterfaces() select f.Name;
            foreach (var nombre in nombresInterfaz)
            {
                Console.WriteLine("{0}", nombre);
            }
        }
    }
}
