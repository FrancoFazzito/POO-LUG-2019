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
        private string log;

        public void muestra()
        {
            Console.WriteLine("sueldo = {0} , impuesto = {1} ", sueldo, impuesto);
        }

        //ESCRIBIR
        public void set_sueldo(double psueldo)
        {
            if (psueldo < 5000 || psueldo > 15000)
            {
                logerror("sueldo ilegal  " + psueldo.ToString());
            }
            else
            {
                sueldo = psueldo;
            }
        }

        //LEER
        public double get_sueldo(int password)
        {
            if (password != 12345)
            {
                logerror("ilegal password");
                return 0.0;
            }
            else
            {
                return sueldo;
            }
        }

        //ESCRIBIR
        public void set_impuesto(double pimpuesto)
        {
            impuesto = pimpuesto;
        }

        //LEER
        public double get_impuesto(int password)
        {
            if (password != 12345)
            {
                logerror("ilegal password");
                return 0.0;
            }
            else
            {
                return impuesto;
            }
        }

        //MUTATOR 
        //DONDE LOS ATRIBUTOS CAMBIEN DE VALOR Y SU ESTADO
        public void calcularimpuesto()
        {
            impuesto = sueldo * 0.16;
        }

        private void logerror(string error)
        {
            log += error + "\r\n";
        }

        public void mostrarlog()
        {
            Console.WriteLine(log);
        }
    }
}
