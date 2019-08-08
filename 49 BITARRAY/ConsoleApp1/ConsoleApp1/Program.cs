using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUE SEAN MODIFICAR UN BIT A LA VEZ
            byte[] vectorAingresar = new byte[] { 1, 2, 4, 8, 16 };

            BitArray array = new BitArray(vectorAingresar);
            //los bytes se estan conviertiendo en bits 
            Console.WriteLine(array.Count);
            Muestra(array);
            Console.WriteLine(array.Get(0));
            Console.WriteLine(array.Get(3));
            array.Set(3, true); /*indice y el segundo es el valor a colocar*/
            array.Set(4, false); /*indice y el segundo es el valor a colocar*/
            Muestra(array);


            BitArray clon = (BitArray)array.Clone();
            Muestra(clon);
            clon.Not();
            Muestra(clon);

            array.Or(clon);
            Muestra(array);

            clon.And(array);
            Muestra(clon);

            array.Xor(clon);
            Muestra(array);
            Console.ReadKey();
        }

        public static void Muestra(BitArray array, string nombre="")
        {
            int c = 0;
            foreach (bool bit /*1 o 0*/ in array)
            {
                c++;
                if(bit)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }
                if(c % 8 == 0)
                {
                    Console.Write(" , ");
                }
                //DEL MENOS AL MAS SIGNIGATIVO
            }
            Console.WriteLine();
        }
    }
}
