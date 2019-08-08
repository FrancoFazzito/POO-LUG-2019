using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class empleado : Persona
    {
        //EMEPLEADO HEREDO EL NOMBRE Y EDAD DE PERSONA
        private string puesto;
        private double salario;

        public empleado(string puesto, double salario, string nombre, int edad) : base (nombre, edad)
        {
            //SE HEREDA EL CONSCTRUCTOR BASE 
            //LOS DOS DE PUESTO DE EMEPLEADO + BASE QUE SERIA PERSONA SERIA NOMBRE Y EDAD
            //QUEDANDO 2 DE EMPLEADO Y DOS DE PERSONA
            Console.WriteLine("entrando al constructor EMPLEADO");
            this.puesto = puesto;
            this.salario = salario;
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
