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


        //DECLARACION DE PROPIEDAD ATRIBUTO DE CLASE PERO CON MAYUSCULA
        public double Sueldo
        {
            get {

                return sueldo;
            }

            set
            {
                //SE PUEDE USAR IF CON CODIGOS DE SEGURIDAD
                sueldo = value;
            }
        }
        public double Impuesto
        {
            //SOLAMENTE QUEREMOS LEER INFORMACION
            get
            {
                return impuesto;
            }
        }
        //ATRIBUTOS QUE EL EXTERIOR NECESITA SABER DE EL SE NECESITAN PROPIEDADES

        //OTRA FORMA
        //public double Sueldo { get; set; }
        //public double Impuesto { get; set; }

        //MUTATOR 
        //DONDE LOS ATRIBUTOS CAMBIEN DE VALOR Y SU ESTADO
        public void calcularimpuesto()
        {
            impuesto = sueldo * 0.16;
        }

    }
}
