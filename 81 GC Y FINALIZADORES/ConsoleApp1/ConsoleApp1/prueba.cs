using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class prueba
    {
        private int a;

        public prueba(int a)
        {
            this.a = a;
        }

        public int A { get => a; set => a = value; }

        public override string ToString()
        {
            return string.Format("el valor es {0}", a);
        }
        /*metodo virtual finalize y ejecuta la finalizacion del objeto*/
        ~prueba()
        {
            Console.Beep(500,400);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("liberamos recursos no administrados");
        }
    }
}
