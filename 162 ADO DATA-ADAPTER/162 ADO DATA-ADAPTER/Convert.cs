using System;
using System.Windows.Forms;

namespace _162_ADO_DATA_ADAPTER
{
    static class Convert
    {
        public static string ToStringValue(TextBox textBox)
        {
            string value = textBox.Text;
            if (!string.IsNullOrEmpty(value))
            {
                return value;
            }
            else
            {
                throw new Exception($"ERROR EN {textBox.Name}");
            }
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
                throw new Exception($"ERROR EN {textBox.Name}");
            }
        }
    }
}
