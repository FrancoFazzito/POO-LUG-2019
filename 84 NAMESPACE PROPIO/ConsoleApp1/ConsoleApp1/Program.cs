using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            AppSettingsReader lector = new AppSettingsReader();

            string nombre = (string)lector.GetValue("nombre" /*key*/ , typeof(string)); /*primero es nombre*/
            /*cast conviertiendo lo leido*/
            int edad = (int)lector.GetValue("edad", typeof(int));
            Console.WriteLine("{0} tiene {1}", nombre, edad);
            Console.ReadKey();
        }
    }
}
