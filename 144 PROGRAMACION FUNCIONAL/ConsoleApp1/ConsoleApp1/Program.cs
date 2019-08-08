using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
       static void Main(string[] args)
       {
            Numbers nums = new Numbers();
            //nums.displayNonFunctional();
                            /*envio lista*/         /*la accion que se debe usar*/
            Numbers.ForEach(Enumerable.Range(0, 10),Numbers.display);

            Console.WriteLine("------------------------");

            List<int> numeritos = new List<int> { 1, 2, 36, 4,35, 16, 17, 28, 48, 101 };

            
            Numbers.ForEach(numeritos, Numbers.display);
            /*primer dato*//*segundo dato*//*valor de retorno*/  /*creamos 2 param*/   /*asignamos la funcion suma*/
            Func    <int , int, int >        funcAritmetico =       (x, y)           => Numbers.suma(x, y);

            int result = funcAritmetico(4, 3);
            Console.WriteLine(result);

            Func<int, int> f = (x) => x + 5; /*se declara con luego del = los param () y con => la asignacion de lo que tiene que hacer*/
            Func<int, int> g = (x) => x + 3;
            Func<Func<int, int>/*F*/, Func<int, int>/*G*/, int/*X*/, int/*return*/> gof = (f1, g1, x) => f1.Invoke(5) + g1.Invoke(7) + x;
            Action<int, int> suma = new Action<int, int>(sum);
            Action<int, string> concatIntString = (x, y) => mensajeConcat(x, y);
            concatIntString.Invoke(4, "hola");
            
            //estadisticas
            //t[] => numero o bool // any o count
            var lista = Enumerable.Range(1, 10);
            double total = lista.Sum();
            Console.WriteLine(total);
            List<int> listacuadrado = lista.Select(e => e * e).ToList();
            foreach (int item in listacuadrado)
            {
                Console.WriteLine(item);
            }
            foreach (int item in lista)
            {
                Console.WriteLine(item);
            }
            
            IEnumerable<int> encontrado = from parametro in lista where parametro % 2 == 0 select parametro;

            int[] a = { 1,2,3 };
            int[] b = { 10, 20, 30 };
            int [] c = a.Zip/*elementos de dos secuencias*/(b, (e1, e2) => e1 * e2).ToArray();
            int totalvec = c.Sum();
            int d = a/*primer*/.Zip(b/*segundo*/, (valor, ponderacion) => valor * ponderacion).Sum();
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            var itemsrange = Enumerable.Range(2, 20);
            var bases = itemsrange.Select((p) => new
            {
                Base = 2 * p,
                altura = p * p - 1,
                hipotenusa = p * p + 1

            });
            foreach (var item in bases)
            {
                Console.WriteLine(item.altura);
                Console.WriteLine(item.Base);
                Console.WriteLine(item.hipotenusa);
            }

            int[] resultados = { 19, 13, 14, 15, 16 };
            var ejemplo = resultados.ToLookup/*conteo*/(
                k => k, k => resultados.Where(n => n >= k)


                ).Select(k => new
                {
                    result = k.Key /*look up*/,
                    rango = (double)k.First().Count() / resultados.Length * 10,
                    
                }

                );
            foreach (var item in ejemplo)
            {
                Console.WriteLine("  "+ item.rango + " " + item.result);
            }
            /*el primer elemento de una secuencia */
            //var look = resultados.ToLookup((k) => k).First(k => k.Count() > resultados.Length / 2).Key;
            //Console.WriteLine("    " + look);

            int[] billetes = { 10, 20, 50, 100, 200, 500,1000 };
            int monto = 100000;
            Dictionary<int, int> cantidad = new Dictionary<int, int>();
            billetes.OrderByDescending(n => n).ToList().ForEach(n =>
            {
                cantidad.Add(n, monto / n);
                monto = monto % n; /*plata que queda de la division*/
            });
            foreach (KeyValuePair<int, int> item in cantidad)
            {
                Console.WriteLine("dictionary key " + item.Key + " value " + item.Value);
            }
            Console.WriteLine(totalvec);
            Console.ReadKey();
            //t[] => u[] coleccion // select selectmany
            //t[] => t[] filtra por condicion // where first last
        }

        static void sum (int a, int b)
        {
            int c = a + b;
           
        }

        static void mensajeConcat(int a, string palabra)
        {
            Console.WriteLine("el numero es {0} con su frase {1}", a,palabra);
        }
    }

    public class Numbers{
        private int a;

        public int A { get => a; set => a = value; }

        public void displayNonFunctional()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ForEach<T>(IEnumerable<T> items /*coleccion*/, Action<T> action /*action es un delegate generico que devuelve void*//*funcion que quiero ejecutar sobre cada item*/)
        {
            foreach(T item in items)
            {
                action(item);
            }
        }

        public static IEnumerable<int> range (int from, int to)
        {
            for (int i = to; i < to; i++)
            {
                yield return i; /*yield se construye cuando se necesite*/
                /*no necesita evaluarse*/
            }
        }

        public static void display(int i)
        {
            Console.WriteLine(i);
        }

        public static int suma(int a, int b)
        {
            return a + b;
        }

        public static int resta(int a, int b)
        {
            return a - b;
        }
        public static int por(int a, int b)
        {
            return a * b;
        }
    }
}
