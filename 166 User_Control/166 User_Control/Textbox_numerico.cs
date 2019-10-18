using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _166_User_Control
{
    public partial class Textbox_numerico : UserControl
    {
        private const char INVALIDO = '\0';

        public Textbox_numerico()
        {
            InitializeComponent();
        }

        private void Textbox_numerico_Load(object sender, EventArgs e)
        {
            Txt_value.Location = new Point(0, 0);
            Txt_value.Size = this.Size;
        }

        private void Textbox_numerico_Resize(object sender, EventArgs e)
        {
            Textbox_numerico_Load(null, null);
        }
        public int TextInt
        {
            get
            {
                string value = this.Txt_value.Text;
                int valueInt;
                if (int.TryParse(value,out valueInt))
                {
                    return valueInt;
                }
                else
                {
                    throw new Exception($"error de conversion en {Txt_value.Name}");
                }
            }
        }
        public double TextDouble
        {
            get
            {
                string value = this.Txt_value.Text;
                double valueDouble;
                if (double.TryParse(value, out valueDouble))
                {
                    return valueDouble;
                }
                else
                {
                    throw new Exception($"error de conversion en {Txt_value.Name}");
                }
            }
        }

        public static bool IsNumeric(string value)
        {
            bool result = true;
            foreach (char letra in value)
            {
                if (char.IsDigit(letra))
                {
                    result = false;
                }
            }
            return result;
        }

        private void Txt_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letraPresionada = e.KeyChar;

            bool isMenos = IsMenos(letraPresionada);
            if (isMenos)
            {
                string cadenaMenos = this.Txt_value.Text.Insert(0, "-");
                this.Txt_value.Text = cadenaMenos;
            }

            bool isNumeric = IsNumeric(letraPresionada);
            bool isPunto = IsPunto(letraPresionada);
            bool isBack = IsBack(letraPresionada);
            bool isInvalido = !(isNumeric || isPunto || isBack);

            if (isInvalido)
            {
                e.KeyChar = INVALIDO;
            }
        }



        private bool IsBack(char letraPresionada)
        {
            char back = (char)Keys.Back;
            return letraPresionada == back;
        }

        private bool IsMenos(char letraPresionada)
        {
            return letraPresionada == '-';
        }

        private bool IsNumeric(char letraPresionada)
        {
            return char.IsDigit(letraPresionada);
        }

        private bool IsPunto(char letraPresionada)
        {
            return letraPresionada == '.';
        }
    }
}
