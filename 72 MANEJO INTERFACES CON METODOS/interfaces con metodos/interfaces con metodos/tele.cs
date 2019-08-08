using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_con_metodos
{
    class tele : IElectronico
    {
        private string marca;

        public tele(string marca)
        {
            this.marca = marca ?? throw new ArgumentNullException(nameof(marca));
        }

        public string Marca { get => marca; set => marca = value; }

        public override string ToString()
        {
            return string.Format("el telvisor es marca {0}", marca);
        }

        public void encender(bool interruptor)
        {
            if(interruptor)
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
