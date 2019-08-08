using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESORS
{
    class EMPLEADO
    {
        //MAS SEGUROS Y MENOS CORRUPCION YA QUE SOLO EL OBJETO TIENE ACCESO A ELLO
        private double sueldo;
        private double impuesto;

        public void muestra()
        {
            Console.WriteLine("sueldo = {0} , impuesto = {1} ", sueldo, impuesto);
        }

        //ESCRIBIR
        public void set_sueldo(double psueldo)
        {
            sueldo = psueldo;
        }

        //LEER
        public double get_sueldo()
        {
            return sueldo;
        }

        //ESCRIBIR
        public void set_impuesto(double pimpuesto)
        {
            impuesto = pimpuesto;
        }

        //LEER
        public double get_impuesto()
        {
            return impuesto;
        }

        //MUTATOR 
        //DONDE LOS ATRIBUTOS CAMBIEN DE VALOR Y SU ESTADO
        public void calcularimpuesto()
        {
            impuesto = sueldo * 0.16;
        }
    }
}
