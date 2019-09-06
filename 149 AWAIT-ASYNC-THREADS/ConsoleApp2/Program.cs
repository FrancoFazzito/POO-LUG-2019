<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SIN parametro
            //Thread thread = new Thread(valores.precio);
            //thread.Start();

            //CON parametro
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(valores.precio);
            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start(15); /*comenzar*/
            valores v1 = new valores();
            v1.proceso();
            //thread.Join(); /*parar*/
            Console.ReadKey();
        }
    }
    class valores
    {
        public static void precio(object numero)
        {
            Thread.Sleep(2500/*milisecond*/);
            Console.WriteLine(numero.ToString());
        }
        public async void proceso()
        {
            Task<int>/*valor retorno*/ tarea = new Task<int>(count);
            tarea.Start();
            int tareaResultado = await tarea;
            Console.WriteLine(tareaResultado);
        }
        public int count()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                count++;
            }
            return count;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SIN parametro
            //Thread thread = new Thread(valores.precio);
            //thread.Start();

            //CON parametro
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(valores.precio);
            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start(15); /*comenzar*/
            valores v1 = new valores();
            v1.proceso();
            //thread.Join(); /*parar*/
            Console.ReadKey();
        }
    }
    class valores
    {
        public static void precio(object numero)
        {
            Thread.Sleep(2500/*milisecond*/);
            Console.WriteLine(numero.ToString());
        }
        public async void proceso()
        {
            Task<int>/*valor retorno*/ tarea = new Task<int>(count);
            tarea.Start();
            int tareaResultado = await tarea;
            Console.WriteLine(tareaResultado);
        }
        public int count()
        {
            int count = 0;
            for (int i = 0; i < 100; i++)
            {
                count++;
            }
            return count;
        }
    }
}
>>>>>>> 7f85a414ed6b84bdf726a283e9468a6c5e3979f0
