using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROLADOR;
namespace VISTA
{
    public partial class Form1 : Form
    {
        PersonaControlador modelo;
        public Form1()
        {
            InitializeComponent();
            txt_contra.PasswordChar = '*';
            modelo = new PersonaControlador();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = GetCodigo();
                string contra = GetContra();
                modelo.Login(codigo, contra);
                Persona personaMostrar = modelo.GetPersonaLogin(codigo, contra);
                agregarListBox(personaMostrar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string GetContra()
        {
            return Convert.TextBoxToString(txt_contra);
        }

        private int GetCodigo()
        {
            return Convert.TextBoxToInt(txt_id);
        }

        private void agregarListBox(Persona persona)
        {
            list_datos_persona.Items.Add($"codigo:{persona.Codigo}");
            list_datos_persona.Items.Add($"nombre:{persona.Nombre}");
            list_datos_persona.Items.Add($"apellido:{persona.Apellido}");
            list_datos_persona.Items.Add($"fecha de Nacimiento:{persona.FechaNacimiento.ToShortDateString()}");
        }
    }
}
