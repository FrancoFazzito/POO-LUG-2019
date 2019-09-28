using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Icollection
{
    class Program
    {
        private static int cantidad = 15;

        static void Main(string[] args)
        {
            List<int> listaInt = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                listaInt.Add(i);
            }

            int[] arrayInt = new int[10];
            for (int i = 0; i < arrayInt.Count(); i++)
            {
                arrayInt[i] = ++cantidad;
            }

            Coleccion<int> coleccion = new Coleccion<int>(listaInt);
            coleccion.AddRange(arrayInt);
            
            foreach (var item in listaInt)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(coleccion[10]);
            Console.Read();
        }
    }

    class Coleccion<T>
    {
        private ICollection<T> coleccion;

        public Coleccion(ICollection<T> coleccion)
        {
            this.coleccion = coleccion;
        }

        public void Add(T elemento)
        {
            this.coleccion.Add(elemento);
        }
        public void AddRange(ICollection elementos)
        {
            foreach (var elemento in elementos)
            {
                this.coleccion.Add((T)elemento);
            }
        }
        public void Remover(T elemento)
        {
            this.coleccion.Remove(elemento);
        }

        public ICollection<T> GetElementos()
        {
            return this.coleccion;
        }

        public T this[int index]
        {
            get
            {
                return this.coleccion.ElementAt(index);
            }
        }
    }
}
