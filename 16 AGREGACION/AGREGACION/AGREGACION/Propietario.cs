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

        public void adicionarPropiedad(Edificio edificio)
        {
            if(propiedad == null)
            {
                propiedad = edificio;
            }
        }
    }
}
