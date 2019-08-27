using System;
using System.Windows.Forms;

namespace ADO_desconectado
{
    static class Convert
    {
        public static int ToIntValue(TextBox textbox)
        {

            int value;
            if (int.TryParse(textbox.Text, out value))
            {
                return value;
            }
            else
            {
                throw new Exception($"error en {textbox.Name}");
            }


        }
        public static string ToStringValue(TextBox textbox)
        {
            string value;
            if (!string.IsNullOrWhiteSpace(textbox.Text))
            {
                return value = textbox.Text;
            }
            else
            {
                throw new Exception($"error en {textbox.Name}");
            }
        }
    }
}
