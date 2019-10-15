using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADOR
{
    public class Persona
    {
        private int codigo;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;

        public Persona(int codigo, string nombre, string apellido, DateTime dateTime)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = dateTime;
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
        }
    }
}
