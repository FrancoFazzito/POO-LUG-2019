using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADO_DATASET_RELATIONS
{
    public partial class Form1 : Form
    {
        BDhandler handler;
        public Form1()
        {
            InitializeComponent();
            handler = new BDhandler();
            Mostrar(dataGridView1, handler.GetAlumnos());
        }

        private void Btn_alta_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                handler.AltaAlumno(new Alumno(
                                legajo: Convert.ToStringValue(txt_legajo_alumno),
                                nombre: Convert.ToStringValue(txt_nombre_alumno),
                                apellido: Convert.ToStringValue(txt_apellido_alumno)
                            ));
                Mostrar(dataGridView1, handler.GetAlumnos());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Mostrar(DataGridView DGV, IEnumerable<object> data)
        {
            DGV.DataSource = null;
            DGV.DataSource = data;
        }

        private void Btn_alta_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                handler.AltaTelefonos(GetAlumnoDGV(), new Telefono(
                                numero: Convert.ToStringValue(txt_numero_telefono),
                                codigo: Convert.ToIntValue(txt_codigo_telefono)
                            ));
                Mostrar(dataGridView2, handler.GetTelefonos(GetAlumnoDGV()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void Btn_baja_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                handler.BajaAlumno(GetAlumnoDGV());
                Mostrar(dataGridView1, handler.GetAlumnos());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Alumno GetAlumnoDGV()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
        }
        public Telefono GetTelefonoDGV()
        {
            return dataGridView2.SelectedRows[0].DataBoundItem as Telefono;
        }

        private void Btn_modificar_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                handler.ModificarAlumno(new Alumno(
                                legajo: Convert.ToStringValue(txt_legajo_alumno),
                                nombre: Convert.ToStringValue(txt_nombre_alumno),
                                apellido: Convert.ToStringValue(txt_apellido_alumno)
                            ));
                Mostrar(dataGridView1, handler.GetAlumnos());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void Btn_baja_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                handler.BajaTelefono(GetTelefonoDGV());
                Mostrar(dataGridView2, handler.GetTelefonos(GetAlumnoDGV()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Alumno alta = new Alumno($"A-{i * 5}", $"{i}", $"{i}");
                handler.AltaAlumno(alta);
            }
            Mostrar(dataGridView1, handler.GetAlumnos());
            for (int i = 0; i < 5; i++)
            {
                Telefono telefono = new Telefono($"{i * 11}", i);
                handler.AltaTelefonos(GetAlumnoDGV(),telefono);
            }
            Mostrar(dataGridView2, handler.GetTelefonos(GetAlumnoDGV()));
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (handler.GetAlumnos().Count > 0)
            {
                Mostrar(dataGridView2, handler.GetTelefonos(GetAlumnoDGV()));
            }
            else
            {
                dataGridView2.Rows.Clear();
            }
        }

        private void Btn_modificar_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                handler.ModificarTelefono(new Telefono(
                                numero: Convert.ToStringValue(txt_numero_telefono),
                                codigo: Convert.ToIntValue(txt_codigo_telefono)
                            ));
                Mostrar(dataGridView2, handler.GetTelefonos(GetAlumnoDGV()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
