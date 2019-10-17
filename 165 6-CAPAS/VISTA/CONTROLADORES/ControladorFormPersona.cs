using ENTIDADES;
using INTERFACES;
using NEGOCIO;
using System;
using System.Windows.Forms;
namespace CONTROLADORES
{
    public class ControladorFormPersona : IABMC
    {

        private Form form;
        private GestorPersona gestor;

        public ControladorFormPersona(Form formPersona)
        {
            this.form = formPersona;
            gestor = new GestorPersona();
        }

        public void Alta()
        {
            Persona persona = new Persona();

            persona.Codigo = GetCodigoForm();
            persona.Nombre = GetNombreForm();
            persona.Apellido = GetApellidoForm();

            gestor.Alta(persona);
        }

        private string GetApellidoForm()
        {
            TextBox textBox = this.form.Controls[NombresForm.APELLIDO] as TextBox;
            string value = Parse.ToStringValue(textBox.Text);
            return value;
        }

        private string GetNombreForm()
        {
            TextBox textBox = this.form.Controls[NombresForm.NOMBRE] as TextBox;
            string value = Parse.ToStringValue(textBox.Text);
            return value;
        }

        private int GetCodigoForm()
        {
            TextBox textBox = this.form.Controls[NombresForm.CODIGO] as TextBox;
            int value = Parse.ToIntValue(textBox.Text);
            return value;
        }

        private Persona GetPersonaDGV()
        {
            DataGridView DataGridPersona = this.form.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            Persona personaDGV = DataGridPersona.SelectedRows[0].DataBoundItem as Persona;
            return personaDGV;
        }

        public void CargaDatosPersona()
        {
            Persona persona = GetPersonaDGV();
            this.form.Controls[NombresForm.CODIGO].Text = persona.Codigo.ToString();
            this.form.Controls[NombresForm.NOMBRE].Text = persona.Nombre;
            this.form.Controls[NombresForm.APELLIDO].Text = persona.Apellido;
        }

        public void Baja()
        {
            Persona persona = GetPersonaDGV();
            gestor.Baja(persona);
        }

        public void Consultar()
        {
            DataGridView DataGridPersona = this.form.Controls[NombresForm.DGV_PERSONA] as DataGridView;
            DataGridPersona.DataSource = null;
            DataGridPersona.DataSource = gestor.Consultar();
        }

        public void ConsultarFiltro()
        {
            throw new NotImplementedException();
        }

        public void Modificacion()
        {
            Persona persona = new Persona();

            persona.Codigo = GetCodigoForm();
            persona.Nombre = GetNombreForm();
            persona.Apellido = GetApellidoForm();

            gestor.Modificacion(persona);
        }
    }
}
