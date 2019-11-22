using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCESO_DATOS
{
    public class ServicioDatos
    {
        private const string SELECT = "select * from Cliente";
        private const string CONNECTION = "Data Source=.;Initial Catalog=PracticaParcial;Integrated Security=True";

        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;

        public ServicioDatos()
        {
            dataAdapter = new SqlDataAdapter(SELECT, CONNECTION);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();
        }

        public DataTable getDataTableSchema()
        {
            dataAdapter.SelectCommand.CommandText = SELECT;
            DataTable dataTable = new DataTable();
            DataTable dataTableSchema = dataAdapter.FillSchema(dataTable, SchemaType.Mapped);
            return dataTableSchema;
        }

        public void guardar(DataTable dataTable)
        {
            dataAdapter.Update(dataTable);
        }

        public DataTable leer()
        {
            DataTable dataTable = new DataTable();
            dataAdapter.SelectCommand.CommandText = SELECT;
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
