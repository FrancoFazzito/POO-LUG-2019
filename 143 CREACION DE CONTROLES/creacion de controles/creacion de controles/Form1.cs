using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creacion_de_controles
{
    public partial class Form1 : Form
    {
        //2 modos heredar el especifico o heredar el control
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customControl11_Click(object sender, EventArgs e)
        {
            customControl11.Activado = !customControl11.Activado;
        }
    }
}
