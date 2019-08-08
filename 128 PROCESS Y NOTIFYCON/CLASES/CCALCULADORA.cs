using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    //DENTRO DEL NAMESPACE GACER AGREGAR Y ELEGIR CLASE CON SU CONSIGUIENTE NOMBRE
    class CCALCULADORA
    {
        //ATRIBUTO DE UNA CLASE
        public double a;
        //AMBITO //TIPO //NOMBRE
        public double b;
        public double r;

        //AMBITO //NOMBRE DEL OBJETO //ENTRADA DE SUS ATRIBUTOS
        //public CCALCULADORA(double a, double b, double r)
        //{
        //    ESTE THIS. ATRIBUTO TIENE ESTE VALOR = ENTRADO POR PARAMETRO 
        //    this.a = a;
        //    this.b = b;
        //    this.r = r;
        //}

        //DECLARACION DE METODO
        public void Suma()
        {
            //ACCION DEL METODO
            r = a + b;
        }

        public void Mostrar()
        {
            Console.WriteLine("a = {0} , b = {1} , resultado = {2}", a, b, r);
        }
    }
}
