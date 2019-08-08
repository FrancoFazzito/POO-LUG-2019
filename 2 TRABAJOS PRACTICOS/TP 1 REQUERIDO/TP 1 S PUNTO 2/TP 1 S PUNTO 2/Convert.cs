using System;
using System.Windows.Forms;

namespace TP_1_S_PUNTO_2
{
    static class Convert
    {
        #region STRING
        public static string ConvertToString(TextBox text)
        {
            string value = "";
            try
            {
                value = text.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en el textbox " + text.Name);
            }
            return value;
        }
        public static string convertToStringCombobox(ComboBox combo)
        {
            string value = "";
            try
            {
                value = combo.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en el combo " + combo.Name);
            }
            return value;
        }
        #endregion

        #region INT
        public static int ConvertToInt(TextBox text)
        {
            int value = 0;
            try
            {
                value = int.Parse(text.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en el textbox " + text.Name);
            }
            return value;
        }

        #endregion

        #region DOUBLE
        public static double ConvertToDouble(TextBox text)
        {
            double value = 0;
            try
            {
                value = double.Parse(text.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en el textbox " + text.Name);
            }
            return value;
        }
        #endregion
    }
}
