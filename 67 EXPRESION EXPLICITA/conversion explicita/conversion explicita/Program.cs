using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversion_explicita
{
    class Program
    {
        static void Main(string[] args)
        {
            Complejo comp1 = new Complejo(2, 3);

            // real real1 = comp1;/*no se puede convertir de forma implicita*/
            real real = (real)comp1;/*TIPE CAST DE LA CONVERSION DE LA CLASE*/
            Console.WriteLine(real);

            /*IMPLICITA*/
            Complejo complejo = new real(5);
            Console.WriteLine(complejo);
            /*tipos anonimos*/
            var Compu = new { procesador = "i7", memoria = 16, grafica = "amd" };
            /*creacion rapida de una clase cuando se usa poca pero esta sealed ni tiene nombre solo get*/
            Console.WriteLine(Compu); /*lo inicializado*/
            Console.WriteLine("{0} {1} {2}", Compu.procesador, Compu.memoria, Compu.grafica);
            Console.ReadKey();
        }
    }
}
