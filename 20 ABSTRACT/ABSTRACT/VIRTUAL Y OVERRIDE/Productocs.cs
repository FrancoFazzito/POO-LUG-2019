using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL_Y_OVERRIDE
{
    //ADENTRO DE ABSTRACT PODEMOS TENER METODOS Y ATRIBUTOS
    abstract class Productocs
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public Productocs(string descripcion, double precioCompra)
        {
            this.descripcion = descripcion;
            this.precioCompra = precioCompra;
            this.precioVenta = 0.0;
        }

        //AQUELLO QUE SEA PRODUCTO CADA UNO PUEDE TENER SU PROPIA VERSION
        public virtual void CalculaPrecio()
        {
            //CLASES HIJAS NECESITAN SU CODIGO DE ESTE METODO
            Console.WriteLine("calcula precio");
            precioVenta = precioCompra * 1.3;
        }

        //METODO ABSTRACTO -> DEFINIMOS EL PROTOTIPO PERO NINGUN CUERPO ASIGNANDO SOLO 
        //AMBITO      //VALOR DEVUELTO //NOMBRE //PARAMETROS
        public abstract void muestraVemta();
        //NO SABEMOS COMO SE VA A LLEVAR A CABO 
        //ANIMALES COMEN PERO CADA UNO COME DISTINTO ASI QUE NO HAY FORMA DE HACERLO DE FORMA DEFAULT
    }
}
