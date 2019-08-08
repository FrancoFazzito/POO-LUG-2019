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
            List<estudiante> estudiantes = new List<estudiante>()
            {
                new estudiante("juan", 123),
                new estudiante("juan1", 124),
                new estudiante("juan2", 125),
                new estudiante("juan3", 126),
                new estudiante("juan4", 127),
            };
            List<curso> cursos = new List<curso>()
            {
                new curso("programacion",125),
                new curso("programacion1",123),
                new curso("programacion2",124),
                new curso("programacion3",123),
            };
            var listado = from e in estudiantes join c in cursos on e.Id equals c.Id select e.Nombre + " curso la materia " + c.Nombre;
            foreach (string item in listado)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
