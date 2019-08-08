using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class estudiante
    {
        private string nombre;
        private int id;

        public estudiante(string nombre, int id)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("estudaintye {0} con id {1}", nombre, id);
        }
    }
    class curso
    {
        private string nombre;
        private int id;

        public curso(string nombre, int id)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("estudaintye {0} con id {1}", nombre, id);
        }
    }
}
