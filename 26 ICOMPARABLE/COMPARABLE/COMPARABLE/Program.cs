using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPARABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo[] rects = new Rectangulo[5];
            rects[0] = new Rectangulo(14, 6);
            rects[1] = new Rectangulo(1, 7);
            rects[2] = new Rectangulo(75, 8);
            rects[3] = new Rectangulo(8, 9);
            rects[4] = new Rectangulo(91, 10);

            foreach (Rectangulo rectangulo in rects)
            {
                Console.WriteLine(rectangulo);
            }

            Console.WriteLine("*----------*");

            //SORT NECESITA DE LA IMPLEMENTACION ICOMPARABLE
            Array.Sort(rects);
            //SINO ESTO -> ArgumentException: Al menos un objeto debe implementar IComparable.
            foreach (Rectangulo rectangulo in rects)
            {
                Console.WriteLine(rectangulo);
            }

            Console.ReadKey();
        }
    }
}
