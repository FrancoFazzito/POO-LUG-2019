using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante("juan", "12a", "2a", 5),
                new Estudiante("juan1", "12b", "2b", 6),
                new Estudiante("juan2", "12c", "2a", 7),
                new Estudiante("juan3", "12d", "2b", 4),
                new Estudiante("juan4", "12e", "2a", 3),
                new Estudiante("juan5", "12f", "2b", 2),
                new Estudiante("juan6", "12g", "2a", 10),
            };
            var desaprobados = from e in estudiantes where e.Preomedio <= 4.0 select e;
            Console.WriteLine("desaprobaron");
            foreach(Estudiante ARevisar in desaprobados)
            {
                Console.WriteLine(ARevisar);
            }
            foreach (Estudiante ARevisar in desaprobados)
            {
                Console.WriteLine(ARevisar.Nombre);
            }

            var encontradosCurso = from e in estudiantes where e.Curso == "2a" select e.Curso;

            foreach (string encontrar in encontradosCurso)
            {
                Console.WriteLine(encontrar);
            }
            Console.ReadKey();
        }
    }
}
