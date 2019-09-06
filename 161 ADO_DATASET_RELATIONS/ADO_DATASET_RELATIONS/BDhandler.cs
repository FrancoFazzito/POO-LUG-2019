using System.Collections.Generic;
using System.Data;
using System.IO;

namespace ADO_DATASET_RELATIONS
{
    public class BDhandler
    {
        #region dataset
        //dataset
        private DataSet dataset;
        #endregion

        #region Tabla Alumno
        //tabla alumno
        private DataTable dataTableAlumnos;
        private const string TABLA_ALUMNOS = "Alumnos";
        private const string COLUMNA_LEGAJO = "Legajo";
        private const string COLUMNA_NOMBRE = "Nombre";
        private const string COLUMNA_APELLIDO = "Apellido";
        #endregion

        #region Tabla Telefono
        //tabla telefonos 
        private DataTable dataTableTelefonos;
        private const string TABLA_TELEFONOS = "Telefonos";
        private const string COLUMNA_LEGAJO_RELATION = "Legajo_Alumno";
        private const string COLUMNA_CODIGO_TELEFONO = "Codigo";
        private const string COLUMNA_NUMERO = "Numero";
        #endregion

        #region Archivo
        //archivos XML
        private const string XML_FILE = "DatosTabla.XML";
        #endregion

        #region relations
        //relation
        private const string RELATION_ALUMNO_TEL = "Alumno_Telefono";
        #endregion

        #region props
        //props
        private bool ExisteXML { get { return File.Exists(XML_FILE); } }
        #endregion

        #region ctor
        public BDhandler()
        {
            dataset = new DataSet();
            if (!ExisteXML)
            {
                CrearDataTableAlumno();
                CrearDataTableTelefono();
                CrearRelationAlumnoTelefono();
                dataset.WriteXml(XML_FILE, XmlWriteMode.WriteSchema);
            }
            else
            {
                dataset.ReadXml(XML_FILE, XmlReadMode.ReadSchema);
            }
        }
        #endregion

        private void CrearDataTableAlumno()
        {
            dataTableAlumnos = new DataTable(TABLA_ALUMNOS);

            DataColumn columnaLegajo = new DataColumn(COLUMNA_LEGAJO, typeof(string));
            DataColumn columnaNombre = new DataColumn(COLUMNA_NOMBRE, typeof(string));
            DataColumn columnaApellido = new DataColumn(COLUMNA_APELLIDO, typeof(string));

            dataTableAlumnos.Columns.Add(columnaLegajo);
            dataTableAlumnos.Columns.Add(columnaNombre);
            dataTableAlumnos.Columns.Add(columnaApellido);

            dataTableAlumnos.PrimaryKey = new DataColumn[] { columnaLegajo };

            this.dataset.Tables.Add(this.dataTableAlumnos);
        }

        private void CrearDataTableTelefono()

        {
            dataTableTelefonos = new DataTable(TABLA_TELEFONOS);

            DataColumn columnaLegajo = new DataColumn(COLUMNA_LEGAJO_RELATION, typeof(string));
            DataColumn columnaNumero = new DataColumn(COLUMNA_NUMERO, typeof(string));
            DataColumn columnaCodigo = new DataColumn(COLUMNA_CODIGO_TELEFONO, typeof(int));

            dataTableTelefonos.Columns.Add(columnaCodigo);
            dataTableTelefonos.Columns.Add(columnaLegajo);
            dataTableTelefonos.Columns.Add(columnaNumero);


            dataTableTelefonos.PrimaryKey = new DataColumn[] { columnaCodigo };

            this.dataset.Tables.Add(this.dataTableTelefonos);
        }

        private void CrearRelationAlumnoTelefono()
        {
            DataColumn PKalumno = dataset.Tables[TABLA_ALUMNOS].Columns[COLUMNA_LEGAJO];
            DataColumn FKteleno = dataset.Tables[TABLA_TELEFONOS].Columns[COLUMNA_LEGAJO_RELATION];
            DataRelation DR_Alumno_Telefono = new DataRelation(RELATION_ALUMNO_TEL, PKalumno, FKteleno);
            dataset.Relations.Add(DR_Alumno_Telefono);
        }

        private void GuardarXML()
        {
            this.dataset.WriteXml(XML_FILE,XmlWriteMode.WriteSchema);
        }

        private DataRow FindRowAlumno(Alumno alumno)
        {
            return dataset.Tables[TABLA_ALUMNOS].Rows.Find(alumno.Legajo);
        }

        private DataRowCollection GetDataRowsAlumnos()
        {
            return this.dataset.Tables[TABLA_ALUMNOS].Rows;
        }

        public void AltaAlumno(Alumno alumno)
        {
            DataRow find = dataset.Tables[TABLA_ALUMNOS].Rows.Find(alumno.Legajo);
            if (find == null)
            {
                DataRow dataRowAlta = dataset.Tables[TABLA_ALUMNOS].NewRow();
                dataRowAlta.ItemArray = alumno.GetDatosArray();
                dataset.Tables[TABLA_ALUMNOS].Rows.Add(dataRowAlta);
                GuardarXML();
            }
        }

        public void BajaAlumno(Alumno alumno)
        {
            DataRow dataRowBaja = FindRowAlumno(alumno);
            this.dataset.Tables[TABLA_ALUMNOS].Rows.Remove(dataRowBaja);
            GuardarXML();
        }

        public void ModificarAlumno(Alumno alumno)
        {
            DataRow dataRowModificar = FindRowAlumno(alumno);
            dataRowModificar.ItemArray = alumno.GetDatosArray();
            GuardarXML();
        }

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            foreach (DataRow datarow in GetDataRowsAlumnos())
            {
                string legajo = datarow.ItemArray[0].ToString();
                string nombre = datarow.ItemArray[1].ToString();
                string apellido = datarow.ItemArray[2].ToString();
                alumnos.Add(new Alumno(legajo, nombre, apellido));
            }
            return alumnos;
        }

        public void AltaTelefonos(Alumno alumno, Telefono telefono)
        {
            DataRow find = dataset.Tables[TABLA_TELEFONOS].Rows.Find(telefono.Codigo);
            if (find == null)
            {
                DataRow dataTelefono = dataset.Tables[TABLA_TELEFONOS].NewRow();
                dataTelefono[0] = telefono.Codigo;
                dataTelefono[1] = alumno.Legajo;
                dataTelefono[2] = telefono.Numero;
                dataset.Tables[TABLA_TELEFONOS].Rows.Add(dataTelefono);
                GuardarXML();
            }
        }

        public void ModificarTelefono(Telefono telefono)
        {
            DataRow dataTelefono = GetDataTelefono(telefono);
            dataTelefono[2] = telefono.Numero;
            GuardarXML();
        }

        private DataRow GetDataTelefono(Telefono telefono)
        {
            return dataset.Tables[TABLA_TELEFONOS].Rows.Find(telefono.Codigo);
        }

        public void BajaTelefono(Telefono telefono)
        {
            DataRow dataTelefono = GetDataTelefono(telefono);
            this.dataset.Tables[TABLA_TELEFONOS].Rows.Remove(dataTelefono);
            GuardarXML();
        }

        public List<Telefono> GetTelefonos(Alumno alumno)
        {
            List<Telefono> telefonos = new List<Telefono>();
            foreach (DataRow dataRowTelefono in GetDataRowsTelefono(alumno))
            {
                int codigo = int.Parse(dataRowTelefono.ItemArray[0].ToString());
                string numero = dataRowTelefono.ItemArray[2].ToString();
                telefonos.Add(new Telefono(numero, codigo));
            }
            return telefonos;
        }

        private DataRow[] GetDataRowsTelefono(Alumno alumno)
        {
            DataRow[] datarow = dataset.Tables[TABLA_ALUMNOS].Rows.Find(alumno.Legajo).GetChildRows(RELATION_ALUMNO_TEL);
            return datarow;
        }
    }
}
