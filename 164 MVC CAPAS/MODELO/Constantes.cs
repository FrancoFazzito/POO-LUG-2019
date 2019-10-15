using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    internal static class Constantes
    {
        public const string CONEXION_STRING = "Data Source=.;Initial Catalog=PersonaDataBase;Integrated Security=True";
        public const string TABLA_PERSONA = "Persona";
        public const string CONSULTA_LOGIN = "select * from Persona where Persona.codigo = @codigo and PWDCOMPARE(@contrasenia, pass) = 1";
        public const string CAMPO_CODIGO = "@codigo";
        public const string CAMPO_CONTRA = "@contrasenia";
    }
}
