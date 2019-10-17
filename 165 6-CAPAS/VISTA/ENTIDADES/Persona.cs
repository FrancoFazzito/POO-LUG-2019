namespace ENTIDADES
{
    public class Persona
    {
        private int codigo;
        private string nombre;
        private string apellido;

        public Persona(int codigo, string nombre, string apellido)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona()
        {

        }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }

        public override string ToString()
        {
            return $"Codigo[{this.codigo}]: {this.nombre} {this.apellido}";
        }
    }
}
