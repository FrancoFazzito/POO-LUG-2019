using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTECTED_y_SEALED
{
    class Persona
    {
        //PUBLIC -> CUALQUIERA PUEDE TENER ACCESO A EL
        //PRIVADO -> SOLO EL MISMO OBJETO PUEDE ACCEDER ENTONCES EL EXTERIOR NO
        //PROTECTED -> PARA EL EXTERIOR PARA LA CADENA DE HERENCIA ES PUBLICO
        protected string nombre;
        protected int edad;

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
            Console.WriteLine("edad {0} nombre {1} ", edad, nombre);
        }
    }
}
