using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_de_estructuras_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            predicate();
            funcUnParametro();
            funcDosParametros();
            Console.Read();
        }

        public static void predicate()
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Predicate<int> primeroMayorACinco = EsMayorCinco;
            Predicate<int> primeroMayorACincoLambda = numero => numero > 5;
            int Buscado = numeros.Find(primeroMayorACinco);
            int BuscadoLambda = numeros.Find(primeroMayorACincoLambda);
            Console.WriteLine(Buscado);
            Console.WriteLine(BuscadoLambda);
        }

        public static void funcUnParametro()
        {
            Func<int, string> convertToString = ConvertString;
            Func<int, string> convertToStringLambda = numero => numero.ToString();
            string stringConvertido = convertToString(10);
            string stringConvertidoLambda = convertToStringLambda(10);
            Console.WriteLine(stringConvertido);
            Console.WriteLine(stringConvertidoLambda);
        }

        public static void funcDosParametros()
        {
            Func<int, int, bool> sumaMayorADiezLambda = (num1, num2) => num1 + num2 > 10;
            Func<int, int, bool> sumaMayorADiez = EsMayorDiez;
            bool resultado = sumaMayorADiez(5, 3);
            Console.WriteLine(resultado);
        }

        public static bool EsMayorCinco(int numero)
        {
            return numero > 5;
        }

        public static string ConvertString(int numero)
        {
            return numero.ToString();
        }

        public static bool EsMayorDiez(int num1,int num2)
        {
            return num1 + num2 > 10;
        }
    }


}
