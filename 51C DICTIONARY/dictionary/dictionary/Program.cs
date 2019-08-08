using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
                 //CADA ID TIENE UN EMPLEADO
            Dictionary<int, string> DICCIONARIO = new Dictionary<int, string>();

            DICCIONARIO.Add(15, "juan");
            DICCIONARIO.Add(16, "pepe");
            DICCIONARIO.Add(17, "manolo");
            DICCIONARIO.Add(19, "flor");
            Console.WriteLine(DICCIONARIO[15]);
            foreach(KeyValuePair<int,string> entry in DICCIONARIO)
            {
                Console.WriteLine("key {0} value {1}", entry.Key, entry.Value);
            }

           

            Dictionary<int, persona> DiccionarioPersona = new Dictionary<int, persona>();

            DiccionarioPersona.Add(4000, new persona(15, "juan"));

            foreach (KeyValuePair<int, persona> entry in DiccionarioPersona)
            {
                Console.WriteLine("key {0} value persona id {1} y nombre {2}", entry.Key, ((persona)entry.Value).Id, ((persona)entry.Value).Nombre);
            }
            string valor = DICCIONARIO.ContainsKey(15) ? DICCIONARIO[15] : null;

            List<persona> personas = DiccionarioPersona.Values.ToList();

            Console.WriteLine(valor);
            Console.ReadKey();

            //A Hashtable is a non - generic collection.
            //A Dictionary is a generic collection.
            //In Hashtable, you can store key/value pairs of the same type or of the different type.
            //In Dictionary, you can store key/value pairs of same type.
            //In Hashtable, there is no need to specify the type of the key and value.
            //In Dictionary, you must specify the type of key and value.
            //The data retrieval is slower than Dictionary due to boxing/ unboxing.
            //The data retrieval is faster than Hashtable due to no boxing/ unboxing.
            //It doesn’t maintain the order of stored values.
            //It always maintain the order of stored values.
            Console.ReadKey();
        }
    }
    class persona
    {
        private int id;
        private string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public persona(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
        }


    }
}
