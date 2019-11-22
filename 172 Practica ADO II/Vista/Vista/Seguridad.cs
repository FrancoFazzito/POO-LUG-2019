using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Seguridad : UserControl
    {
        public Seguridad()
        {
            InitializeComponent();
            
        }

        private void Control_Resize(object sender, EventArgs e)
        {
            this.Control_Load(null, null);
        }

        private void Control_Load(object sender, EventArgs e)
        {
            this.textBox1.Location = new Point(0, 0);
            this.textBox1.Size = this.Size;
        }

        public bool Validacion
        {
            get
            {
                string valorTexto = this.textBox1.Text;
                Regex regexCodigo = new Regex(@"\w{2}[-]\d{2}[-]\w{2}");
                Match matchCodigo = regexCodigo.Match(valorTexto);
                return matchCodigo.Success;
            }
        }
    }
}
