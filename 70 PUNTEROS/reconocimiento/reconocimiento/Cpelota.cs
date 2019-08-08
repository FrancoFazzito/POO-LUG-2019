using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reconocimiento
{
    class Cpelota
    {
        string tamaño;

        public Cpelota(string tamaño)
        {
            this.tamaño = tamaño ?? throw new ArgumentNullException(nameof(tamaño));
        }

        public string Tamaño { get => tamaño; set => tamaño = value; }
    }
}
