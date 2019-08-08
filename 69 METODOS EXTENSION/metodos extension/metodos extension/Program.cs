using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //tecnica para adicionar un metodo a una clase a la cual no tenemos acceso o no nos conviene
            //clase con una cadena de herencia por ejemplo


            //extension de int
            int numero = 55; /*cae en I de la clase*/
            //metodo de extension
            bool par = numero.espar();
            double numeroAMultiplicar = 10.2;
            numeroAMultiplicar.DoubleTea();
            Console.WriteLine(numeroAMultiplicar);
            Console.WriteLine(par);
            INT iNT = new INT(1);
            iNT.hola();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
