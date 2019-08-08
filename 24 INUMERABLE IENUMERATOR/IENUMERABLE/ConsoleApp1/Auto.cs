using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Auto: IAutomovil
    {
        private double costo;
        private double tenencia;
        private string modelo;

        //constructor
        public Auto(double costo, string modelo)
        {
            //inicializacionde datos
            this.costo = costo;
            this.modelo = modelo;
        }

        //metodos interfaz
        public void CalculaTenencia(double impuesto)
        {
            tenencia = 5000 + costo * impuesto;
        }

        public void MuestraInfo()
        {
            Console.WriteLine("tu automovil {0}", modelo);
            Console.WriteLine("tenencia es de {0}", tenencia);
            Console.WriteLine("costo es {0}", costo);
        }

    }
}
