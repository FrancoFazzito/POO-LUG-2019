using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //MAS DE UNA INTERFACE
    class Auto: IAutomovil,ICloneable
    {
        private double costo;
        private double tenencia;
        private string modelo;

        //constructor
        public Auto(double costo, string modelo)
        {
            //inicializacionde datos
            this.costo = costo; //ESTOS
            this.modelo = modelo; //ESTOS
        }
        public object Clone()
        {
            //SE DEBE CREAR UN NUEVO OBJETO DE LA INSTANCIA y SE ENVIAN PARAMETROS IGUALES
            //HACIENDO QUE LOS CONTRUCTORES SEAN LOS PARAMETROS DE ESTE (ESTOS)
            Auto clon = new Auto(costo,modelo); //AQUI
            clon.tenencia = tenencia;
            return clon;
        }
        //adicione esto
        public double Costo { get { return costo;  } set { costo = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }


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
