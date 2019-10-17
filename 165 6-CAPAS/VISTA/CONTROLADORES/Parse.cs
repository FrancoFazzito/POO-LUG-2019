using System;

namespace CONTROLADORES
{
    class Parse
    {
        public static int ToIntValue(object value)
        {
            int intValue;
            if (int.TryParse(value.ToString(), out intValue))
            {
                return intValue;
            }
            else
            {
                throw new Exception($"ERROR DE INGRESO DE DATOS [{value.ToString()}]");
            }
        }
        public static string ToStringValue(object value)
        {
            if (!string.IsNullOrEmpty(value.ToString()))
            {
                return value.ToString();
            }
            else
            {
                throw new Exception($"ERROR DE INGRESO DE DATOS [{value.ToString()}]");
            }
        }
    }
}
