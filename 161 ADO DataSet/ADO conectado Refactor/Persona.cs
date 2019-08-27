using System;

namespace ADO_conectado_Refactor
{
    class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
        }

        public int Id { get { return this.id; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }

        public override string ToString()
        {
            return $"id:{this.id} nombre: {this.nombre} apellido: {this.apellido}";
        }
    }
}
