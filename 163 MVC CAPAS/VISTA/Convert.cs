using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    internal static class Convert
    {
        public static int TextBoxToInt(TextBox textBox)
        {
            int value;
            if (int.TryParse(textBox.Text,out value))
            {
                return value;
            }
            else
            {
                throw new Exception(getMensaje(textBox.Name));
            }
        }

        public static string TextBoxToString(TextBox textBox)
        {
            string value = textBox.Text;
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }
            else
            {
                throw new Exception(getMensaje(textBox.Name));
            }
        }

        private static string getMensaje(string nombreControl)
        {
            return $"error en {nombreControl}";
        }
    }
}
