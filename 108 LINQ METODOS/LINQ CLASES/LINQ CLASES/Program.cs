using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> RESULTADOS = ClaseExplicita.obtenerNumerosPares();
            foreach(int n in RESULTADOS)
            {
                Console.WriteLine(n);
            }
            IEnumerable<string> postres = ClaseExplicita.GetEncontrados();
            foreach (string palabraEncontrada in postres)
            {
                Console.WriteLine(palabraEncontrada);
            }
            int[] impares = ClaseExplicita.obtenerNumerosImpares();
            foreach (int item in impares)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
