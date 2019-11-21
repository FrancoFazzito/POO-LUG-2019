using ENTIDADES;
using INTERFACES;
using MAPPERS;
using System;
using System.Collections.Generic;

namespace NEGOCIO
{
    public class GestorPersona : IABMC_generica<Persona>
    {
        private MapperPersona mapper;
        public GestorPersona()
        {
            mapper = new MapperPersona();
        }
        public void Alta(Persona value)
        {
            //logica






            //
            mapper.Alta(value);
        }

        public void Baja(Persona value)
        {
            mapper.Baja(value);
        }

        public List<Persona> Consultar()
        {
            List<Persona> personas = new List<Persona>();
            personas = mapper.Consultar();
            return personas;
        }

        public void ConsultarFiltro(Persona value)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Persona value)
        {
            mapper.Modificacion(value);
        }
    }
}
