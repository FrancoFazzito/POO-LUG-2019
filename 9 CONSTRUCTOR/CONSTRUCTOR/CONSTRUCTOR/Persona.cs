using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR
{
    class Persona
    {
        private int edad;
        private string nombre;

        //public Persona()
        //{
        //    nombre = "";
        //    edad = 0;
        //}

        //SOBRECARGA 1
        public Persona()
        {
            Console.WriteLine("dame nombre");

            nombre = Console.ReadLine();

            Console.WriteLine("dame edad");

            edad = int.Parse(Console.ReadLine());

        }


        //SOBRECARGA 2
        public Persona(int edad, string nombre)
        {
            this.nombre = nombre;
            this.edad = edad;
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public void muestra()
        {
            Console.WriteLine("el nombre es {0} y sus edad es {1}", nombre, edad);
        }
    }

}
