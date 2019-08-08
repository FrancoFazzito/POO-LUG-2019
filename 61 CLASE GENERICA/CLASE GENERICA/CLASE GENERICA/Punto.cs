using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_GENERICA
{
    class Punto<T> /*usamos T luego de clase*/
    {
        private T x;
        private T y;
        //private int a;
        public Punto(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T Y { get => y; set => y = value; }

        public T GetX()
        {
            return x;
        }

        public void SetX(T value)
        {
            x = value;
        }

        public override string ToString()
        {
            return string.Format("tipo {0} X={1} y tipo {2} Y={3}", x.GetType(), x, y.GetType(), y);
        }

        //ESTO NO
        //public T suma(T a, T b)
        //{
        //    El operador '+' no se puede aplicar a operandos del tipo 'T' y 'T'  
        //    return a + b;
        //}

        //PARA HACER ESO SE TIENE QUE HACER ASI
        public T suma(T a, T b)
        {
            dynamic Da = a;
            dynamic Db = b;
            return Da + Db;
            /*PERO SI METES DOS STRINGS NO SE MULTIPLICAN SOLO SI EL TIPO INGRESADO SE PUEDE USAR*/
        }


        public void Reset()
        {
            /*ponemos como valor de default a T de vuelta*/

            x = default(T);
            y = default(T);
        }
    }
}
