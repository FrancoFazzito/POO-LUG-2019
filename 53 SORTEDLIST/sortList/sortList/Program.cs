using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList list = new SortedList();

            list.Add(15, "juan1");
            list.Add(160, "juan2");
            list.Add(1222, "juan3");
            list.Add(11, "juan4");
            //juan 1 2 3 para mostrar como se ordena

            foreach (DictionaryEntry element in list)
            {
                Console.WriteLine("LLAVE {0} y VALOR {1}", element.Key, element.Value);
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Contains(15));
            Console.WriteLine(list.ContainsValue("juan"));
            Console.WriteLine(list.ContainsValue("juan1"));
            Console.WriteLine(list.ContainsKey(15));
            Console.WriteLine(list.ContainsKey(1545));
            Console.WriteLine(list.GetKey(2)/*llave del indice 2*/);
            Console.WriteLine(list.GetByIndex(2) /*valor del indice 2*/);
            Console.ReadKey();
        }
    }
}
