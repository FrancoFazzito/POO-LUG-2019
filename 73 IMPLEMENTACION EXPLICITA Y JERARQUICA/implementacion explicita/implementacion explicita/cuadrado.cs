using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacion_explicita
{
    class cuadrado : IArea, IPerimetro
    {
        private int lado;

        public cuadrado(int lado)
        {
            this.lado = lado;
        }

        public int Lado { get => lado; set => lado = value; }

        void IArea.calcular()
        {
            Console.WriteLine("area es {0}", lado * lado);
        }

        /*aclarar el miembro del metodo*/
        void IPerimetro.calcular()
        {
            Console.WriteLine("perimetro es {0}", lado * 4);
        }
    }
}
