using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DESCONECTADO
{
    class Cliente
    {
        private int codigo;
        private string nombre;
        private string apellido;

        public Cliente(int codigo, string nombre, string apellido)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        
    }
}
