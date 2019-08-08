using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jerarquia
{
    class suma: ICalcular
    {
        private int a;
        private int b;
        private int r;
        public suma(int a, int b)
        {
            this.a = a;
            this.b = b;
            r = this.a + this.b;
        }

        public suma()
        {

        }
        /*tengo que implmentar las dos*/
        //'suma' no implementa el miembro de interfaz 'ICalcular.calculo(int, int)'	
        //'suma' no implementa el miembro de interfaz 'IMostrar.mostrar()'	

        public int calculo(int a, int b)
        {
            this.b = b;
            this.a = a;
            this.r = a + b;
            return r;
        }

        public void mostrar()
        {
            Console.WriteLine("{0} {1} {2} ", a, b, r);
        }
    }
}
