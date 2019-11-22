using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLLER;

namespace Vista
{
    public partial class Form1 : Form
    {
        private ControllerCliente controllerCliente;
        public Form1()
        {
            InitializeComponent();
            controllerCliente = new ControllerCliente(this);
            controllerCliente.Consultar();
        }

        private void Btn_alta_Click(object sender, EventArgs e)
        {
            if (this.control_seguridad.Validacion)
            {
                controllerCliente.Alta();
                controllerCliente.Consultar();
            }
            
        }

        private void Btn_baja_Click(object sender, EventArgs e)
        {
            if (this.control_seguridad.Validacion)
            {
                controllerCliente.Baja();
                controllerCliente.Consultar();
            }
        }

        private void Btn_modificacion_Click(object sender, EventArgs e)
        {
            if (this.control_seguridad.Validacion)
            {
                controllerCliente.Modificacion();
                controllerCliente.Consultar();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            controllerCliente.DibujarTorta();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            controllerCliente.DibujarBarra();
        }
    }
}
