using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPARABLE
{
    class Rectangulo : IComparable
    {
        //PERMITE COMPARAR ES DECIR IGUAL MAYOR O MENOR DE DOS OBJETOS
        private double ancho;
        private double alto;
        private double area;
        //SI QUEREMOS OPCIONES COLOCAR STATIC Y CAMBIAR DE AQUI
        //AGREGAR UN SET Y AL CONSTRUCTOR
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
            CalculaArea();
        }

        private void CalculaArea()
        {
            area = ancho * alto;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1} = {2}", ancho, alto, area);
        }

        int IComparable.CompareTo(object obj)
        {
            Rectangulo ObjetoAComparar = (Rectangulo)obj;

            //ELEGIMOS AREA PERO PUEDE SER CUALQUIERA
            if (this.area > ObjetoAComparar.area)
            {
                return 1;
            }
            if (this.area < ObjetoAComparar.area)
            {
                return -1;
            }
            return 0;
        }

    }
}
