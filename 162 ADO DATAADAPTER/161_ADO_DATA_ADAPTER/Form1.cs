using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _161_ADO_DATA_ADAPTER
{
    public partial class Form1 : Form
    {
        BDhandler handler;
        public Form1()
        {
            InitializeComponent();
            handler = new BDhandler();
            MostrarDGValumnos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDGVTelefonos();
        }

        #region ABM Alumno events
        private void Btn_alta_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                handler.AltaAlumno(new Alumno(
                                legajo: Convert.ToStringValue(txt_legajo_alumno),
                                nombre: Convert.ToStringValue(txt_nombre_alumno),
                                apellido: Convert.ToStringValue(txt_apellido_alumno)
                            ));
                MostrarDGValumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_baja_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                handler.BajaAlumno(GetAlumnoDGV());
                MostrarDGValumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                MostrarDGValumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region ABM Telefono events
        private void Btn_alta_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                handler.AltaTelefono(GetAlumnoDGV(), new Telefono(
                                numero: Convert.ToStringValue(txt_numero_telefono)
                            ));
                MostrarDGVTelefonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_baja_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                handler.BajaTelefono(GetTelefonoDGV());
                MostrarDGVTelefonos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_modificar_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                handler.ModificarTelefono(
                    new Telefono(GetTelefonoDGV().Numero),
                    numero: Convert.ToStringValue(txt_numero_telefono));

                Mostrar(dataGridView2, handler.GetTelefonos(GetAlumnoDGV()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarDGVTelefonos()
        {
            Mostrar(dataGridView2, handler.GetTelefonos(GetAlumnoDGV()));
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Telefono> listaTelefonos = handler.GetTelefonos(GetAlumnoDGV());
            if (listaTelefonos.Count > 0)
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = listaTelefonos;
            }
            else
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }
        #endregion

        #region Mostrar
        private void MostrarDGValumnos()
        {
            Mostrar(dataGridView1, handler.GetListAlumnos());
        }

        public void Mostrar(DataGridView DGV, IEnumerable<object> data)
        {
            DGV.DataSource = null;
            DGV.DataSource = data;
        }
        #endregion

        #region Get DGV
        private Alumno GetAlumnoDGV()
        {
            return dataGridView1.SelectedRows[0].DataBoundItem as Alumno;
        }
        private Telefono GetTelefonoDGV()
        {
            return dataGridView2.SelectedRows[0].DataBoundItem as Telefono;
        }




        #endregion


    }
}
