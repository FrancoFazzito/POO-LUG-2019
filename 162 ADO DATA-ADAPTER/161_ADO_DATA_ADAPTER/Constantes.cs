using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _161_ADO_DATA_ADAPTER
{
    public static class Constantes
    {
        public static class Alumno
        {
            public const string TABLA = "Alumnos";
            public const string LEGAJO = "Legajo";
            public const string NOMBRE = "Nombre";
            public const string APELLIDO = "Apellido";
        }

        public static class Telefono
        {
            public const string TABLA = "Telefonos";
            public const string LEGAJO_RELACION = "Legajo_Alumno";
            public const string NUMERO = "Numero";
        }

        public static class File
        {
            public const string XML = "DatosTabla.XML";
        }

        public static class Relation
        {
            public const string RELATION_ALUMNO_TEL = "Alumno_Telefono";
        }
        public static class Connection
        {
            public const string CONNECTION_STRING = "Data Source=.;Initial Catalog=Alumno_Telefono;Integrated Security=True";
            public const string SELECT_FROM = "select * from Alumno";
        }
    }
}
