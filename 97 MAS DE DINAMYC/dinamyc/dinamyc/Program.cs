using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinamyc
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                dynamic texto = "hola";
                //int n = texto.Length; prueba del exception
                int n = texto.Length; /*perdida de intelinsense*/
                texto = texto.ToUpper(); /*ya que no es fuertemente tipificada*/
                                         /*riesgo*/
                Console.WriteLine("{0}, {1}", n, texto);
                Console.ReadKey();
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                //throw;
            }
            Console.ReadKey();
        }
    }
}
