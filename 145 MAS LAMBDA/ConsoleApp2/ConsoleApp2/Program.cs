<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp2
{
    delegate int Operacion(int x1, int x2);

    class Program
    {       
        //A
        public static int operacionSuma (int x1, int x2, Operacion operacion)
        {
            return operacion(x1, x2);
        }
        //C
        public static int suma(int x1, int x2)
        {
            return x1 + x2;
        }
        
        static void Main(string[] args)
        {
            //C
            Operacion operacion = new Operacion(Program.suma);
            var sumaNormal = operacion(5, 12);
            Console.WriteLine(sumaNormal);

            //A
            var sumaLambda = Program.operacionSuma(10, 5,/*comportamiento*/ (x, y) => { return x + y; });

            Func<int, int> square = ( x /*usando x como parametro*/) => x * x;
            //System.Linq.Expressions.Expression
            Expression<Func<int, int>> suma = x => x + x;
            //(input-parameters) => expression
            Action<string> escribir = name =>
            {
                Console.WriteLine(name);
            };
            escribir("juan");

            Func<int, int, bool> equals = (x, y) => { return x == y; };
            Console.WriteLine(equals(5, 6));

            //int oddNumbers = numbers.Count(n => n % 2 == 1); tambien entra el formato de linq el cual esta en el repositorio

            //tuples 

            var doubledNumbers = doubleThem(numbers);
            Console.WriteLine(sumaLambda);
            Console.WriteLine(suma);
            Console.WriteLine(square(5));

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConsoleApp2
{
    delegate int Operacion(int x1, int x2);

    class Program
    {       
        //A
        public static int operacionSuma (int x1, int x2, Operacion operacion)
        {
            return operacion(x1, x2);
        }
        //C
        public static int suma(int x1, int x2)
        {
            return x1 + x2;
        }
        
        static void Main(string[] args)
        {
            //C
            Operacion operacion = new Operacion(Program.suma);
            var sumaNormal = operacion(5, 12);
            Console.WriteLine(sumaNormal);

            //A
            var sumaLambda = Program.operacionSuma(10, 5,/*comportamiento*/ (x, y) => { return x + y; });

            Func<int, int> square = ( x /*usando x como parametro*/) => x * x;
            //System.Linq.Expressions.Expression
            Expression<Func<int, int>> suma = x => x + x;
            //(input-parameters) => expression
            Action<string> escribir = name =>
            {
                Console.WriteLine(name);
            };
            escribir("juan");

            Func<int, int, bool> equals = (x, y) => { return x == y; };
            Console.WriteLine(equals(5, 6));

            //int oddNumbers = numbers.Count(n => n % 2 == 1); tambien entra el formato de linq el cual esta en el repositorio

            //tuples 

            var doubledNumbers = doubleThem(numbers);
            Console.WriteLine(sumaLambda);
            Console.WriteLine(suma);
            Console.WriteLine(square(5));

        }
    }
}
>>>>>>> 7f85a414ed6b84bdf726a283e9468a6c5e3979f0
