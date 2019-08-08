using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFAZ
{
    class Suma : IOperacion
    {
        //DEBE TENER LOS DOS METODOS IGUALES AL PROTOTIPO DE FUNCION DE LA INTERFAZ

        private double r = 0;
        private List<double> resultados = new List<double>();

        //metodo a implementar
        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("el resultado es {0}", r);
            resultados.Add(r);
        }

        //metodo propio de la clase 
        public void mostrarResultados()
        {
            foreach(double result in resultados)
            {
                Console.WriteLine(r);
            }
        }
    }
}
