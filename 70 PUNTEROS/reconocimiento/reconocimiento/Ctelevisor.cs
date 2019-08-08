using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reconocimiento
{
    class Ctelevisor
    {
        private string marca;

        public Ctelevisor(string marca)
        {
            this.marca = marca ?? throw new ArgumentNullException(nameof(marca));
        }

        public string Marca { get => marca; set => marca = value; }

        public override string ToString()
        {
            return string.Format("el TV es marca {0}", marca);
        }

        public void encender(bool encendido)
        {
            if(encendido)
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
