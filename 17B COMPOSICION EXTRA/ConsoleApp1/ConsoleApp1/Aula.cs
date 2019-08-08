using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aula
    {
        private string nombre;
        private int CantidadDeAlumnos;

        public Aula(string nombre, int cantidadDeAlumnos)
        {
            this.nombre = nombre;
            CantidadDeAlumnos = cantidadDeAlumnos;
        }

        public override string ToString()
        {
            string mensaje = string.Format("El aula es {0}, tiene {1} alumnos", nombre, CantidadDeAlumnos);
            return mensaje;
        }
    }

}
