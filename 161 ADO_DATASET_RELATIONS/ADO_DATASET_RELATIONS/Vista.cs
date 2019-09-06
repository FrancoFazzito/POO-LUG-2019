using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DATASET_RELATIONS
{
    class Vista
    {
        private string numero;

        public Vista(string numero)
        {
            this.numero = numero;
        }

        public string Numero { get => numero; }
    }
}
