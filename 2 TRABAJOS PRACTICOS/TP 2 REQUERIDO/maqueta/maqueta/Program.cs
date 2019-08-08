using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maqueta
{
    class Program
    {
        static void Main(string[] args)
        {
            Universidad universidad = new Universidad();
            universidad.AddAlumno(1, "a", "e");
            universidad.AddAlumno(2, "b", "d");
            universidad.AddAlumno(3, "c", "c");
            universidad.AddAlumno(4, "d", "b");
            universidad.AddAlumno(5, "e", "a");
            universidad.AddAlumno(5, "e", "a");
            universidad.AddAlumno(5, "e", "a");
            universidad.AddAlumno(5, "e", "a");
            universidad.AddAlumno(5, "e", "a");
            universidad.sortAsc();
            foreach (var item in universidad.Alumnos)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("-----------");
            universidad.sortDes();
            foreach (var item in universidad.Alumnos)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }

    
}
