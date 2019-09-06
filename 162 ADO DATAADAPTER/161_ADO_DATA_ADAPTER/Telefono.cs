using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161_ADO_DATA_ADAPTER
{
    public class Telefono
    {
        private string numero;

        public Telefono(string numero)
        {
            this.numero = numero ?? throw new ArgumentNullException(nameof(numero));
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

    }
}
