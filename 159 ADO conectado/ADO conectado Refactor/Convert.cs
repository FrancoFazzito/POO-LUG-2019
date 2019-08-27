using System;
using System.Windows.Forms;

namespace ADO_conectado_Refactor
{
    static class Convert
    {

        public static string ToStringValue(TextBox textBox)
        {
            string value;
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                return value = textBox.Text;
            }
            else
            {
                string message = $"Error en {textBox.Name}";
                throw new Exception(message);
            }
        }

        public static string ToStringValueEmpty(TextBox textBox)
        {
            return textBox.Text;
        }

        public static int ToIntValue(TextBox textBox)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                return value;
            }
            else
            {
                string message = $"Error en {textBox.Name}";
                throw new Exception(message);
            }
        }
    }
}
