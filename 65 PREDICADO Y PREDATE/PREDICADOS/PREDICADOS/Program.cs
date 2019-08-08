using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREDICADOS
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }); /*addrange nos permite meter un arreglo*/
            /*predicates de parametros*/
            foreach (int item in numeros)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //predicado nos va representar a un metodo que define un criterio si lo que esta por parametro lo cumple
            Predicate<int> delegadoPares = new Predicate<int>(NumerosPares);
            /*colocamos el metodo a recibir*/
            /*si es true lo pone en predicado y si es false no*/
            List<int> pares = numeros.FindAll(delegadoPares);
           
            /*hacemos una lista de pares y con find all buscamos todos los elementos que para el predicado fueron verdaderos*/
            foreach (int item in pares)
            {
                Console.Write(item + " ");
            }
            /*remove all elminando los que pediste al predicado*/
            /*exist tambien esta*/
            Console.ReadKey();
        }

        static bool NumerosPares(int numeros)
        {
            /*criteio*/
            if(numeros % 2 ==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
