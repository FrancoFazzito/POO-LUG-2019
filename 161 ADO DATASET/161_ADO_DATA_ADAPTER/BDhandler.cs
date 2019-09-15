using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace _161_ADO_DATA_ADAPTER
{
    class BDhandler
    {
        private DataSet dataSet;
        private DataTable dataTableAlumnos;
        private DataTable dataTableTelefonos;

        public bool ExisteXML
        {
            get { return File.Exists(Constantes.File.XML); }
        }

        public BDhandler()
        {
            dataSet = new DataSet();
            if (!ExisteXML)
            {
                CrearDataTableAlumno();
                CrearDataTableTelefonos();
                CrearRelationAlumnoTelefono();
                EscribirXML();
            }
            else
            {
                LeerXML();
            }
        }

        #region XML metodos
        private void LeerXML()
        {
            dataSet.ReadXml(Constantes.File.XML, XmlReadMode.ReadSchema);
        }
        private void EscribirXML()
        {
            dataSet.WriteXml(Constantes.File.XML, XmlWriteMode.WriteSchema);
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

            this.dataSet.Tables.Add(dataTableAlumnos);
        }

        private void CrearDataTableTelefonos()
        {
            dataTableTelefonos = new DataTable(Constantes.Telefono.TABLA);

            DataColumn columnaNumero = new DataColumn(Constantes.Telefono.NUMERO);
            DataColumn columnaLegajo = new DataColumn(Constantes.Telefono.LEGAJO_RELACION);

            dataTableTelefonos.Columns.Add(columnaNumero);
            dataTableTelefonos.Columns.Add(columnaLegajo);

            dataTableTelefonos.PrimaryKey = new DataColumn[] { columnaNumero };

            this.dataSet.Tables.Add(dataTableTelefonos);
        }

        private void CrearRelationAlumnoTelefono()
        {
            DataColumn PKalumno = dataSet.Tables[Constantes.Alumno.TABLA].Columns[Constantes.Alumno.LEGAJO];
            DataColumn FKtelefono = dataSet.Tables[Constantes.Telefono.TABLA].Columns[Constantes.Telefono.LEGAJO_RELACION];

            DataRelation dataRelation_alumno_telefono = new DataRelation(Constantes.Relation.RELATION_ALUMNO_TEL, PKalumno, FKtelefono);

            dataSet.Relations.Add(dataRelation_alumno_telefono);
        }
        #endregion

        #region Alumno ABM

        public void AltaAlumno(Alumno alumno)
        {
            if (NoExisteID(alumno))
            {
                DataRow dataRowAlta = dataSet.Tables[Constantes.Alumno.TABLA].NewRow();

                dataRowAlta[Constantes.Alumno.LEGAJO] = alumno.Legajo;
                dataRowAlta[Constantes.Alumno.NOMBRE] = alumno.Nombre;
                dataRowAlta[Constantes.Alumno.APELLIDO] = alumno.Apellido;

                dataSet.Tables[Constantes.Alumno.TABLA].Rows.Add(dataRowAlta);
                EscribirXML();
            }
            else
            {
                throw new Exception($"el alumno con legajo {alumno.Legajo} ya existe");
            }
        }

        public void BajaAlumno(Alumno alumno)
        {
            DataRow dataRowBaja = getRowAlumno(alumno);

            dataSet.Tables[Constantes.Alumno.TABLA].Rows.Remove(dataRowBaja);

            EscribirXML();
        }

        public void ModificarAlumno(Alumno alumno)
        {
            DataRow dataRowModificar = getRowAlumno(alumno);

            dataRowModificar[Constantes.Alumno.NOMBRE] = alumno.Nombre;
            dataRowModificar[Constantes.Alumno.APELLIDO] = alumno.Apellido;

            EscribirXML();
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
            return dataSet.Tables[Constantes.Alumno.TABLA].Rows.Find(alumno.Legajo) == null;
        }

        private DataRow getRowAlumno(Alumno alumno)
        {
            
            return dataSet.Tables[Constantes.Alumno.TABLA].Rows.Find(alumno.Legajo);
        }

        private DataRow[] GetRowsAlumno()
        {
            return dataSet.Tables[Constantes.Alumno.TABLA].Select();
        }
        #endregion

        #region Telefono ABM
        public void AltaTelefono(Alumno alumno, Telefono telefono)
        {
            if (NoExisteLegajo(telefono))
            {
                DataRow dataRowAlta = dataSet.Tables[Constantes.Telefono.TABLA].NewRow();

                dataRowAlta[Constantes.Telefono.NUMERO] = telefono.Numero;
                dataRowAlta[Constantes.Telefono.LEGAJO_RELACION] = alumno.Legajo;

                dataSet.Tables[Constantes.Telefono.TABLA].Rows.Add(dataRowAlta);
                EscribirXML();
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
            }
            EscribirXML();
        }

        public void BajaTelefono(Telefono telefono)
        {
            DataRow dataTelefono = GetRowTelefono(telefono);
            dataSet.Tables[Constantes.Telefono.TABLA].Rows.Remove(dataTelefono);
            EscribirXML();
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
            return dataSet.Tables[Constantes.Telefono.TABLA].Rows.Find(telefono.Numero) == null;
        }
        private bool NoExisteLegajo(string numero)
        {
            return dataSet.Tables[Constantes.Telefono.TABLA].Rows.Find(numero) == null;
        }
        private DataRow GetRowTelefono(Telefono telefono)
        {
            return dataSet.Tables[Constantes.Telefono.TABLA].Rows.Find(telefono.Numero);
        }

        private DataRow[] GetDataRowsTelefono(Alumno alumno)
        {
            return dataSet.Tables[Constantes.Alumno.TABLA].Rows.Find(alumno.Legajo).GetChildRows(Constantes.Relation.RELATION_ALUMNO_TEL);
        }
        #endregion
    }
}
