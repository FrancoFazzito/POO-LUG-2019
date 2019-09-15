namespace _162_ADO_DATA_ADAPTER
{
    static class Constantes
    {
        public const string CONEXION = "Data Source=.;Initial Catalog=lug 2019;Integrated Security=True";

        public const string ALUMNO_TABLA = "Alumno";
        public const string ALUMNO_ID = "Id";
        public const string ALUMNO_NOMBRE = "Nombre";
        public const string ALUMNO_APELLIDO = "Apellido";
        public const string ALUMNO_FROM = "select * from Alumno";

        public const string TELEFONO_TABLA = "Telefono";
        public const string TELEFONO_ID = "Id";
        public const string TELEFONO_NUMERO = "Numero";
        public const string TELEFONO_ALUMNO_ID = "Alumno_id";
        public const string TELEFONO_FROM = "select * from Telefono";

        public const string RELATION_ALUMNO_TELEFONO = "Alumno_Telefono";
    }
}
