using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constante
{
    class Program
    {
        static void Main(string[] args)
        {
            const double constanteDouble = 5;
            Console.WriteLine("la constante vale {0}", constanteDouble);
            //constanteDouble = 5; 
            //La parte izquierda de una asignación debe ser una variable, una propiedad o un indizador
            /*cuando se quiere hacer una constante pero no se sabe el valor*/
            ejemplo ejemplo = new ejemplo(15);
            Console.WriteLine("el readonly vale {0}", ejemplo.CostoExtra);

            Console.ReadKey();
        }
    }
    class ejemplo
    {
        /*crea readonly*/
        private readonly double costoExtra;

        public ejemplo(double costoExtra)
        {
            /*solamente se le asigna el valor en la clase con el constructor*/
            this.costoExtra = costoExtra;
            /*luego de esto nada lo puede camibiar*/
        }

        public double CostoExtra => costoExtra;
        /*set no se puede ya que no se puede sobreescribir*/
    }
}
