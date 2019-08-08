using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERACIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            //where subconjunto de elementos que satisfacen un if
            //take N numeros
            //skip N numeros
            //takewhile hasta que sea falso hace take
            //skipwhile hasta que sea falso hace skip
            string[] casas = { "casa", "casa juan", "oficina", "casa gaston" };

            //donde el indice es par
            IEnumerable<string> indice = casas.Where((n, i) => i % 2 == 0);
            foreach (string item in indice)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> start = from p in casas where p.StartsWith("casa") select p;
            foreach (string item in start)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> ends = from p in casas where p.EndsWith("juan") select p;
            foreach (string item in ends)
            {
                Console.WriteLine(item);
            }
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 13 };
            IEnumerable<int> takewhilenumeros = numeros.TakeWhile(n => n < 8);
            foreach (int item in takewhilenumeros)
            {
                Console.WriteLine(item);
            }
            IEnumerable<int> skipwhilenumeros = numeros.SkipWhile(n => n < 8);
            foreach (int item in skipwhilenumeros)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> select = casas.Select((p, i) => " indice " + i + " casa " + p);
            foreach (string item in select)
            {
                Console.WriteLine(item);
            }
            /*para cada elemento hace algo*/
            IEnumerable<string> selectMany = casas.SelectMany(p => p.Split());
            foreach (string item in selectMany)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> fromfrom = from p in casas from p1 in p.Split() select p1 + "====>" + p;
            foreach (string item in fromfrom)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string> fromfrom2 = from p in casas from p1 in casas select p1 + "p es " + p;
            foreach (string item in fromfrom2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
