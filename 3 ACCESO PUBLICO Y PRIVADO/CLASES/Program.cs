using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIA DE LA CLASE
            //DECLARA EL NOMBRE        //SE HACE NEW DE LA CLASE
            CCALCULADORA cCALCULADORA = new CCALCULADORA();

            //CARGAMOS LOS ATRIBUTOS
            cCALCULADORA.a = 5;
            cCALCULADORA.b = 6;

            //MOSTRAMOS LOS DATOS
            cCALCULADORA.Mostrar();

            //HACEMOS LA SUMA
            cCALCULADORA.Suma();

            //MOSTRAMOS DE VUELTA
            cCALCULADORA.Mostrar();

            //'CCALCULADORA.r' no es accesible debido a su nivel de protección
            //cCALCULADORA.r = 8;

            Console.WriteLine("------------");
            //INSTANCIA DE OTRO OBJETO Y ASIGNAMOS VALORES
            CCALCULADORA cCALCULADORA2 = new CCALCULADORA();
            //CADA OBJETO TIENE SU PROPIA INFORMACION Y ESTAN SEPARADOS
            cCALCULADORA2.a = 10;
            cCALCULADORA2.b = 20;
            cCALCULADORA2.Mostrar();
            cCALCULADORA2.Suma();
            cCALCULADORA2.Mostrar();
            Console.Read();
        }
    }
}
