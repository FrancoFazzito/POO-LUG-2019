using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_DESCONECTADO
{
    class Gestor
    {
        #region CAMPOS
        //CONEXION CON BASE DE DATOS CON EL STRING:
        private string conexion = @"Data Source=.;Initial Catalog=Cliente;Integrated Security=True";

        //general a las tablas
        private DataSet dataSet;
        private SqlConnection sqlConnection;
        private DataRelation relation;

        #region tabla alumno
        //tabla cliente
        private DataTable dataTableCliente;
        private SqlDataAdapter dataAdapterCliente;
        private SqlCommandBuilder commandBuilderCliente;
        private DataView dataViewCliente;
        #endregion

        #region tabla telefono
        //tabla telefono
        private DataTable dataTableTelefono;
        private SqlDataAdapter dataAdapterTelefono;
        private SqlCommandBuilder commandBuilderTelefono;
        private DataView dataViewTelefono;
        #endregion

        #endregion

        #region CONSTRUCTOR
        //INICIO DE GESTOR INICIANDO LOS DATOS
        public Gestor()
        {
            dataSet = new DataSet();
            sqlConnection = new SqlConnection(conexion);

            //creacion tabla cliente
            CrearTablaCliente();

            //creacion tabla telefono
            CrearTablaTelefono();

            //creacion relation
            CrearRelacion();

            //seteamos PK de las tablas
            cargarPKs();
        }

        private void cargarPKs()
        {
            //tomamos la columna codigo y lo seteamos como primary key
            DataColumn PKcliente = dataTableCliente.Columns["codigo_cliente"];
            dataTableCliente.PrimaryKey = new DataColumn[] { PKcliente };

            //tomamos la columna codigo y lo seteamos como primary key
            DataColumn PKtelefono = dataTableTelefono.Columns["codigo_telefono"];
            dataTableTelefono.PrimaryKey = new DataColumn[] { PKtelefono };
        }
        #endregion

        #region CREACION TABLAS RELACIONES Y CARGAS DE PK
        private void CrearRelacion()
        {
            DataColumn primaryKeyCliente = dataTableCliente.Columns["codigo_cliente"];
            DataColumn foreignKeyTelefono = dataTableTelefono.Columns["codigo_telefono"];
            relation = new DataRelation("cliente_telefono", primaryKeyCliente, foreignKeyTelefono);
            dataSet.Relations.Add(relation);
        }

        private void CrearTablaTelefono()
        {
            //mismos pasos comentados en cliente
            dataTableTelefono = new DataTable("telefono");
            dataAdapterTelefono = new SqlDataAdapter("select * from telefono", sqlConnection);

            commandBuilderTelefono = new SqlCommandBuilder(dataAdapterTelefono);
            dataAdapterTelefono.InsertCommand = commandBuilderTelefono.GetInsertCommand();
            dataAdapterTelefono.UpdateCommand = commandBuilderTelefono.GetUpdateCommand();
            dataAdapterTelefono.DeleteCommand = commandBuilderTelefono.GetDeleteCommand();

            dataSet.Tables.Add(dataTableTelefono);

            dataAdapterTelefono.Fill(dataSet, "telefono");

        }

        private void CrearTablaCliente()
        {
            //creamos la tabla y le asignamos un nombre
            dataTableCliente = new DataTable("cliente");
            //cargamos el dataAdapter con el select de cliente y una conexion
            dataAdapterCliente = new SqlDataAdapter("select * from cliente", sqlConnection);

            //seteamos los comandos del command builder con el adaptador
            commandBuilderCliente = new SqlCommandBuilder(dataAdapterCliente);
            dataAdapterCliente.InsertCommand = commandBuilderCliente.GetInsertCommand();
            dataAdapterCliente.UpdateCommand = commandBuilderCliente.GetUpdateCommand();
            dataAdapterCliente.DeleteCommand = commandBuilderCliente.GetDeleteCommand();

            //agregamos el datatable al dataset
            dataSet.Tables.Add(dataTableCliente);
            //agregamos el dataset al cliente
            dataAdapterCliente.Fill(dataSet, "cliente");
        }
        #endregion

        #region ABMC CLIENTE

        //INSERT
        public void AltaCliente(Cliente cliente)
        {
            //creo la nueva row 
            DataRow rowAlta = dataTableCliente.NewRow();

            //cargamos la row
            rowAlta["codigo_cliente"] = cliente.Codigo;
            rowAlta["nombre"] = cliente.Nombre;
            rowAlta["apellido"] = cliente.Apellido;

            //agregamos la row al datatable
            dataTableCliente.Rows.Add(rowAlta);

            //llamamos a actualizar para hacer el update
            ActualizarClientes();
        }

        //UPDATE
        public void ModificarCliente(Cliente cliente)
        {
            //buscamos la tabla con find sobre la PK que es codigo
            DataRow rowModificar = dataTableCliente.Rows.Find(cliente.Codigo);

            //cargamos la row con los datos modificados
            rowModificar["nombre"] = cliente.Nombre;
            rowModificar["apellido"] = cliente.Apellido;

            //llamamos a actualizar para hacer el update
            ActualizarClientes();
        }

        //DELETE
        public void BajaCliente(Cliente cliente)
        {
            //buscamos la tabla con find sobre la PK que es codigo
            DataRow rowBaja = dataTableCliente.Rows.Find(cliente.Codigo);

            //eliminamos con delete 
            rowBaja.Delete();

            //llamamos a actualizar para hacer el update
            ActualizarClientes();
        }

        //ACTUALIZAMOS LA DATABASE
        public void ActualizarClientes()
        {
            //actulizamos con dataadapter la table
            dataAdapterCliente.Update(dataTableCliente);
            //aceptamos los cambios
            dataTableCliente.AcceptChanges();
        }

        //SELECT * FROM
        public List<Cliente> ObtenerClientes()
        {
            //creamos la lista para almacenar
            List<Cliente> clientes = new List<Cliente>();
            //iniciamos el dataview para poder observar los datos
            dataViewCliente = new DataView(dataTableCliente, ""/*filtro row*/, ""/*sort*/, DataViewRowState.CurrentRows/*tomamos las rows con el ultimo cambio*/);

            //dataview alumno recorre en rowViews
            foreach (DataRowView rowView in dataViewCliente)
            {
                //tomamos la row
                DataRow row = rowView.Row;

                //tomamos la info de la row
                int codigo = int.Parse(row["codigo_cliente"].ToString());
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();
                //creamos el cliente a mostrar y lo agregamos a nuestra lista
                Cliente clienteMostrar = new Cliente(codigo, nombre, apellido);
                clientes.Add(clienteMostrar);
            }

            return clientes;
        }
        
        //SELECT TELEFONOS DEL CLIENTE
        public List<Telefono> ObtenerTelefonosCliente(Cliente cliente)
        {
            //tomamos una lista para cargar
            List<Telefono> telefonos = new List<Telefono>();

            //tomamos las rows de la relacion entre alumnos y telefono
            //telefonos del cliente 
            DataRow[] dataRowsTelefono = dataTableCliente.Rows.Find(cliente.Codigo).GetChildRows("cliente_telefono");

            foreach (DataRow RowTelefono in dataRowsTelefono)
            {
                int codigo = int.Parse(RowTelefono["codigo_telefono"].ToString());
                string numero = RowTelefono["numero"].ToString();

                Telefono telefonoMostrar = new Telefono(codigo, numero);
                telefonos.Add(telefonoMostrar);
            }

            return telefonos;
        }
        #endregion

        #region ABMC TELEFONO
        //MISMOS PASO QUE CON CLIENTE, EL UNICO CAMBIO EL ALTA CON EL ID DE CLIENTE
        public void AltaTelefono(Telefono telefono,Cliente cliente)
        {
            DataRow rowAlta = dataTableTelefono.NewRow();

            rowAlta["codigo_telefono"] = telefono.Codigo;
            rowAlta["numero"] = telefono.Numero;
            rowAlta["codigo_cliente"] = cliente.Codigo;

            dataTableTelefono.Rows.Add(rowAlta);
            ActualizarTelefonos();
        }

        public void BajaTelefono(Telefono telefono)
        {
            DataRow rowBaja = dataTableTelefono.Rows.Find(telefono.Codigo);

            rowBaja.Delete();

            ActualizarTelefonos();
        }

        public void ModificacionTelefono(Telefono telefono)
        {
            DataRow rowModificacion = dataTableTelefono.Rows.Find(telefono.Codigo);

            rowModificacion["codigo_telefono"] = telefono.Codigo;
            rowModificacion["numero"] = telefono.Numero;

            ActualizarTelefonos();
        } 

        public void ActualizarTelefonos()
        {
            dataAdapterTelefono.Update(dataTableTelefono);
            dataTableTelefono.AcceptChanges();
        }
        #endregion
    }
}
