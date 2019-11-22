using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTIDADES;
using INTERFACES;
using ACCESO_DATOS;

namespace MAPPER
{
    public class MapperCliente : IABMC_Generico<Cliente>
    {
        private ServicioDatos servicioDatos;

        public MapperCliente()
        {
            servicioDatos = new ServicioDatos();
        }

        public void Alta(Cliente value)
        {
            DataTable dataTable = servicioDatos.getDataTableSchema();
            DataRow dataRow = dataTable.NewRow();
            dataRow[CamposCliente.id] = value.Id;
            dataRow[CamposCliente.nombre] = value.Nombre;
            dataTable.Rows.Add(dataRow);
            servicioDatos.guardar(dataTable);
        }

        public void Baja(Cliente value)
        {
            DataTable dataTable = servicioDatos.leer();
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[CamposCliente.id] };
            DataRow datarow = dataTable.Rows.Find(value.Id);
            datarow.Delete();
            servicioDatos.guardar(dataTable);
        }

        public List<Cliente> Consultar()
        {
            List<Cliente> clientes = new List<Cliente>();
            DataTable dataTable = servicioDatos.leer();
            foreach (DataRow row in dataTable.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(row[CamposCliente.id]);
                cliente.Nombre = Convert.ToString(row[CamposCliente.nombre]);
                clientes.Add(cliente);
            }
            return clientes;
        }

        public List<Cliente> ConsultarFiltro()
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Cliente value)
        {
            DataTable dataTable = servicioDatos.leer();
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[CamposCliente.id] };
            DataRow datarow = dataTable.Rows.Find(value.Id);
            datarow[CamposCliente.id] = value.Id;
            datarow[CamposCliente.nombre] = value.Nombre;
            servicioDatos.guardar(dataTable);
        }
    }

    public static class CamposCliente
    {
        public const string id = "id";
        public const string nombre = "nombre";
    }
}
