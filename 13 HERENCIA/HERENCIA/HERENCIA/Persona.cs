using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class Persona
    {
        private string nombre;
        private int edad;

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
                if (value >= 18)
                {
                    edad = value;
                }
                else
                {
                    edad = -1;
                    Console.WriteLine("no permitido");
                }
            }
        }
        public void muestra()
        {
            Console.WriteLine("edad es {0} y nombre es {1}", edad, nombre);
        }
    }
}
