using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace _161_ADO_DATA_ADAPTER
{
    class BDhandler
    {
        private DataSet dataSetBD;

        private DataTable dataTableAlumnos;
        private DataTable dataTableTelefonos;

        private SqlConnection conexionBD;
        private SqlCommand selectCommandBD;
        private SqlDataAdapter adapter;

        public bool ExisteXML
        {
            get { return File.Exists(Constantes.File.XML); }
        }

        public BDhandler()
        {
            dataSetBD = new DataSet();
            if (!ExisteXML)
            {
                CrearDataTableAlumno();
                CrearDataTableTelefonos();
                CrearRelationAlumnoTelefono();
                ActualizarDatos();
            }
            else
            {
                LeerXML();
            }

            CrearDataAdapter();
        }

        private void CrearDataAdapter()
        {
            conexionBD = new SqlConnection(Constantes.Connection.CONNECTION_STRING);

            selectCommandBD = new SqlCommand(Constantes.Connection.SELECT_FROM);
            selectCommandBD.Connection = conexionBD;

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = selectCommandBD;

            conexionBD.Open();
            adapter.Fill(dataSetBD);
            conexionBD.Close();
        }

        #region XML metodos
        private void LeerXML()
        {
            dataSetBD.ReadXml(Constantes.File.XML, XmlReadMode.ReadSchema);
        }
        private void ActualizarDatos()
        {
            dataSetBD.WriteXml(Constantes.File.XML, XmlWriteMode.WriteSchema);

            selectCommandBD.Connection = conexionBD;
            adapter.SelectCommand = selectCommandBD;

            conexionBD.Open();
            adapter.Update(dataSetBD);
            conexionBD.Close();
        }
        #endregion

        #region CrearDataTable y relations
        private void CrearDataTableAlumno()
        {
            dataTableAlumnos = new DataTable(Constantes.Alumno.TABLA);

            DataColumn columnaLegajo = new DataColumn(Constantes.Alumno.LEGAJO);
            DataColumn columnaNombre = new DataColumn(Constantes.Alumno.NOMBRE);
            DataColumn columnaApellido = new DataColumn(Constantes.Alumno.APELLIDO);

            dataTableAlumnos.Columns.Add(columnaLegajo);
            dataTableAlumnos.Columns.Add(columnaNombre);
            dataTableAlumnos.Columns.Add(columnaApellido);

            dataTableAlumnos.PrimaryKey = new DataColumn[] { columnaLegajo };

            this.dataSetBD.Tables.Add(dataTableAlumnos);
        }

        internal IEnumerable<Telefono> GetTelefonos()
        {
            throw new NotImplementedException();
        }

        private void CrearDataTableTelefonos()
        {
            dataTableTelefonos = new DataTable(Constantes.Telefono.TABLA);

            DataColumn columnaNumero = new DataColumn(Constantes.Telefono.NUMERO);
            DataColumn columnaLegajo = new DataColumn(Constantes.Telefono.LEGAJO_RELACION);

            dataTableTelefonos.Columns.Add(columnaNumero);
            dataTableTelefonos.Columns.Add(columnaLegajo);

            dataTableTelefonos.PrimaryKey = new DataColumn[] { columnaNumero };

            this.dataSetBD.Tables.Add(dataTableTelefonos);
        }

        private void CrearRelationAlumnoTelefono()
        {
            DataColumn PKalumno = dataSetBD.Tables[Constantes.Alumno.TABLA].Columns[Constantes.Alumno.LEGAJO];
            DataColumn FKtelefono = dataSetBD.Tables[Constantes.Telefono.TABLA].Columns[Constantes.Telefono.LEGAJO_RELACION];

            DataRelation dataRelation_alumno_telefono = new DataRelation(Constantes.Relation.RELATION_ALUMNO_TEL, PKalumno, FKtelefono);

            dataSetBD.Relations.Add(dataRelation_alumno_telefono);
        }
        #endregion

        #region Alumno ABM

        public void AltaAlumno(Alumno alumno)
        {
            if (NoExisteID(alumno))
            {
                DataRow dataRowAlta = dataSetBD.Tables[Constantes.Alumno.TABLA].NewRow();

                dataRowAlta[Constantes.Alumno.LEGAJO] = alumno.Legajo;
                dataRowAlta[Constantes.Alumno.NOMBRE] = alumno.Nombre;
                dataRowAlta[Constantes.Alumno.APELLIDO] = alumno.Apellido;

                dataSetBD.Tables[Constantes.Alumno.TABLA].Rows.Add(dataRowAlta);
                ActualizarDatos();
            }
            else
            {
                throw new Exception($"el alumno con legajo {alumno.Legajo} ya existe");
            }
        }

        public void BajaAlumno(Alumno alumno)
        {
            DataRow dataRowBaja = getRowAlumno(alumno);
            dataSetBD.Tables[Constantes.Alumno.TABLA].Rows.Remove(dataRowBaja);
            ActualizarDatos();
        }

        public void ModificarAlumno(Alumno alumno)
        {
            DataRow dataRowModificar = getRowAlumno(alumno);

            dataRowModificar[Constantes.Alumno.NOMBRE] = alumno.Nombre;
            dataRowModificar[Constantes.Alumno.APELLIDO] = alumno.Apellido;

            ActualizarDatos();
        }

        public List<Alumno> GetListAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            foreach (DataRow dataRow in GetRowsAlumno())
            {
                string legajo = dataRow[Constantes.Alumno.LEGAJO].ToString();
                string nombre = dataRow[Constantes.Alumno.NOMBRE].ToString();
                string apellido = dataRow[Constantes.Alumno.APELLIDO].ToString();
                Alumno alumnoAlta = new Alumno(legajo, nombre, apellido);
                alumnos.Add(alumnoAlta);
            }
            return alumnos;
        }

        private bool NoExisteID(Alumno alumno)
        {
            return dataSetBD.Tables[Constantes.Alumno.TABLA].Rows.Find(alumno.Legajo) == null;
        }

        private DataRow getRowAlumno(Alumno alumno)
        {
            return dataSetBD.Tables[Constantes.Alumno.TABLA].Rows.Find(alumno.Legajo);
        }

        private DataRow[] GetRowsAlumno()
        {
            return dataSetBD.Tables[Constantes.Alumno.TABLA].Select();
        }
        #endregion

        #region Telefono ABM
        public void AltaTelefono(Alumno alumno, Telefono telefono)
        {
            if (NoExisteLegajo(telefono))
            {
                DataRow dataRowAlta = dataSetBD.Tables[Constantes.Telefono.TABLA].NewRow();

                dataRowAlta[Constantes.Telefono.NUMERO] = telefono.Numero;
                dataRowAlta[Constantes.Telefono.LEGAJO_RELACION] = alumno.Legajo;

                dataSetBD.Tables[Constantes.Telefono.TABLA].Rows.Add(dataRowAlta);
                ActualizarDatos();
            }
            else
            {
                throw new Exception($"el telefono con numero {telefono.Numero} ya existe");
            }
        }

        public void ModificarTelefono(Telefono telefono,string numero)
        {
            DataRow dataTelefono = GetRowTelefono(telefono);

            if (NoExisteLegajo(numero))
            {
                dataTelefono[Constantes.Telefono.NUMERO] = numero;
                ActualizarDatos();
            }
            else
            {
                throw new Exception($"el telefono con numero {numero} ya existe");
            }
        }

        public void BajaTelefono(Telefono telefono)
        {
            DataRow dataTelefono = GetRowTelefono(telefono);
            dataSetBD.Tables[Constantes.Telefono.TABLA].Rows.Remove(dataTelefono);
            ActualizarDatos();
        }

        public List<Telefono> GetTelefonos(Alumno alumno)
        {
            List<Telefono> telefonos = new List<Telefono>();
            foreach (DataRow datarow in GetDataRowsTelefono(alumno))
            {
                string numero = datarow[Constantes.Telefono.NUMERO].ToString();
                Telefono telefono = new Telefono(numero);
                telefonos.Add(telefono);
            }
            return telefonos;
        }

        private bool NoExisteLegajo(Telefono telefono)
        {
            return dataSetBD.Tables[Constantes.Telefono.TABLA].Rows.Find(telefono.Numero) == null;
        }
        private bool NoExisteLegajo(string numero)
        {
            return dataSetBD.Tables[Constantes.Telefono.TABLA].Rows.Find(numero) == null;
        }
        private DataRow GetRowTelefono(Telefono telefono)
        {
            return dataSetBD.Tables[Constantes.Telefono.TABLA].Rows.Find(telefono.Numero);
        }

        private DataRow[] GetDataRowsTelefono(Alumno alumno)
        {
            DataRowCollection rows = dataSetBD.Tables[Constantes.Alumno.TABLA].Rows;
            DataRow[] rowsarray = rows.Find(alumno.Legajo).GetChildRows(Constantes.Relation.RELATION_ALUMNO_TEL);
            return rowsarray;
        }
        #endregion
    }
}
