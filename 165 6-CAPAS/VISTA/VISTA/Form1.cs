using CONTROLADORES;
using INTERFACES;
using System;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Form1 : Form, IABMC
    {
        private ControladorFormPersona controlador;
        public Form1()
        {
            InitializeComponent();
            controlador = new ControladorFormPersona(this);
            Consultar();
        }

        public void Alta()
        {
            controlador.Alta();
            Consultar();
        }

        public void Baja()
        {
            controlador.Baja();
            Consultar();
        }

        public void Consultar()
        {
            controlador.Consultar();
        }

        public void ConsultarFiltro()
        {
            controlador.ConsultarFiltro();
        }

        public void Modificacion()
        {
            controlador.Modificacion();
            Consultar();
        }

        private void Btn_alta_Click(object sender, EventArgs e)
        {
            try
            {
                Alta();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }

        }

        private static void MostrarExcepcion(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private void Btn_baja_Click(object sender, EventArgs e)
        {
            try
            {
                Baja();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }

        }

        private void Btn_modificacion_Click(object sender, EventArgs e)
        {
            try
            {
                Modificacion();
            }
            catch (Exception ex)
            {
                MostrarExcepcion(ex);
            }

        }


        private void DGV_persona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlador.CargaDatosPersona();
        }
    }
}
