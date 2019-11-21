using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Regex_ControlUser
{
    public partial class Prueba : UserControl
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            textBox1.Location = new Point(0, 0);
            textBox1.Size = this.Size; 
        }

        private void Prueba_Resize(object sender, EventArgs e)
        {
            Prueba_Load(null, null);
        }

        public bool Validacion
        {
            get
            {
                string valorTexto = textBox1.Text;
                Regex regexCodigo = new Regex(@"\w{3}[-]\d{3}");
                return regexCodigo.Match(valorTexto).Success;
            }
        }

    }
}
