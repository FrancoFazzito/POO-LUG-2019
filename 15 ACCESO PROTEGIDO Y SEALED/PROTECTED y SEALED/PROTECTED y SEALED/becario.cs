using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROTECTED_y_SEALED
{
    class becario
    {
        private int horasBecas;
    
        public int HorasBeca
        {
            get
            {
                return horasBecas;
            }
            set
            {
                horasBecas = value;
            }
        }
        public void mostrar()
        {
            Console.WriteLine("las horas son {0}", horasBecas);
        }
    }

}
