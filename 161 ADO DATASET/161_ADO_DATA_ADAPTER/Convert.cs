using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161_ADO_DATA_ADAPTER
{
    static class Convert
    {
        public static string ToStringValue(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                return textBox.Text;
            }
            else
            {
                throw new Exception(getMessageError(textBox));
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
                throw new Exception(getMessageError(textBox));
            }
        }

        private static string getMessageError(TextBox textBox)
        {
            return $"ERROR EN {textBox.Name}";
        }


    }
}
