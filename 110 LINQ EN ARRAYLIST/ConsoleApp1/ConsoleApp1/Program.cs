using System;
using System.Collections;
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
            ArrayList lista2 = new ArrayList();
            lista2.AddRange(new object[] { "hola", 5, 6.7, true, 4, "salu2", 3.5, 3 });
            var enteros = lista2.OfType<int>();
            foreach (int item in enteros)
            {
                Console.WriteLine(item);
            }

            //transformamos el array list a un tipo que implemente inumerable par ser usado en linq
            ArrayList estudiantes2 = new ArrayList()
            {
                new Estudiante("juan", "12a", "2a", 5),
                new Estudiante("juan1", "12b", "2b", 6),
                new Estudiante("juan2", "12c", "2a", 7),
                new Estudiante("juan3", "12d", "2b", 4),
                new Estudiante("juan4", "12e", "2a", 3),
                new Estudiante("juan5", "12f", "2b", 2),
                new Estudiante("juan6", "12g", "2a", 10),
            };
            //var si ya que var esta en public interface IEnumerable<out T> : IEnumerable
            var estudianteType = estudiantes2.OfType<Estudiante>();
            var desaprobados = from e in estudianteType where e.Preomedio <= 5.0 select e;
            //foreach (Estudiante item in desaprobados)
            //{
            //    Console.WriteLine(item);
            //}
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante("juan","2a1", "1a", 5),
                new Estudiante("juan","2a1", "2a", 6),
                new Estudiante("juan","2a1", "3a", 7),
            };
            var nombrePromedio = from e in estudiantes select new { e.Nombre, e.Preomedio };
            /*solo ira nombre y promedio*/
            foreach (var item in nombrePromedio)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
