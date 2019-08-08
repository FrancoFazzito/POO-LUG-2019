using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_1_S
{
    #region FORM
    public partial class Form1 : Form
    {
        private AlumnoLista alumnoList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alumnoList = new AlumnoLista();
            AddColumnsDataGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno alumnoAañadir = new Alumno(Convert.ConvertToInt(textBoxlegajo),
                                  Convert.ConvertToString(textBoxnombre),
                                  Convert.ConvertToString(textBoxapellido),
                                  Convert.ConvertToDateTime(textBoxfechanacimiento),
                                  Convert.ConvertToDateTime(textBoxfechaingreso),
                                  Convert.ConvertToInt(textBoxedad),
                                  Convert.ConvertToInt(textBoxmaterias),
                                  Convert.ConvertToBoolCheck(checkBoxactivo));
                if (alumnoAañadir.Legajo > 0)
                {
                    alumnoList.AñadirAlumno(alumnoAañadir);
                    mostrar();
                }
                else
                {
                    throw new ExceptionLegajoZero();
                }
            }
            catch (ExceptionLegajoZero ex)
            {
                MessageBox.Show(ex.mensaje);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public class ExceptionLegajoZero : Exception
        {
            public string mensaje
            {
                get
                {
                    return "el legajo no puede ser 0 o negativo";
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                alumnoList.EditarAlumno(Convert.ConvertToInt(textBoxlegajomodificar),

                        Convert.ConvertToInt(textboxModificarLegajo),
                        Convert.ConvertToString(textBoxModifcarNombre),
                        Convert.ConvertToString(textBoxModifcarApellido),
                        Convert.ConvertToBoolCheck(checkBoxModificarCheck),
                        Convert.ConvertToDateTime(textBoxModifcarFechaIngreso),
                        Convert.ConvertToDateTime(textBoxModifcarFechaNacimiento),
                        Convert.ConvertToInt(textBoxModificarCantidadMaterias));
                mostrar();
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
                alumnoList.EliminarAlumno(Convert.ConvertToInt(textBoxlegajoborrar));
                mostrar();
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
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                Alumno indexAeliminar = alumnoList.GetList()[rowIndex];
                alumnoList.EliminarAlumno(indexAeliminar.Legajo);
                mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cargarInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RadioButton1dias_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cargarInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadioButton2años_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cargarInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadioButton3meses_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cargarInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cargarInfo()
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            Alumno mostrar = alumnoList.GetList()[rowIndex];
            int? antiguedad = 0;
            if (radioButton1dias.Checked)
            {
                antiguedad = mostrar.Antiguedad("dias");
            }
            else if (radioButton3meses.Checked)
            {
                antiguedad = mostrar.Antiguedad("meses");
            }
            else
            {
                antiguedad = mostrar.Antiguedad("años");
            }
            textBoxantiguedad.Text = antiguedad.ToString();
            textBoxedadingreso.Text = mostrar.GetEdadIngreso().ToString();
            textBoxmateriasNoaproabadas.Text = mostrar.GetCantMateriasNoAprobadas().ToString();
        }
        private void AddColumnsDataGrid()
        {
            dataGridView1.Columns.Add("columnLegajo", "legajo");
            dataGridView1.Columns.Add("columnNombre", "nombre");
            dataGridView1.Columns.Add("columnApellido", "apellido");
            dataGridView1.Columns.Add("columnEdad", "edad");
            dataGridView1.Columns.Add("columnActivo", "activo");
        }
        private void mostrar()
        {
            dataGridView1.Rows.Clear();
            foreach (Alumno item in alumnoList.GetList())
            {
                dataGridView1.Rows.Add(item.Legajo, item.Nombre, item.Apellido, item.Edad, item.Activo);
            }

        }

    }
    #endregion

    #region CONVERT
    public class Convert
    {
        public static string ConvertToString(TextBox text)
        {
            string value = "";
            try
            {
                value = text.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + text.Name);
            }
            return value;
        }
        public static int ConvertToInt(TextBox text)
        {
            int value = 0;
            try
            {
                value = int.Parse(text.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + text.Name);
            }
            return value;
        }
        public static DateTime ConvertToDateTime(TextBox text)
        {
            DateTime value = DateTime.Now;
            try
            {
                value = DateTime.Parse(text.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + text.Name);
            }
            return value;
        }
        public static bool ConvertToBoolCheck(CheckBox e)
        {
            if (e.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    #endregion

    #region ALUMNOLISTA
    public class AlumnoLista
    {
        private List<Alumno> alumnos;
        public AlumnoLista()
        {
            alumnos = new List<Alumno>();
        }

        public void AñadirAlumno(Alumno alumno)
        {
            if (alumno.GetFecha())
            {
                alumnos.Add(alumno);
            }
            else
            {
                MessageBox.Show("fecha invalida, debio nacer antes de la fecha de ingreso");
            }

        }
        public void EliminarAlumno(int legajo)
        {
            Alumno aRemover = alumnos.Find(alumno => alumno.Legajo == legajo);
            alumnos.Remove(aRemover);
        }

        public void EditarAlumno(int legajoBusqueda, int legajo, string nombre, string apellido, bool activo, DateTime fechaIngreso, DateTime fechaNacimiento, int materiasAprobadas)
        {
            foreach (Alumno buscado in alumnos)
            {
                if (legajoBusqueda == buscado.Legajo)
                {
                    buscado.Legajo = legajo;
                    buscado.Nombre = nombre;
                    buscado.Apellido = apellido;
                    buscado.Activo = activo;
                    buscado.FechaIngreso = fechaIngreso;
                    buscado.FechaNacimiento = fechaNacimiento;
                    buscado.CantidadMateriasAprobadas = materiasAprobadas;
                }
            }
        }
        public List<Alumno> GetList()
        {
            return this.alumnos;
        }
    }
    #endregion

    #region ALUMNO
    public class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private int edad;
        private bool activo;
        private int cantidadMateriasAprobadas;

        public Alumno()
        {

        }

        public Alumno(int legajo, string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso, int edad, int cantidadMateriasAprobadas, bool activo)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaIngreso = fechaIngreso;
            this.edad = edad;
            this.activo = activo;
            this.cantidadMateriasAprobadas = cantidadMateriasAprobadas;
        }

        //  L/E
        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public bool Activo { get => activo; set => activo = value; }

        // E
        public DateTime FechaNacimiento { set => fechaNacimiento = value; }
        public DateTime FechaIngreso { set => fechaIngreso = value; }
        public int CantidadMateriasAprobadas { set => cantidadMateriasAprobadas = value; }

        // L
        public int Edad { get => edad; }

        ~Alumno()
        {
            MessageBox.Show(string.Format("se finalizo a nombre {0} apellido {1} con legajo {2} ", this.Nombre, this.Apellido, this.Legajo));
        }
        public bool GetFecha()
        {
            if (this.fechaNacimiento < this.fechaIngreso)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetCantMateriasNoAprobadas()
        {
            int cantidadMaterias = 36;
            return cantidadMaterias - cantidadMateriasAprobadas;
        }
        public int GetEdadIngreso()
        {
            int years = (this.fechaIngreso - this.fechaNacimiento).Days / 365;
            return years;
        }
        public int? Antiguedad(string tipoRetorno)
        {
            int days = (DateTime.Now - this.fechaIngreso).Days;
            int month = 30;
            int years = 365;

            if (tipoRetorno == "dias")
            {
                return days;

            }
            else if (tipoRetorno == "meses")
            {
                return days / month;
            }
            else if (tipoRetorno == "años")
            {
                return days / years;
            }
            else
            {
                return null;
            }
        }

    }
    #endregion

}
