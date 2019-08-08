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
            //metodo sin nombre y colocarlo al delegado

            Punto punto = new Punto(5, 6);
            
            punto.Delmensaje += delegate (string nombre)
            {
                Console.WriteLine("metodo anonimo de nombre {0}", nombre);
            };

            punto.Delmensaje("juan");


            punto.Delmensaje += delegate (string apellido)
            {
                Console.WriteLine("metodo anonimo de apellido {0}", apellido);
            };

            punto.Delmensaje("perez");

            Console.ReadKey();
        }
    }
}
