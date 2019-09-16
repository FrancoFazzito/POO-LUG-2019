using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparison<int> DescComparacion = Comparacion;
            int ValorComparacion = DescComparacion(5, 7);
            Console.WriteLine(ValorComparacion);

            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6 };
            numeros.Sort(DescComparacion);

            Console.WriteLine("lista ordenada");
            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }

        static int Comparacion(int numero1, int numero2)
        {
            if (numero1 < numero2)
            {
                return 1;
            }
            else if(numero1 > numero2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
