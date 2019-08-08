using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGREGACION
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXISTE JUAN Y EDIFICIO POR SEPARADO TODAVIA NO SE ADICIONA
            Propietario juan = new Propietario("juan");

            Edificio edificio1 = new Edificio("berutti 2062", 10, 3);

            juan.MostrarPropiedad();

            Console.WriteLine("-------");
            //AQUI SE HACE LA ADICION
            juan.adicionarPropiedad(edificio1);
            juan.MostrarPropiedad();


            //SI SE DESTRUYE JUAN EL EDIFICIO SIGUE ESTANCO
            //SI SE DESTRUTE EDIFICIO JUAN SIGUE

            //juan = null;
            //GC.Collect(); HACK PARA SABER SI SIGUE EXISTIENDO

            //Console.WriteLine("-------");
            //edificio1.muestra();

            Console.ReadKey();

        }
    }
}
