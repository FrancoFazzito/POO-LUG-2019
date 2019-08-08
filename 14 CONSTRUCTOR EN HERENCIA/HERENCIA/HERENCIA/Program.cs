using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HERENCIA
{
    class Program
    {
        static void Main(string[] args)
        {
            //PERSONA TIENE EDAD Y NOMBRE Y UN METODO MUESTRA, ESTO SE HEREDA A EMPLEADO QUE TIENE PUESTO Y SALARIO
            //PERSONA: NOMBRE Y EDAD // HEREDARLO A EMPLEADO QUE TIENE PUESTO SALARIO // EMPLEADO TIENE NOMBRE EDAD PUESTO Y SALARIO
            Persona persona = new Persona("maria", 45);
            persona.muestra();
            //PERSONA TIENE EDAD Y NOMBRE UNICAMENTE
            Console.WriteLine("------");


                                          //CONSTRUCTOR EMPLEADO //CONSTRUCTOR PERSONA
            empleado empleado = new empleado("director", 30000, "juan", 23);
            //EMEPLEADO TIENE PUESTO SALARIO Y LOS ATRIBUTOS HEREDADOS DE PERSONA QUE TIENE EDAD Y NOMBRE
            empleado.muestraempleado();
            Console.WriteLine("------");
            Console.ReadKey();
        }
    }
}
