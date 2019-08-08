using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGREGACION
{
    class Edificio
    {
        private string direccion;
        private int CantidadDepartamento;
        private int DepRentados;

        public Edificio(string direccion, int cantidadDepartamento, int depRentados)
        {
            this.direccion = direccion;
            CantidadDepartamento = cantidadDepartamento;
            DepRentados = depRentados;
        }
        public void muestra()
        {
            Console.WriteLine("edificio en {0} con {1} deptos, {2} rentados", direccion, CantidadDepartamento, DepRentados);
        }
    }
}
