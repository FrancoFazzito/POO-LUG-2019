using System.Data;
using System.Data.SqlClient;

namespace ACCESO_DATOS
{
    public class ServicioDatos
    {
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;

        public ServicioDatos()
        {
            dataAdapter = new SqlDataAdapter(Consultas.SELECT_FROM_PERSONA, Consultas.CONEXION);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
            dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();
            dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
        }
        public DataTable RetornarDataTableSchema(string nombreTabla)
        {
            dataAdapter.SelectCommand.CommandText = Consultas.GetSelect(nombreTabla);
            DataTable dataTable = new DataTable(nombreTabla);
            return dataAdapter.FillSchema(dataTable, SchemaType.Mapped);
        }

        public void Guardar(DataTable dataTable)
        {
            dataAdapter.Update(dataTable);
        }

        public DataTable Leer(string nombreTabla)
        {
            DataTable dataTable = new DataTable();
            dataAdapter.SelectCommand.CommandText = Consultas.GetSelect(nombreTabla);
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }

    class Consultas
    {
        public const string CONEXION = "Data Source=.;Initial Catalog=PersonaBD;Integrated Security=True";
        public const string SELECT_FROM_PERSONA = "select * from persona";
        public static string GetSelect(string value)
        {
            return $"select * from {value}";
        }
    }
}
