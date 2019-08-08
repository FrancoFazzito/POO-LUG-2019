using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<estudiante> estudiantes = new List<estudiante>()
            {
                new estudiante("juan", 123),
                new estudiante("juan1", 124),
                new estudiante("juan2", 125),
                new estudiante("juan3", 126),
                new estudiante("juan4", 127),
            };
            List<curso> cursos = new List<curso>()
            {
                new curso("programacion",125),
                new curso("programacion1",123),
                new curso("programacion2",124),
                new curso("programacion3",123),
            };
            var listado = from e in estudiantes join c in cursos on e.Id equals c.Id 
                          into templistado select new { estudiante = e.Nombre, templistado };
            foreach (var item in listado)
            {
                Console.WriteLine(item.estudiante);
                foreach (var itemListado in item.templistado)
                {
                    Console.WriteLine(itemListado);
                }
            }
            //Console.WriteLine( "salu2");
            string[] helados = { "chocolate", "vainilla", "dulce de leche", "eulce de leche", "aulce de leche" };
            string[] helados2 = { "chocolate2", "vainilla2", "dulce de leche2" };

            IEnumerable<string> Zip = helados.Zip(helados2, (h1, h2) => "helado de " + h1 + "con helado de " + h2);
            foreach (string item in Zip)
            {
                Console.WriteLine(item);
            }
            int[] numeros = { 15, 2, 36, 4, 5, 46, 7, 8, 9, 101 };
            IEnumerable<int> numerosASC = numeros.OrderBy(n => n);
            IEnumerable<int> numerosDES = numeros.OrderByDescending(n => n);
            foreach (int item in numerosASC)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            foreach (int item in numerosDES)
            {
                Console.WriteLine(item);
            }
            /*primeros por letras y luego por alfabeto*/
            IEnumerable<string> heladosOrder = helados.OrderBy(p => p.Length).ThenBy(p => p);
            foreach (string item in heladosOrder)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------");
            string[] archivos = System.IO.Directory.GetFiles("c:\\");
            var archivosgroup = archivos.GroupBy(a => System.IO.Path.GetExtension(a));
            foreach (IGrouping<string, string> item in archivosgroup)
            {
                Console.WriteLine("key extension {0}", item.Key);
                foreach (var archivo /*ARCHIVOS QUE CONTIENEN ESA LLAVE*/ in item)
                {
                    Console.WriteLine("\t {0}", archivo);
                }
            }
            int primero = numeros.First();
            Console.WriteLine(primero);
            int primeroQUE = numeros.First(n => n % 2 == 0);
            Console.WriteLine(primeroQUE);
            int primeroQUEDEFAULT = numeros.FirstOrDefault(n => n % 54 == 0);
            Console.WriteLine(primeroQUEDEFAULT);
            int suma = numeros.Sum();
            Console.WriteLine(suma);
            /*toma como semilla 0 sino se toma el primer valor*/
            int agregado = numeros.Aggregate(0, (t, n) => t + (n * 2)); /*en t siendo el valor del agregare se guarda N por 2 siendo n el valor del numero*/
            /*0 es incializacion en 0**/
            Console.WriteLine(agregado);

            bool todos = numeros.All(n => n < 10);
            Console.WriteLine(todos);
            int[] hola = { 1, 2, 3, 4, 5, 6 };
            IEnumerable<int> numeros2 = hola; 
            /*iguales en las dos secuencias*/
            bool iguales = numeros.SequenceEqual(numeros2);
            var vacia = Enumerable.Empty<int>(); //var que contiene una secuencia vacia
            foreach (var item in vacia)
            {
                Console.WriteLine(item);
            }
            var repeat = Enumerable.Repeat("hola", 5);
            foreach (var item in repeat)
            {
                Console.WriteLine(item);
            }
            var rango = Enumerable.Range(5, 15);
            foreach (var item in rango)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
