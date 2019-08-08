using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL_Y_OVERRIDE
{
    class productoImportado : Productocs
    {
        protected double impuesto;

        public productoImportado(string descripcion, double preciocompra, double impuesto) : base( descripcion, preciocompra)
        {
            this.impuesto= impuesto;
        }

        //CREO LA VERSION DE MI CALCULA PRECIO ES DECIR LA FUNCION DE PRODUCTO
        //USANDO ESTA EN VEZ DE PRODUCTO
        public override void CalculaPrecio()
        {
            //public sealed override void CalculaPrecio()
            //SEALED EN UNA FUNCION VIRUTAL LO QUE HACE ES QUE DICE DE ACA PARA ABAJO YA NO TIENE EL OVERRIDE DE CALCULA PRECIO
            Console.WriteLine("calcula precio OVERRIDE");
            precioVenta = precioCompra * (1 + impuesto) * 1.30;
        }
        public override string ToString()
        {
            return string.Format("producto importado {0} cuesta {1} y se vende en {2}", descripcion, precioCompra, precioVenta);
        }
        public void mensaje()
        {
            Console.WriteLine("soy un producto importado");
        }
        //ACA SE IMPLEMENTA EL ABSTRACT
        //SIEMPRE SE TIENE QUE IMPLEMENTAR

    }
}
