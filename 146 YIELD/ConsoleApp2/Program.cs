<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EjemploYield
    {
        public IEnumerable<int> getListNormal(int n,int start,int end)
        {
            List<int> multiples = new List<int>();
            for (int i = start; i < end; i++)
            {
                    multiples.Add(i); //SE RETORNA LA LISTA ENTERA
            }
            return multiples;
        }
        public IEnumerable<int> Yield(int n, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                    yield return i; //DEVUELVE VALOR CUANDO LO LLAMO
            }
        }
        public IEnumerable<int> getListNormal2(int n, int start, int end)
        {
            List<int> multiples = new List<int>();
            for (int i = start; i < end; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(
                        $"{i} GetMultiplesOf");
                    multiples.Add(i);
                }
            }
            
            return multiples;
        }
        public IEnumerable<int> Yield2(int n, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(
                        $"{i} YieldMultiplesOf");
                    yield return i;
                }
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EjemploYield ejemplo = new EjemploYield();
            IEnumerable<int> normalList = ejemplo.getListNormal(10, 1, 15);
            IEnumerable<int> yieldList = ejemplo.Yield(10, 1, 15);
            Console.WriteLine("NORMAL");
            foreach (var item in normalList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("YIELD");
            foreach (var item in yieldList)
            {
                Console.WriteLine(item);
            }

            //otro ejemplo
            Console.WriteLine("NORMAL");
            Console.WriteLine("otro ejemplo ");
            foreach (var item in ejemplo.getListNormal2(2,1,10))
            {
                Console.WriteLine($"{item} es multiplo de 2");
            }
            Console.WriteLine("YIELD");
            foreach (var item in ejemplo.Yield2(2, 1, 10))
            {
                Console.WriteLine($"{item} es multiplo de 2");
            }
            Console.ReadKey();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EjemploYield
    {
        public IEnumerable<int> getListNormal(int n,int start,int end)
        {
            List<int> multiples = new List<int>();
            for (int i = start; i < end; i++)
            {
                    multiples.Add(i); //SE RETORNA LA LISTA ENTERA
            }
            return multiples;
        }
        public IEnumerable<int> Yield(int n, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                    yield return i; //DEVUELVE VALOR CUANDO LO LLAMO
            }
        }
        public IEnumerable<int> getListNormal2(int n, int start, int end)
        {
            List<int> multiples = new List<int>();
            for (int i = start; i < end; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(
                        $"{i} GetMultiplesOf");
                    multiples.Add(i);
                }
            }
            
            return multiples;
        }
        public IEnumerable<int> Yield2(int n, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (i % n == 0)
                {
                    Console.WriteLine(
                        $"{i} YieldMultiplesOf");
                    yield return i;
                }
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EjemploYield ejemplo = new EjemploYield();
            IEnumerable<int> normalList = ejemplo.getListNormal(10, 1, 15);
            IEnumerable<int> yieldList = ejemplo.Yield(10, 1, 15);
            Console.WriteLine("NORMAL");
            foreach (var item in normalList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("YIELD");
            foreach (var item in yieldList)
            {
                Console.WriteLine(item);
            }

            //otro ejemplo
            Console.WriteLine("NORMAL");
            Console.WriteLine("otro ejemplo ");
            foreach (var item in ejemplo.getListNormal2(2,1,10))
            {
                Console.WriteLine($"{item} es multiplo de 2");
            }
            Console.WriteLine("YIELD");
            foreach (var item in ejemplo.Yield2(2, 1, 10))
            {
                Console.WriteLine($"{item} es multiplo de 2");
            }
            Console.ReadKey();
        }
    }
}
>>>>>>> 7f85a414ed6b84bdf726a283e9468a6c5e3979f0
