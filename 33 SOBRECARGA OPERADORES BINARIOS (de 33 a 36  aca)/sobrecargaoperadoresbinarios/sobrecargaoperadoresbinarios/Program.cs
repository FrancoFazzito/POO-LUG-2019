using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaoperadoresbinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Imaginario imaginario = new Imaginario(1, 2);
            Imaginario imaginario2 = new Imaginario(3, 4);
            Imaginario imaginario3 = imaginario + imaginario2;
            Console.WriteLine("{0} + {1} = {2}", imaginario, imaginario2, imaginario3);

            imaginario++;

            Console.WriteLine("{0} ", imaginario);
            Console.ReadKey();
        }
    }
}
