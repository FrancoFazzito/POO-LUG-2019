using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_con_metodos
{
    class radio:IElectronico
    {
        private string marca;

        public radio(string marca)
        {
            this.marca = marca ?? throw new ArgumentNullException(nameof(marca));
        }

        public string Marca { get => marca; set => marca = value; }

        public void encender(bool interruptor)
        {
            if (interruptor)
            {
                Console.WriteLine("encendido");
            }
            else
            {
                Console.WriteLine("no encendido");
            }
        }
    }
}
