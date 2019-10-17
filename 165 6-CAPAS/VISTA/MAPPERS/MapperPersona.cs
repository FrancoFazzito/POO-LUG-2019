using ACCESO_DATOS;
using ENTIDADES;
using INTERFACES;
using System;
using System.Collections.Generic;
using System.Data;

namespace MAPPERS
{
    public class MapperPersona : IABMC_generica<Persona>
    {
        private ServicioDatos servicio;
        public MapperPersona()
        {
            servicio = new ServicioDatos();
        }
        public void Alta(Persona value)
        {
            DataTable dataTablePersona = servicio.RetornarDataTablePersona(Campos.TABLA_PERSONA);
            DataRow row = dataTablePersona.NewRow();
            row[Campos.CODIGO_PERSONA] = value.Codigo;
            row[Campos.NOMBRE_PERSONA] = value.Nombre;
            row[Campos.APELLIDO_PERSONA] = value.Apellido;
            dataTablePersona.Rows.Add(row);
            Guardar(dataTablePersona);
        }
        private void Guardar(DataTable dataTableGuardar)
        {
            servicio.Guardar(dataTableGuardar);
        }

        public void Baja(Persona value)
        {
            DataTable dataTable = servicio.Leer(Consultas.SELECT_FROM);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[Campos.CODIGO_PERSONA] };
            dataTable.Rows.Find(value.Codigo).Delete();
            Guardar(dataTable);
        }

        public List<Persona> Consultar()
        {
            List<Persona> personas = new List<Persona>();
            DataTable dataTable = servicio.Leer(Consultas.SELECT_FROM);
            foreach (DataRow row in dataTable.Rows)
            {
                Persona persona = new Persona();
                persona.Codigo = Convert.ToInt32(row[Campos.CODIGO_PERSONA]);
                persona.Nombre = Convert.ToString(row[Campos.NOMBRE_PERSONA]);
                persona.Apellido = Convert.ToString(row[Campos.APELLIDO_PERSONA]);
                personas.Add(persona);
            }
            return personas;
        }

        public void ConsultarFiltro(Persona value)
        {
            throw new NotImplementedException();
        }

        public void Modificacion(Persona value)
        {
            DataTable dataTable = servicio.Leer(Consultas.SELECT_FROM);
            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns[Campos.CODIGO_PERSONA] };
            DataRow row = dataTable.Rows.Find(value.Codigo);
            row[Campos.APELLIDO_PERSONA] = value.Apellido;
            row[Campos.NOMBRE_PERSONA] = value.Nombre;
            Guardar(dataTable);
        }
    }
}
