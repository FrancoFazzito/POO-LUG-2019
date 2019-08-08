using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTECTED_y_SEALED
{
    //SELLADA HACIENDO QUE NO SE PUEDA HEREDAR DE ESTA
    sealed class Empleado : Persona
    {
        //EMEPLEADO HEREDO EL NOMBRE Y EDAD DE PERSONA
        private string puesto;
        private double salario;

        public Empleado(string puesto, double salario, string nombre, int edad)
        {
            //MUESTRA LA PROPIEDAD DEL ATRIBUTO DE NOMBRE YA QUE ES ATRIBUTO PRIVADO
            //this.Nombre = nombre;
            //MUESTRA LA PROPIEDAD DEL ATRIBUTO DE NOMBRE YA QUE ES ATRIBUTO PRIVADO
            //this.Edad = edad;
            //MAYUSCULA


            //NO MUESTRA LA PROPIEDAD DEL ATRIBUTO DE NOMBRE YA QUE ES ATRIBUTO PROTECTED
            this.edad = edad;
            //NO MUESTRA LA PROPIEDAD DEL ATRIBUTO DE NOMBRE YA QUE ES ATRIBUTO PROTECTED
            this.nombre = nombre;
            //NORMAL

            this.puesto = puesto;
            this.salario = salario;
        }
        public Empleado()
        {

        }

        public string Puesto
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }
        public void muestraempleado()
        {
            //REUTILIZO LA MUESTRA DE LA CLASE PADRE
            muestra();
            Console.WriteLine("TRABAJO ES {0} Y SALARIO ES {1}", puesto, salario);
        }
    }
}
