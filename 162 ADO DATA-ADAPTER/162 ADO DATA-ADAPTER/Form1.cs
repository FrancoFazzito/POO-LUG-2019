using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _162_ADO_DATA_ADAPTER
{
    public partial class Form1 : Form
    {
        private BDhandler handler;
        public Form1()
        {
            InitializeComponent();
            handler = new BDhandler();
            handler.ActualizacionBD += Handler_ActualizacionBD;
            handler.Actualizar();
            mostrarAlumno();
            mostrarTelefonos();
        }

        private void Handler_ActualizacionBD(object sender, EventArgs e)
        {
            handler.Actualizar();
            mostrarTelefonosAlumno();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = new Alumno(
                    id: Convert.ToIntValue(txt_id),
                    nombre: Convert.ToStringValue(txt_nombre),
                    apellido: Convert.ToStringValue(txt_apellido));
                handler.AltaAlumno(alumno);
                mostrarAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = getAlumnoDGV();
                Alumno alumnoModificar = new Alumno(
                    id: alumno.Id,
                    nombre: Convert.ToStringValue(txt_nombre),
                    apellido: Convert.ToStringValue(txt_apellido));
                handler.ModificarAlumno(alumnoModificar);
                mostrarAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = getAlumnoDGV();
                foreach (Telefono telefono in handler.GetTelefonosAlumno(getAlumnoDGV()))
                {
                    handler.BajaTelefono(telefono);
                }
                handler.BajaAlumno(alumno);
                mostrarAlumno();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void mostrarAlumno()
        {
            mostrar(dataGridView1, handler.GetAlumnos());
        }
        public void mostrarTelefonosAlumno()
        {
            List<Telefono> listaTelefonos = handler.GetTelefonosAlumno(getAlumnoDGV());
            if (listaTelefonos.Count > 0)
            {
                mostrar(dataGridView2, listaTelefonos);
            }
            else
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }
        public void mostrarTelefonos()
        {
            mostrar(dataGridView2, handler.GetTelefonos());
        }
        private void mostrar(DataGridView view, object data)
        {
            view.DataSource = null;
            view.DataSource = data;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarTelefonosAlumno();
            Alumno alumno = getAlumnoDGV();
            txt_id.Text = alumno.Id.ToString();
            txt_apellido.Text = alumno.Apellido.ToString();
            txt_nombre.Text = alumno.Nombre.ToString();
        }

        private Alumno getAlumnoDGV()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumno = dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
                Telefono telefono = new Telefono(
                    id: Convert.ToIntValue(txt_id_telefono),
                    numero: Convert.ToStringValue(txt_telefono));
                handler.AltaTelefono(telefono, alumno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Telefono telefono = dataGridView2.SelectedRows[0].DataBoundItem as Telefono;
                Telefono telefonoModificar = new Telefono(
                    id: telefono.Id,
                    numero: Convert.ToStringValue(txt_telefono));
                handler.ModificarTelefono(telefonoModificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Telefono telefono = dataGridView2.SelectedRows[0].DataBoundItem as Telefono;
                handler.BajaTelefono(telefono);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                mostrarTelefonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
