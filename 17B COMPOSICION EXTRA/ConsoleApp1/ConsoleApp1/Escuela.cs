using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Escuela
    {
        private string nombre;
        private Aula[] aulas = new Aula[3];

        public Escuela(string nombre)
        {
            this.nombre = nombre;
        }

        public void calculaAula()
        {
           
            string nombre = "";
            int cantidad = 0;
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine("dame nombre del aula");
                nombre = Console.ReadLine();

                Console.WriteLine("dame cantidad de alumnos");
                cantidad = int.Parse(Console.ReadLine());
                aulas[i] = new Aula(nombre, cantidad);

            }
        }
        public override string ToString()
        {
            string mensaje = "";

            mensaje = string.Format("BIENVENIDOS A LA ESCUELA {0} LA CUAL CONSTA DE \r\n", nombre);
            //HACE COMO SI FUERA UN READ CON ESE FORMATO
            for (int i = 0; i < aulas.Length; i++)
            {
                mensaje += aulas[i].ToString() + "\r\n";
            }
            return mensaje;
        }
    }
}
