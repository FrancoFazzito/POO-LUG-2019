using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INTERFACES;
using ENTIDADES;
using MAPPER;

namespace NEGOCIO
{
    public class GestorCliente : IABMC_Generico<Cliente>
    {
        private MapperCliente mapperCliente;
        public event EventHandler eventoDiez;
        public GestorCliente()
        {
            mapperCliente = new MapperCliente();
        }
        public void Alta(Cliente value)
        {
            if (value.Id == 10)
            {
                eventoDiez.Invoke(null, new EventArgs());
            }
            mapperCliente.Alta(value);
        }

        public void Baja(Cliente value)
        {
            mapperCliente.Baja(value);
        }

        public List<Cliente> Consultar()
        {
            return mapperCliente.Consultar();
        }

        public List<Cliente> ConsultarFiltro()
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Cliente value)
        {
            mapperCliente.Modificacion(value);
        }
    }
}
