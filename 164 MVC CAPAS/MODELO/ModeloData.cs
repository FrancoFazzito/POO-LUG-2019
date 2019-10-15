using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace MODELO
{
    public class ModeloData
    {
        public bool login(int codigo,string contra)
        {
            using (SqlConnection connection = new SqlConnection(Constantes.CONEXION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Constantes.CONSULTA_LOGIN, connection))
                {
                    command.Parameters.AddWithValue(Constantes.CAMPO_CODIGO, codigo);
                    command.Parameters.AddWithValue(Constantes.CAMPO_CONTRA, contra);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public object[] GetDataLogin(int codigo, string contra)
        {
            using (SqlConnection connection = new SqlConnection(Constantes.CONEXION_STRING))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(Constantes.CONSULTA_LOGIN, connection))
                {
                    command.Parameters.AddWithValue(Constantes.CAMPO_CODIGO, codigo);
                    command.Parameters.AddWithValue(Constantes.CAMPO_CONTRA, contra);
                    command.CommandType = CommandType.Text;
                    SqlDataReader result = command.ExecuteReader();

                    result.Read();

                    return new object[] { result[0], result[1], result[2], result[3] };
                }
            }
        }
    }
}
