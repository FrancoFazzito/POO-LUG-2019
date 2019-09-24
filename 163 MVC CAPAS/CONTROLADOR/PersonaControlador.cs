using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;

namespace CONTROLADOR
{
    public class PersonaControlador
    {
        private ModeloData data;

        public PersonaControlador()
        {
            this.data = new ModeloData();
        }

        public bool Login(int codigo,string contra)
        {
            return data.login(codigo, contra);
        }

        public Persona GetPersonaLogin(int codigo, string contra)
        {
            var dataLogin = data.GetDataLogin(codigo,contra);
            int codigoLeido = Convert.ToInt32(dataLogin[0]);
            string nombre = Convert.ToString(dataLogin[1]);
            string apellido = Convert.ToString(dataLogin[2]);
            DateTime fechaNacimiento = Convert.ToDateTime(dataLogin[3]);
            return new Persona(codigoLeido, nombre, apellido, fechaNacimiento);
        }
    }
}
