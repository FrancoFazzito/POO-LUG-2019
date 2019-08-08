using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARA_NOMBRADOS_OPCIONALES
{
    class Program
    {
        static void Main(string[] args)
        {
            mostrarDatos(3, 4, 5);
            //mandamos la descripcion seguido de : e indicamos el valor
            mostrarDatos(a: 4, c: 5, b: 1);
            mostrarDatosOpcional();

            mostrarDatosOpcional(a: 3, b: 2);
            Console.ReadKey();
        }

        //POSICIONALES POR QUE CADA UNO CAE EN UNA POSICION EL PRIMERO TIENE QUE SER A
        public static void mostrarDatos(int a, int b, int c)
        {
            Console.WriteLine("{0},{1},{2}", a, b, c);
        }

        //SON OPCIONALES EN CASO DE NO ESTAR SE VA A USAR LOS ASIGNADOS
        public static void mostrarDatosOpcional(int a = 1, int b = 2, int c = 3)
        {
            Console.WriteLine("{0},{1},{2}", a, b, c);
        }
    }

    
}
