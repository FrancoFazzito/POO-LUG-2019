using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //una EDD tenga que pasar por todos los elementos y eso hace el foreach ya que es un iterator
            //IEnumerable compartamiento tiene getEnumarator y obtiene el iterador de esa estructura
            //IEnumerator tiene move next que va al siguiente object current que lee el actual y reset reinicia hacia el inicio

            TiendaAutos tiendaAutos = new TiendaAutos();

            foreach(Auto auto in tiendaAutos)
            {
                auto.CalculaTenencia(0.05);
                auto.MuestraInfo();
            }
            //recorriendo cada uno de los autos de la tienda y tienda nos regresa el enumerador
            //el foreach encuentra lo devuelto y se muestra

            Console.ReadKey();

        }
    }
}
