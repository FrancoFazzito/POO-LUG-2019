using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL_Y_OVERRIDE
{
    class ProductoDetenido : productoImportado
    {
        private double multa;
        public ProductoDetenido (string descripcion, double preciocompra, double impuesto, double multa): base(descripcion,preciocompra,impuesto)
        {
            this.multa = multa;
        }
        public override void CalculaPrecio()
        {
            //SI SE HACE SEALED
            //'ProductoDetenido.CalculaPrecio()': no se puede invalidar el miembro heredado 'productoImportado.CalculaPrecio()' porque está sellado VIRTUAL Y OVERRIDE

            Console.WriteLine("calcula precio OVERRIDE");
            precioVenta = (precioCompra * (1 + impuesto) * 1.30) + multa;
        }
    }
}
