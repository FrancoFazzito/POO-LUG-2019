using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIRTUAL_Y_OVERRIDE
{
    class Program
    {
        static void Main(string[] args)
        {

            //CASTING PERMITE QUE UNA CLASE TRABAJE COMO SI FUERA OTRA
            //CUANDO TENEMOS UNA CADENA DE HERENCIA, TENEMOS UN ELEMENTO COMUN DE SU PADRE
            //A B C -> A B
            // A B <- A B C
            //MAS ESPECIFICO A LO MAS GENERAL
            Productocs P1 = new productoImportado("tele", 2500, 0.15);
            //se puede hacer por que productoimportado es un producto

            P1.CalculaPrecio();
            Console.WriteLine(P1);

            Console.WriteLine("-----");
            //SOLO TRABAJA CON LA CLASE PRODUCTO 
            //P1.mensaje();
            //EL METODO MENSAJE ESTA DEFINIDO EN IMPORTADO NO EN PRODUCTO

            //HACER CAST SE PUEDE USAR ASI PARA ACCEDER A MENSAJE
            ((productoImportado)P1).mensaje();
            //SOLO SE PUEDE USAR CON CLASES EN HENENCIA

            //OBJECT ES SUPERTIPO Y TODOS HEREDAN DE EL
            object p2 = new Productocs("radio", 300.5);

            ((Productocs)p2).CalculaPrecio();
            Console.WriteLine((Productocs)p2);
            Console.WriteLine("-----");

            //OBJECT NO ES UN PROUCTO NO SE PUEDE DE ESPECIFICO A MENOS 
            //Productocs productocs = new object();
<<<<<<< HEAD
            Productocs ae = new Productocs("a", 1500);
            productoImportado producto = new productoImportado("ae", 1600, 100);
            ae = producto;
            ae.CalculaPrecio();
=======

>>>>>>> 7f85a414ed6b84bdf726a283e9468a6c5e3979f0
            //ENCUENTRA LOS DOS IF YA QUE ES LAS DOS COSAS
            Detecta(P1);
            //ENCUENTRA SOLO EL PRIMERO YA QUE ES UN PRODUCTO
            Console.WriteLine("---------");
            Detecta((Productocs)p2);
            //Detecta(p2);
            //no se puede convertir de 'object' a 'VIRTUAL_Y_OVERRIDE.Productocs'

            //CAST EN TIPOS NUMERICOS
            int a = 57;
            float b = 5.67f;
            double c = 123.45;
            byte x = 5;

            //MAYOR GUARDA A MENOR
            a = x;
            Console.WriteLine(a);


            //MENOR GUARDA A MENOR HAY QUE CASTEAR
            b = (float)c;
            Console.WriteLine(b);

            //
            Console.ReadKey();

        }

        public static void Detecta(Productocs producto)
        {
            if(producto is Productocs)
            {
                Console.WriteLine(" es local");
                producto.CalculaPrecio();
                Console.WriteLine(producto);
            }

            if(producto is productoImportado)
            {
                Console.WriteLine(" es importado");
                producto.CalculaPrecio();
                ((productoImportado)producto).mensaje();
                Console.WriteLine(producto);
            }
        }
    }
}
