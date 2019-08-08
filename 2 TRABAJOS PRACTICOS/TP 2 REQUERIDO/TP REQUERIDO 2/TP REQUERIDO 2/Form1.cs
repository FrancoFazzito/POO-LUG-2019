using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_REQUERIDO_2
{
    public partial class Form1 : Form
    {
        private Universidad universidad;
        public Form1()
        {
            universidad = new Universidad();
            universidad.eventoPromedio += CapturarEvento;
            InitializeComponent();
        }
        private void CapturarEvento(object mensaje, EventArgs eventArgs)
        {
            MessageBox.Show("evento Promedio:  " + mensaje.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            universidad.AddAlumno(  legajo: convert.ConvertToInt(LEGAJO), 
                                    nombre: convert.ConvertToString(NOMBRE), 
                                    apellido: convert.ConvertToString(APELLIDO));
            mostrar();
        }

        private void mostrar()
        {
            dataGridViewAlumnos.Rows.Clear();
            foreach (Alumno item in universidad.GetAlumnos())
            {
                dataGridViewAlumnos.Rows.Add(item.Nombre, item.Apellido, item.Legajo);
            }

        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            universidad.modificarAlumno(legajoModificar:convert.ConvertToInt(LEGAJO),
                                        nuevoCodigo:convert.ConvertToInt(NEWLEGAJO), 
                                        nuevoNombre:convert.ConvertToString(NOMBRE), 
                                        nuevoApellido:convert.ConvertToString(APELLIDO));
            mostrar();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            universidad.DeleteAlumno(legajoEliminar: convert.ConvertToInt(LEGAJO));
            mostrar();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            universidad.addMateriaBasica(convert.ConvertToInt(LEGAJOMATERIA), 
                                        convert.ConvertToInt(CODIGOMATERIA), 
                                        convert.ConvertToString(DENOMINACIONMATERIA));
            mostrar();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            universidad.addMateriaEspecial(convert.ConvertToInt(LEGAJOMATERIA),
                                        convert.ConvertToInt(CODIGOMATERIA),
                                        convert.ConvertToString(DENOMINACIONMATERIA));
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            universidad.modificarMateriaGlobal(convert.ConvertToInt(CODIGOMATERIA), convert.ConvertToInt(NUEVOCODIGOMATERIA), convert.ConvertToString(DENOMINACIONMATERIA));
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            universidad.DeleteMateria(convert.ConvertToInt(LEGAJOMATERIA),
                                        convert.ConvertToInt(CODIGOMATERIA));
        }

        private void mostrarNotas()
        {

            int rowindex = dataGridViewAlumnos.CurrentCell.RowIndex;
            Alumno buscadoIndex = universidad.GetAlumnos()[rowindex];
            int legajoIndex = buscadoIndex.Legajo;

            
            dataGridViewAprobadas.Rows.Clear();
            List<Materia> materiasAprobados = universidad.getMateriasAprobadas(legajoIndex);
            if (materiasAprobados.Count > 0)
            {
                foreach (Materia item in materiasAprobados)
                {
                    dataGridViewAprobadas.Rows.Add(item.Codigo, item.Denominacion, item.Nota);
                }
            }

            dataGridViewCursando.Rows.Clear();
            List<Materia> materiasCursando = universidad.getMateriasCursando(legajoIndex);
            if (materiasCursando.Count > 0)
            {
                foreach (Materia item in materiasCursando)
                {
                    dataGridViewCursando.Rows.Add(item.Codigo, item.Denominacion, "CURSANDO");
                }
            }

            dataGridViewDesaprobados.Rows.Clear();
            List<Materia> materiasDesaprobadas = universidad.getMateriasDesaprobadas(legajoIndex);
            if(materiasDesaprobadas.Count > 0)
            {
                foreach (Materia item in materiasDesaprobadas)
                {
                    dataGridViewDesaprobados.Rows.Add(item.Codigo, item.Denominacion, item.Nota);
                }
            }
            try
            {
                PROMEDIOGENERAL.Text = universidad.calcularPromedioGeneral(legajoIndex).ToString();
                PROMEDIOAPROBADO.Text = universidad.calcularPromedioAprobadas(legajoIndex).ToString();
            }
            catch
            {
                MessageBox.Show("el alumno no tiene materias con notas asignadas");
            }

        }
        private void DataGridViewAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarNotas();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            universidad.asignarNota(convert.ConvertToInt(LEGAJONOTA), convert.ConvertToInt(CODIGONOTA), convert.ConvertToInt(NOTA));
            mostrarNotas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            universidad.sortAsc();
            mostrar();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            universidad.sortDes();
            mostrar();
        }
        
    }

    static class convert
    {
        public static int ConvertToInt(TextBox text)
        {
            int value = 0;
            try
            {
                value = int.Parse(text.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en el textbox " + text.Name);
            }
            return value;
        }
        public static string ConvertToString(TextBox text)
        {
            string value = "";
            try
            {
                value = text.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " en el textbox " + text.Name);
            }
            return value;
        }
    }
}
