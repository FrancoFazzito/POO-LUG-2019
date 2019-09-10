using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic Personas = new List<dynamic>();

            Personas.Add(new ExpandoObject());

            Personas[0].Nombre = "homero";
            Personas[0].Apellido = "simpson";

            Personas.Add(new ExpandoObject());

            Personas[1].Nombre = "ned";
            Personas[1].Apellido = "flanders";

            dynamic count = Personas.Count;
            Console.WriteLine($"lista dynamic con {count} personas");

            foreach (var item in Personas)
            {
                Console.WriteLine($"{item.Nombre} { item.Apellido}");
            }
           
            Console.ReadLine();
        }
    }
    class Persona 
    {
        string nombre;
        string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public override string ToString()
        {
            return $"{nombre} y {apellido}";
        }
    }
}
