using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ADO_conectado_Refactor
{
    class HandlerBDPersona
    {
        private DataTable tablaPersona;
        private DataSet dataSetPersona;

        public event EventHandler EventUpdate;

        private const string CONNECTION_STRING = "Data Source=.;Initial Catalog=Persona;Integrated Security=True";

        #region PERSONA
        private const string DATASET_TABLA_PERSONA = "DataSetPersona";
        private const string TABLA_PERSONA = "Persona";
        private const string DATA_ADAPTER_PERSONA = "PersonaDataAdapter";

        private const string APELLIDO = "Apellido";
        private const string NOMBRE = "Nombre";
        private const string ID = "Id";

        private const string ALL = "Id,Nombre,Apellido";
        #endregion

        #region PARAMETROS
        private const string PARAMETER_ID = "@id";
        private const string PARAMETER_NOMBRE = "@nombre";
        private const string PARAMATER_APELLIDO = "@apellido";
        private const string PARAMETER_FILTRO = "@filtro";
        
        #endregion

        #region CONSULTAS
        private readonly string ALTA_PERSONA = $"INSERT INTO {TABLA_PERSONA} ({ID},{APELLIDO},{NOMBRE}) VALUES ({PARAMETER_ID},{PARAMETER_NOMBRE},{PARAMATER_APELLIDO})";
        private readonly string MODIFICAR_PERSONA = $"UPDATE {TABLA_PERSONA} SET {NOMBRE} = {PARAMETER_NOMBRE} , {APELLIDO} = {PARAMATER_APELLIDO} WHERE {ID} = {PARAMETER_ID};";
        private readonly string BAJA_PERSONA = $"DELETE FROM {TABLA_PERSONA} WHERE {ID} = {PARAMETER_ID};";
        private readonly string BAJA_TODAS_PERSONAS = $"DELETE FROM {TABLA_PERSONA}";
        private readonly string SELECT_FILTRO_NOMBRE = $"SELECT {ALL} FROM {TABLA_PERSONA} WHERE {NOMBRE} LIKE {PARAMETER_FILTRO}";
        private readonly string SELECT = $"SELECT {ALL} FROM {TABLA_PERSONA}";
        private readonly string ORDERBY_ID_ASC = $"SELECT {ALL} FROM {TABLA_PERSONA} ORDER BY {APELLIDO} ASC";
        private readonly string EXIST_ID = $"SELECT 1 FROM {TABLA_PERSONA} WHERE {ID} = {PARAMETER_ID}";
        #endregion

        public HandlerBDPersona()
        {
            //tablaPersona = new DataTable(TABLA_PERSONA);
            //dataSetPersona = new DataSet(DATASET_TABLA_PERSONA);
            //dataSetPersona.Tables.Add(tablaPersona);
        }

        public void AltaPersona(int id, string nombre, string apellido)
        {
            if (!ExisteID(id))
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(ALTA_PERSONA, connection))
                    {
                        command.Parameters.AddWithValue(PARAMETER_ID, id);
                        command.Parameters.AddWithValue(PARAMETER_NOMBRE, nombre);
                        command.Parameters.AddWithValue(PARAMATER_APELLIDO, apellido);
                        int rows = command.ExecuteNonQuery();
                        this.EventUpdate?.Invoke(rows, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception(getErrorMensaje(id));
            }

        }

        public void BajaPersona(int id)
        {
            if (ExisteID(id))
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(BAJA_PERSONA, connection))
                    {
                        command.Parameters.AddWithValue(PARAMETER_ID, id);
                        int rows = command.ExecuteNonQuery();
                        this.EventUpdate?.Invoke(rows, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception(getErrorMensaje(id));
            }
        }

        public void ModificarPersona(int id, string nombre, string apellido)
        {
            if (ExisteID(id))
            {
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(MODIFICAR_PERSONA, connection))
                    {
                        command.Parameters.AddWithValue(PARAMETER_ID, id);
                        command.Parameters.AddWithValue(PARAMETER_NOMBRE, nombre);
                        command.Parameters.AddWithValue(PARAMATER_APELLIDO, apellido);
                        int rows = command.ExecuteNonQuery();
                        this.EventUpdate?.Invoke(rows, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception(getErrorMensaje(id));
            }
        }

        private string getErrorMensaje(int id)
        {
            return $"HA OCURRIDO UN ERROR CON EL ID {id}";
        }

        private bool ExisteID(int id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(EXIST_ID, connection))
                {
                    command.Parameters.AddWithValue(PARAMETER_ID, id);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public List<Persona> SelectPersona()
        {
            List<Persona> personas = new List<Persona>();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(SELECT, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido = reader.GetString(2);

                            Persona persona = new Persona(id, nombre, apellido);
                            personas.Add(persona);
                        }
                    }
                }
            }

            return personas;
        }

        public List<Persona> SelectFiltroPersona(string filtro)
        {
            List<Persona> personas = new List<Persona>();

            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(SELECT_FILTRO_NOMBRE, connection))
                {
                    command.Parameters.AddWithValue(PARAMETER_FILTRO, filtro);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido = reader.GetString(2);

                            Persona persona = new Persona(id, nombre, apellido);
                            personas.Add(persona);
                        }
                    }
                }
            }

            return personas;
        }

        public List<Persona> SortApellidoAsc()
        {
            List<Persona> personas = new List<Persona>();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(ORDERBY_ID_ASC, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido = reader.GetString(2);

                            Persona persona = new Persona(id, nombre, apellido);
                            personas.Add(persona);
                        }
                    }
                }
            }
            return personas;
        }

        public void BajaTodasPersonas()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(BAJA_TODAS_PERSONAS, connection))
                {
                    int rows = command.ExecuteNonQuery();
                    this.EventUpdate?.Invoke(rows, new EventArgs());
                }
            }
        }

        //public void CreateDataAdapter()
        //{
        //    SqlDataAdapter dataAdapter = new SqlDataAdapter(SELECT, CONNECTION_STRING);
        //    dataAdapter.Fill(dataSetPersona, DATA_ADAPTER_PERSONA);
        //    tablaPersona = dataSetPersona.Tables[TABLA_PERSONA];
        //    int tableCount = dataSetPersona.Tables.Count;
        //}
    }
}
