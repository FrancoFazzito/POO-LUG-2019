using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CLASES
{
    class ClaseExplicita
    {
        private static string[] postres = { "torta manzana ", "torta", "ensalada", "manzana caramelizada" };
        public static IEnumerable<string> encontrados = from p in postres where p.Contains("manzana") orderby p select p;

        public static IEnumerable<int> obtenerNumerosPares()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20 };
            IEnumerable<int> numerosPares = from n in numeros where n % 2 == 0 orderby n select n;
            return numerosPares;
        }
        public static IEnumerable<string> GetEncontrados()
        {
            return encontrados;
        }
        public static int [] obtenerNumerosImpares()
        {
            /*query inmediato */
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20 };
            var numerosPares = from n in numeros where n % 2 != 0 orderby n select n;
            return numerosPares.ToArray();
        }

    }
}
