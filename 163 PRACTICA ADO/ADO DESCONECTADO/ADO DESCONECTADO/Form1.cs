using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_DESCONECTADO
{
    public partial class Form1 : Form
    {
        private Gestor gestor;
        public Form1()
        {
            InitializeComponent();
            gestor = new Gestor();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //CARGAMOS LOS CLIENTES EXISTENTES
            MostrarClientes();
        }

        #region ABMC EVENTOS BOTONES TELEFONO
        private void Btn_alta_cliente_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigo.Text);
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            Cliente clienteAlta = new Cliente(codigo, nombre, apellido);
            gestor.AltaCliente(clienteAlta);
            MostrarClientes();
        }

        private void Btn_baja_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigo.Text);
            string nombre = txt_nombre.Text; //podemos poner esto com " " ya que no necesitamos nombre y apellido en baja
            string apellido = txt_apellido.Text;

            //ejecutamos la baja de los telefonos del cliente
            BajaTelefonosCliente();

            Cliente clienteBaja = new Cliente(codigo, nombre, apellido);
            gestor.BajaCliente(clienteBaja);
            MostrarClientes();
        }

        private void BajaTelefonosCliente()
        {
            Cliente clienteBaja = ObtenerClienteDatagrid();
            foreach (Telefono telefono in gestor.ObtenerTelefonosCliente(clienteBaja))
            {
                gestor.BajaTelefono(telefono);
            }
        }

        private void Txt_modificar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigo.Text);
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            Cliente clienteAlta = new Cliente(codigo, nombre, apellido);
            gestor.ModificarCliente(clienteAlta);
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            DGV_clientes.DataSource = null;
            DGV_clientes.DataSource = gestor.ObtenerClientes();
        }

        private void MostrarTelefonosCliente()
        {
            dataGridView1.DataSource = null;
            //obtengo cliente del datagrid
            Cliente ClienteMostrar = ObtenerClienteDatagrid();
            dataGridView1.DataSource = gestor.ObtenerTelefonosCliente(ClienteMostrar);
        }
        #endregion

        #region ABMC EVENTOS TELEFONO
        #endregion

        private void Button3_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigo_telefono.Text);
            string numero = txt_numero_telefono.Text;
            Telefono telefono = new Telefono(codigo, numero);
            Cliente cliente = ObtenerClienteDatagrid();
            gestor.AltaTelefono(telefono, cliente);
        }

        private Cliente ObtenerClienteDatagrid()
        {
            return DGV_clientes.SelectedRows[0].DataBoundItem as Cliente;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigo_telefono.Text);
            string numero = txt_numero_telefono.Text;
            Telefono telefono = new Telefono(codigo, numero);
            gestor.BajaTelefono(telefono);
        }

        private void DGV_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarTelefonosCliente();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txt_codigo_telefono.Text);
            string numero = txt_numero_telefono.Text;
            Telefono telefono = new Telefono(codigo, numero);
            gestor.ModificacionTelefono(telefono);
        }
    }
}
