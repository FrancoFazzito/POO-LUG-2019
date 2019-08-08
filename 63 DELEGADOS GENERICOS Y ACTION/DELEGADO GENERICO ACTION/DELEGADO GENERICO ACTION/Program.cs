using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELEGADO_GENERICO_ACTION
{
    class Program
    {
        public delegate void Midelegado<T>(T p);
        static void Main(string[] args)
        {
            //delegado generico
            Midelegado<string> delegadoString = new Midelegado<string>(HandlerString);
            delegadoString("juan");
            Midelegado<int> delegadoInt = new Midelegado<int>(HandlerInt);
            delegadoInt(3);


            //action
            int numero = 5;
            string name = "hola a todos";
            /*siempre void*/
            Action<string, int> delegadoAction = new Action<string, int>(repetir);
            delegadoAction(name,numero);


            //func similiar a action pero permite retono de valor
            Func<int/* A */, int/* B */, int/* RETORNO ULTIMO*/> delegadoFunc = new Func<int, int, int>(suma);
            Console.WriteLine(delegadoFunc(3, 4));
            Console.ReadKey();
        }

        static void HandlerString(string P)
        {
            Console.WriteLine("uso de delegado de string con valor de {0}", P);
        }


        static void HandlerInt(int P)
        {
            Console.WriteLine("uso de delegado de int con valor de {0}", P);
        }

        static void repetir(string nombre, int numero)
        {
            Console.WriteLine("nombre con {0} y numero {1}", nombre, numero);
        }

        static int suma(int a, int b)
        {
            return a + b;
        }
    }


}
