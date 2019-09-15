using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _162_ADO_DATA_ADAPTER
{
    class BDhandler
    {
        //constantes.cs contiene las constantes que se usan en este clase 
        private DataSet dataset;
        private SqlConnection sqlConnection;
        private DataRelation relation;

        public event EventHandler ActualizacionBD;

        #region dataAlumno
        private DataTable dataTableAlumno;
        private SqlDataAdapter dataAdapterAlumno;
        private SqlCommandBuilder commandBuilderAlumno;
        private DataView dataViewAlumno;
        #endregion

        #region dataTelefono
        private DataTable dataTableTelefono;
        private SqlDataAdapter dataAdapterTelefono;
        private SqlCommandBuilder commandBuilderTelefono;
        private DataView dataViewTelefono;
        #endregion


        public BDhandler()
        {
            this.dataset = new DataSet();
            this.sqlConnection = new SqlConnection(Constantes.CONEXION);
            //setean las dataadapter y tables de los objetos
            CrearDataAlumno();
            CrearDataTelefono();
            SetPKtablas();
            CrearRelation();
        }

        private void CrearDataAlumno()
        {
            this.dataTableAlumno = new DataTable(Constantes.ALUMNO_TABLA);

            this.dataAdapterAlumno = new SqlDataAdapter(Constantes.ALUMNO_FROM, this.sqlConnection);

            this.commandBuilderAlumno = new SqlCommandBuilder(dataAdapterAlumno);
            this.dataAdapterAlumno.InsertCommand = commandBuilderAlumno.GetInsertCommand();
            this.dataAdapterAlumno.UpdateCommand = commandBuilderAlumno.GetUpdateCommand();
            this.dataAdapterAlumno.DeleteCommand = commandBuilderAlumno.GetDeleteCommand();

            this.dataset.Tables.Add(this.dataTableAlumno);

            this.dataAdapterAlumno.Fill(dataset, Constantes.ALUMNO_TABLA); //uso del nombre del datatable para el nombre del mapping
        }

        private void CrearDataTelefono()
        {
            this.dataTableTelefono = new DataTable(Constantes.TELEFONO_TABLA);

            this.dataAdapterTelefono = new SqlDataAdapter(Constantes.TELEFONO_FROM, this.sqlConnection);

            this.commandBuilderTelefono = new SqlCommandBuilder(dataAdapterTelefono);
            this.dataAdapterTelefono.InsertCommand = commandBuilderTelefono.GetInsertCommand();
            this.dataAdapterTelefono.UpdateCommand = commandBuilderTelefono.GetUpdateCommand();
            this.dataAdapterTelefono.DeleteCommand = commandBuilderTelefono.GetDeleteCommand();

            this.dataset.Tables.Add(this.dataTableTelefono);

            this.dataAdapterTelefono.Fill(this.dataset, Constantes.TELEFONO_TABLA); //uso del nombre del datatable para el nombre del mapping
        }

        private void CrearRelation()
        {
            DataColumn PKAlumno = this.dataTableAlumno.Columns[Constantes.ALUMNO_ID];
            DataColumn FKtelefono = this.dataTableTelefono.Columns[Constantes.TELEFONO_ALUMNO_ID];
            this.relation = new DataRelation(Constantes.RELATION_ALUMNO_TELEFONO, PKAlumno, FKtelefono);
            this.dataset.Relations.Add(relation);
        }

        private void SetPKtablas()
        {
            this.dataTableAlumno.PrimaryKey = new DataColumn[] { this.dataTableAlumno.Columns[Constantes.ALUMNO_ID] };
            this.dataTableTelefono.PrimaryKey = new DataColumn[] { this.dataTableTelefono.Columns[Constantes.TELEFONO_ID] };
        }

        public void AltaAlumno(Alumno alumno)
        {
            DataRow row = this.dataTableAlumno.NewRow();

            row[Constantes.ALUMNO_ID] = alumno.Id;
            row[Constantes.ALUMNO_NOMBRE] = alumno.Nombre;
            row[Constantes.ALUMNO_APELLIDO] = alumno.Apellido;

            this.dataTableAlumno.Rows.Add(row);

            this.ActualizacionBD?.Invoke(alumno, null);
        }

        public void ModificarAlumno(Alumno alumno)
        {
            DataRow row = this.dataTableAlumno.Rows.Find(alumno.Id);

            row[Constantes.ALUMNO_NOMBRE] = alumno.Nombre;
            row[Constantes.ALUMNO_APELLIDO] = alumno.Apellido;

            this.ActualizacionBD?.Invoke(alumno, null);
        }

        public void BajaAlumno(Alumno alumno)
        {
            this.dataTableAlumno.Rows.Find(alumno.Id).Delete();

            this.ActualizacionBD?.Invoke(alumno, null);
        }

        public void AltaTelefono(Telefono telefono, Alumno alumno)
        {
            DataRow row = dataTableTelefono.NewRow();

            row[Constantes.TELEFONO_ID] = telefono.Id;
            row[Constantes.TELEFONO_NUMERO] = telefono.Numero;
            row[Constantes.TELEFONO_ALUMNO_ID] = alumno.Id;

            this.dataTableTelefono.Rows.Add(row);

            this.ActualizacionBD?.Invoke(telefono, null);
        }

        public void ModificarTelefono(Telefono telefono)
        {
            DataRow row = this.dataTableTelefono.Rows.Find(telefono.Id);

            row[Constantes.TELEFONO_NUMERO] = telefono.Numero;

            this.ActualizacionBD?.Invoke(telefono, null);
        }

        public void BajaTelefono(Telefono telefono)
        {
            this.dataTableTelefono.Rows.Find(telefono.Id).Delete();

            this.ActualizacionBD?.Invoke(telefono, null);
        }

        public List<Alumno> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            this.dataViewAlumno = new DataView(this.dataTableAlumno, "", "", DataViewRowState.CurrentRows);

            foreach (DataRowView Rowview in dataViewAlumno)
            {
                DataRow row = Rowview.Row;
                int id = int.Parse(row[Constantes.ALUMNO_ID].ToString());
                string nombre = row[Constantes.ALUMNO_NOMBRE].ToString();
                string apellido = row[Constantes.ALUMNO_APELLIDO].ToString();
                Alumno alumnoMostrar = new Alumno(id, nombre, apellido);
                alumnos.Add(alumnoMostrar);
            }

            return alumnos;
        }

        public List<Telefono> GetTelefonosAlumno(Alumno alumno)
        {
            List<Telefono> telefonos = new List<Telefono>();

            DataRow[] dataRows = this.dataTableAlumno.Rows.Find(alumno.Id).GetChildRows(Constantes.RELATION_ALUMNO_TELEFONO);

            foreach (DataRow dataRow in dataRows)
            {
                int id = int.Parse(dataRow[Constantes.TELEFONO_ID].ToString());
                string numero = dataRow[Constantes.TELEFONO_NUMERO].ToString();
                Telefono telefonoMostrar = new Telefono(id, numero);
                telefonos.Add(telefonoMostrar);
            }
            return telefonos;
        }

        public List<VistaTelefono> GetTelefonos()
        {
            List<VistaTelefono> vistaTelefonos = new List<VistaTelefono>();

            this.dataViewTelefono = new DataView(this.dataTableTelefono, "", "", DataViewRowState.CurrentRows);

            foreach (DataRowView Rowview in dataViewTelefono)
            {
                DataRow row = Rowview.Row;
                int id = int.Parse(row[Constantes.TELEFONO_ID].ToString());
                int idAlumno = int.Parse(row[Constantes.ALUMNO_ID].ToString());
                string numero = row[Constantes.TELEFONO_NUMERO].ToString();

                VistaTelefono telefonoMostrar = new VistaTelefono(id, numero, idAlumno);
                vistaTelefonos.Add(telefonoMostrar);
            }

            return vistaTelefonos;
        }

        public void Actualizar()
        {
            dataAdapterAlumno.Update(dataTableAlumno);
            dataAdapterTelefono.Update(dataTableTelefono);
            dataTableAlumno.AcceptChanges();
            dataTableTelefono.AcceptChanges();
        }
    }
}
