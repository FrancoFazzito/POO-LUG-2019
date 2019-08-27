using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADO_conectado_Refactor
{
    public partial class Form1 : Form
    {

        HandlerBDPersona handler;
        public Form1()
        {
            InitializeComponent();
            handler = new HandlerBDPersona();
            handler.EventUpdate += UpdateDGV;
            this.UpdateDGV(0, null);
        }

        private void UpdateDGV(object sender, EventArgs e)
        {
            CargarDGV(handler.SelectPersona());
            lbl_count_row.Text = sender.ToString();
        }

        private void CargarDGV(List<Persona> list)
        {
            dgv_personas.DataSource = null;
            dgv_personas.DataSource = list;
        }

        private void Btn_alta_persona_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetId();
                string nombre = GetNombre();
                string apellido = GetApellido();
                handler.AltaPersona(id, nombre, apellido);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

        }

        private static void MostrarError(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private void Btn_modificar_persona_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetId();
                string nombre = GetNombre();
                string apellido = GetApellido();
                handler.ModificarPersona(id, nombre, apellido);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

        }

        private void Btn_baja_persona_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetId();
                handler.BajaPersona(id);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }


        private string GetApellido()
        {
            return Convert.ToStringValue(txt_apellido_persona);
        }

        private string GetNombre()
        {
            return Convert.ToStringValue(txt_nombre_persona);
        }

        private int GetId()
        {
            return Convert.ToIntValue(txt_id_persona);
        }

        private void Btn_filtrar_personas_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = GetFiltro();
                if (filtro != string.Empty)
                {
                    CargarDGV(handler.SelectFiltroPersona(filtro));
                }
                else
                {
                    UpdateDGV(0, null);
                }

            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private string GetFiltro()
        {
            return Convert.ToStringValueEmpty(txt_filtro);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDGV(handler.SortApellidoAsc());
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void Btn_borrar_todo_Click(object sender, EventArgs e)
        {
            try
            {
                handler.BajaTodasPersonas();
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                handler.AltaPersona(1, "franco", "fazzito");
                handler.AltaPersona(2, "florencia", "patiño");
                handler.AltaPersona(3, "franco", "balich");
                handler.AltaPersona(4, "katia", "perchet");
                handler.AltaPersona(5, "dario", "cardacci");
                UpdateDGV(5, null);
            }
            catch (Exception ex)
            {
                MostrarError(ex);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //handler.CreateDataAdapter();
        }
    }
}
