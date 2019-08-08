using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varios_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 SegundaForma = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            
            //cuando se cierra no hay dispose
            //show
            SegundaForma.Show(); //modal            
            //showdialos
            //SegundaForma.ShowDialog(); //no modal no permite ir a la uno
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult result = SegundaForma.ShowDialog();//guardar el dialog result en un tipo dialogresult 

            /*hacemos una propiedad en segunda forma*/
            if (result == DialogResult.OK)
            {
                lblMensaje.Text = SegundaForma.Mensaje;
                label1.Text = SegundaForma.Contenido;
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("HA CANCELADO");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
