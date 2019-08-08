using System;
using System.Collections;
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
            // COLECCIONES DENTRO DE SYSTEM.COLLECTIONS
            //ARRAYLIST
            //BITARRAY
            //HASHTABLE (K,V)
            //QUEUE
            //SORTEDLIST (K,V) K,[]
            //STACK

            ArrayList palabras = new ArrayList();
            //parecido a list que es un arreglo dinamico

            //addrange envia una coleccion
            palabras.AddRange(new string[] { "hola", "como", "estas" });
            Console.WriteLine("cantidad de elementos es {0}", palabras.Count);

            for (int i = 0; i < palabras.Count; i++)
            {
                Console.WriteLine("en lugar {0} esta {1}",i , palabras[i]);
            }

            Console.WriteLine("-------");


            palabras.Add("bien y vos ?");

            int count = -1; 
            foreach (string item in palabras)
            {
                count++;
                Console.WriteLine("{0}, lugar {1}", item, count);
            }
            Console.WriteLine("-------");
            ArrayList numeros = new ArrayList();
            numeros.Add(5);
            numeros.Add(4);
            numeros.Add(3);
            numeros.Add(2);
            int r = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                //Console.WriteLine("en lugar {0} esta {1}", i, numeros[i]);
                r = (int)numeros[i]; /*casteo de object a int*/
                Console.WriteLine(r);
            }
            Console.WriteLine("-------");
            Console.WriteLine(numeros.Contains(5));
            Console.WriteLine(numeros.Contains(12));
            Console.WriteLine("-------");
            numeros.Insert(2, 55);
            for (int i = 0; i < numeros.Count; i++)
            {

                r = (int)numeros[i]; /*casteo de object a int*/
                Console.WriteLine(r);
            }
            Console.WriteLine("-------");
            numeros.Remove(3);
            for (int i = 0; i < numeros.Count; i++)
            {

                r = (int)numeros[i]; /*casteo de object a int*/
                Console.WriteLine(r);
            }
            Console.WriteLine("-------");
            numeros.RemoveAt(0);
            for (int i = 0; i < numeros.Count; i++)
            {

                r = (int)numeros[i]; /*casteo de object a int*/
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }
    }
}
