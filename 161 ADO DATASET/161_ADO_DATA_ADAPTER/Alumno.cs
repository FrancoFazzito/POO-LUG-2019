using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161_ADO_DATA_ADAPTER
{
    public class Alumno
    {
        private string legajo;
        private string nombre;
        private string apellido;

        public Alumno(string legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Alumno()
        {

        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        public override string ToString()
        {
            return $"ID {this.legajo} con nombre {this.nombre} y apellido {this.apellido}";
        }
    }
}
