using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> Inicio = numeros.Take(5);
            foreach (int item in Inicio)
            {
                Console.WriteLine(item);
            }
            IEnumerable<int> skip = numeros.Skip(5);
            foreach (int item in skip)
            {
                Console.WriteLine(item);
            }
            IEnumerable<int> reverse = numeros.Reverse();
            foreach (int item in reverse)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("primero es {0}", numeros.First());
            Console.WriteLine("ultimo es {0}", numeros.Last());
            Console.WriteLine("en 2 es {0}", numeros.ElementAt(2));
            Console.WriteLine("esta 5 ? {0}", numeros.Contains(5));
            Console.WriteLine("vacio ? {0}", numeros.Any());
            Console.WriteLine("multiplos de 5 ? {0}", numeros.Any(n => n % 5 == 0));
            //valor a 3 
            //query
            //valor a 2
            //impresion ERROR
            //el query se ejecuta cuando se imprime

            //subquery
            string[] casas = { "casa", "casa juan", "casa jose" };
            IEnumerable<string> resultados = casas.OrderBy(p => p.Split().Last()); //hara el query en base al subquery ya que al hacer split last se usa otro query

            //query progresivo
            string[] casaspro = {"nada", "casa", "casa juan", "casa jose","mi casa" };
            var casa = casaspro.Where(n => n.Contains("casa"));
            var ordenado = casa.OrderBy(n => n);
            var mayuscula = ordenado.Select(n => n.ToUpper());
            foreach (string item in mayuscula)
            {
                Console.WriteLine(item);
            }
            /*into hace reset del query*/
            var casajuan = from p in casaspro orderby p select p into juan where juan.Contains("juan") select juan;
            foreach (string item in casajuan)
            {
                Console.WriteLine(item);
            }
            var casajuan2 = from p in (from p1 in casaspro where p1.Contains("casa") orderby p1 select p1) where p.Contains("juan") select p;
            foreach (string item in casajuan2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
