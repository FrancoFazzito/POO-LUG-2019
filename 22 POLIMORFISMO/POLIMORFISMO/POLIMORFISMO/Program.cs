using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIMORFISMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //EL POLIMORFISMO CONSISTE EN PODER TENER UN TIPO DE VARIABLE QUE PUEDE ACTUAR COMO SI FUERA DISTINTAS CLASES
            //POLIMORFICA MUCHAS FORMAS

            //CONCRETO ES CUANDO SE REFIERE A LA MISMA CLASE
            //GATO AAA = NEW GATO
            //REPTIAL BBB = NEW REPTIL
            //PERO NO GATO CCC = NEW REPTIL

            ANIMAL mascota = new ANIMAL();

            Console.WriteLine("---");
            mascota = new Perro();
            mascota.Nombre = "perro jorge";
            mascota.moverse();

            Console.WriteLine("---");
            mascota = new Pez();
            mascota.Nombre = "pez pepe";
            mascota.moverse();

            Console.WriteLine("---");
            mascota = new Gato();
            mascota.Nombre = "gato jose";
            mascota.moverse();

            Console.WriteLine("---");
            mascota = new Ave();
            mascota.Nombre = "ave juan";
            mascota.moverse();

            Console.WriteLine("---");
            mascota = new Reptil();
            mascota.Nombre = "reptil juana";
            mascota.moverse();


            Console.ReadKey();
        }
    }
}
