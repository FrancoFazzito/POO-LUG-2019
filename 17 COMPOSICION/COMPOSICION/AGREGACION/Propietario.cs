using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGREGACION
{
    class Propietario
    {
        private string nombre;
        //PUEDE GUARDAR GUARDAR UNA REFERENCIA A CUALQUIER OBJETO DE TIPO EDIFICIO PERO NO INSTANCIA
        //NULL ES POR SEGURIDAD
        private Edificio propiedad = null;

        public Propietario(string nombre)
        {
            this.nombre = nombre;
            this.propiedad = new Edificio("berutti 2062", 10, 3); ;
        }

        public void MostrarPropiedad()
        {
            if(propiedad != null)
            {
                Console.WriteLine("{0} tiene", nombre);
                propiedad.muestra();
            }
            else
            {
                Console.WriteLine("{0} NO tiene", nombre);
            }
        }

        //rompe encapsulamiento
        //ya que se accede a propiedad sin pasar por propieario
        public Edificio Propiedad
        {
            get
            {
                return propiedad;
            }

            set
            {
                propiedad = value;
            }
        }
    }
}
