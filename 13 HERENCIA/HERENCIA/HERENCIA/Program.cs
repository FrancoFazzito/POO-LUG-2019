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
            Persona persona = new Persona();
            //PERSONA TIENE EDAD Y NOMBRE UNICAMENTE
            persona.Edad = 25;
            persona.Nombre = "maria";
            Console.WriteLine("------");
            persona.muestra();

            empleado empleado = new empleado("director", 30000, "juan", 23);
            //EMEPLEADO TIENE PUESTO SALARIO Y LOS ATRIBUTOS HEREDADOS DE PERSONA QUE TIENE EDAD Y NOMBRE
            Console.WriteLine("------");
            empleado.muestraempleado();
            empleado empleado2 = new empleado();

            //ATRIBUTO PERSONA
            empleado2.Edad = 26;
            empleado2.Nombre = "juan";

            //ATRIBUTO EMPLEADO
            empleado2.Puesto = "administrador";
            empleado2.Salario = 20000;

            Console.WriteLine("------");
            //metodo de persona
            empleado2.muestra();
            Console.WriteLine("------");
            //metodo de empleado
            empleado2.muestraempleado();
            Console.ReadKey();
        }
    }
}
