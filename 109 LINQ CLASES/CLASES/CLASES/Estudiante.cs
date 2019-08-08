using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    class Estudiante
    {
        private string nombre;
        private string id;
        private string curso;
        private double preomedio;

        public Estudiante(string nombre, string id, string curso, double preomedio)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.id = id ?? throw new ArgumentNullException(nameof(id));
            this.curso = curso ?? throw new ArgumentNullException(nameof(curso));
            this.preomedio = preomedio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public string Curso { get => curso; set => curso = value; }
        public double Preomedio { get => preomedio; set => preomedio = value; }

        public override string ToString()
        {
            return string.Format("nombre: {0}, {1}, curso: {2} promedio {3}", nombre, id, curso, preomedio);
        }
    }
}
