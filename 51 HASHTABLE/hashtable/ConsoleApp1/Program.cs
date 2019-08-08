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
            //hashtable -> va a depender de la funcion de hash y el parametro es un key y unvalue que es su valor
            //guarda una llave con el valor 
            //
            Hashtable Tabla = new Hashtable();
                    //ID   //NOMBRE
            Tabla.Add(123, "juan");
            Tabla.Add(234, "pepe");
            Tabla.Add(456, "maria");

            //guardamos en un tipo diccionaryentry que tiene la dupla de key y value para poder mostrar
            foreach (DictionaryEntry elemento in Tabla)
            {
                Console.WriteLine("KEY O ID {0}, VALUE O VALOR DEL ID OSEA NOMBRE {1}", elemento.Key, elemento.Value);
            }
            Console.WriteLine(Tabla.Count);
            Console.WriteLine(Tabla.ContainsKey(123));
            Console.WriteLine(Tabla[123]);
            Console.WriteLine(Tabla.ContainsValue("juan"));
            Tabla[123] = "juan sobreescrito";
            Tabla[300] = "tambien adiciona si no existe";
            Console.WriteLine("eliminamos a {0} con nombre {1}", 456 , Tabla[456]);
            Tabla.Remove(456);
            foreach(int llaves in Tabla.Keys)
            {
                Console.WriteLine("{0}", llaves);
            }
            foreach(string values in Tabla.Values)
            {
                Console.WriteLine("{0}", values);
            }

            Hashtable clon = new Hashtable();
            clon = (Hashtable)Tabla.Clone();

            foreach (int llaves in clon.Keys)
            {
             
                Console.WriteLine("clon {0}", llaves);
            }
            foreach (string values in clon.Values)
            {
                Console.WriteLine("clon {0}", values);
            }
            //lento escribir rapido para leer
            //no podemos tener elementos con la misma llave
            Console.ReadKey();
        }
    }
}
