using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONS_Y_DEST
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona()
        {
            Console.WriteLine("dame edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("dame nombre");
            nombre = Console.ReadLine();
        }

        public Persona(string nombre, int edad)
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
            Console.WriteLine("edad {0} nombre {1}", this.edad, this.nombre);
        }

        //DESTRUCTOR
        //~ TILDE Persona NOMBRE DE LA CLASE ()NADA DE PARAMETROS
        ~Persona()
        {
            Console.WriteLine("ADIOS {0}", nombre);
            nombre = "";
            edad = 0;
        }
    }
}
