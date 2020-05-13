using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictFunc
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Func<string>> diccionario = new Dictionary<string, Func<string>>();

            diccionario.Add("jefe", holaJefe);
            diccionario.Add("cliente", holaCliente);
            diccionario.Add("empleado", holaEmpleado);

            string hola = diccionario["jefe"].Invoke();

            Console.WriteLine(hola);

            Console.Read();
        }

        public static string holaCliente()
        {
            return "hola cliente";
        }

        public static string holaJefe()
        {
            return "hola jefe";
        }

        public static string holaEmpleado()
        {
            return "hola empleado";
        }
    }
}
