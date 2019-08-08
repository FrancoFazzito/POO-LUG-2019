using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*guarda en n donde los valores sean n > 3 y n < 8 y luego se lo selecciona con select para enviar*/
            IEnumerable<int> ValoresNumeros = from n in numeros where n > 3 && n < 8 select n;
            foreach (int num in ValoresNumeros)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------");
            string[] postres = { "a manzana", "z manzana", "pera", "dulce de leche", "cereza con manzana" };
            IEnumerable<string> valorPalabras = from p in postres where p.Contains("manzana") orderby p select p; /*orderby lo ordena mediante alfabeto*/
            foreach (string postre in valorPalabras)
            {
                Console.WriteLine(postre);
            }
            Console.WriteLine("---------");
            /*tipo implicito*/
            var valores = from n in numeros where n % 2 == 0 select n;

            /*ejecucion diferida hasta que no se itera no se evalua*/

            foreach (int valor in valores)
            {
                /*aca se ejecuta*/
                Console.WriteLine(valor);
            }
            Console.WriteLine("-----con ejeucion diferida----");

            var valores2 = from n in numeros where n % 2 == 0 select n;

            /*ejecucion diferida hasta que no se itera no se evalua*/
            numeros[1] = 12;

            foreach (int valor in valores2)
            {
                /*aca se ejecuta*/
                Console.WriteLine(valor);
            }

            List<int> listValores = (from n in numeros where n % 2 == 0 select n).ToList<int>();
            int[] arrayvalores = (from n in numeros where n % 2 == 0 select n).ToArray<int>();

            foreach (int valor in listValores)
            {
                Console.WriteLine(valor);
            }
            foreach (int valor in arrayvalores)
            {
                
                Console.WriteLine(valor);
            }
            Console.WriteLine("---------");
            Console.WriteLine("tipos es {0}", valorPalabras.GetType().Name);
            Console.WriteLine("---------");

            Console.ReadKey();
        }
    }
}
