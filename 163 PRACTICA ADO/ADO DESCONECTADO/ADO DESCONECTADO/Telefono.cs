using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DESCONECTADO
{
    class Telefono
    {
        private int codigo;
        private string numero;

        public Telefono(int codigo, string numero)
        {
            this.codigo = codigo;
            this.numero = numero;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Numero { get => numero; set => numero = value; }
    }
}
