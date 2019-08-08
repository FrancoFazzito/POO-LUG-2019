using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL_Y_OVERRIDE
{
    class Productocs
    {
        private string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public Productocs(string descripcion, double precioCompra)
        {
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = 0.0;
        }

        public virtual void CalculaPrecio()
        {
            //CLASES HIJAS NECESITAN SU CODIGO DE ESTE METODO
            Console.WriteLine("calcula precio");
            precioVenta = precioCompra * 1.3;
        }

        public void muestraVemta()
        {
            Console.WriteLine("{0} se vende en {1}", descripcion, precioVenta);
        }
    }
}
