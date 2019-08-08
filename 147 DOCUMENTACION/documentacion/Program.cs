<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentacion
{
    /// <summary>
    /// esta clase hace X accion
    /// </summary>
    class Ejemplo
    {
        /// <summary>
        /// suma de los dos int y retorno de su resultado
        /// </summary>
        public static int sumar(int primer, int b)
        {
            /// <param name="primer"> primer numero para la suma </param>
            ///<returns>
            ///informacion sobre el retorno de la funcion          
            ///</returns>
            return primer + b;
        }

        /// <summary>
        /// resta de los dos int y retorno de su resultado
        /// </summary>
        public static int restar(int primer, int b)
        {
            return primer + b;
        }

        ///<summary>
        ///<code> poner codigo para ayudar a referirse a estos
        ///public static int Add(int a, int b)
        /// {
        ///<returns>
        ///informacion sobre el retorno de la funcion          
        ///</returns>
        ///     return a + b;
        /// }
        ///</code>
        ///</summary>
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo.sumar(4, 5);
            Ejemplo.restar(10, 6);
            Console.ReadKey();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentacion
{
    /// <summary>
    /// esta clase hace X accion
    /// </summary>
    class Ejemplo
    {
        /// <summary>
        /// suma de los dos int y retorno de su resultado
        /// </summary>
        public static int sumar(int primer, int b)
        {
            /// <param name="primer"> primer numero para la suma </param>
            ///<returns>
            ///informacion sobre el retorno de la funcion          
            ///</returns>
            return primer + b;
        }

        /// <summary>
        /// resta de los dos int y retorno de su resultado
        /// </summary>
        public static int restar(int primer, int b)
        {
            return primer + b;
        }

        ///<summary>
        ///<code> poner codigo para ayudar a referirse a estos
        ///public static int Add(int a, int b)
        /// {
        ///<returns>
        ///informacion sobre el retorno de la funcion          
        ///</returns>
        ///     return a + b;
        /// }
        ///</code>
        ///</summary>
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplo.sumar(4, 5);
            Ejemplo.restar(10, 6);
            Console.ReadKey();
        }
    }
}
>>>>>>> 7f85a414ed6b84bdf726a283e9468a6c5e3979f0
