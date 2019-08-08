using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            cliente.ConexionTerminada += Cliente_ConexionTerminada;
            cliente.DatosRecibidos += Cliente_DatosRecibidos;
        }

        private void Cliente_DatosRecibidos(object sender, Cliente.DatosRecibidosEventArgs e)
        {
            Log("el servidor envio " + e.DatosRecibidos);
        }

        private void Cliente_ConexionTerminada(object sender, EventArgs e)
        {
            Log("finalizo conexion");

        }

        private void Log(string texto)
        {
            Invoke((Action)delegate
            {
                txtRecibido.AppendText($"{DateTime.Now.ToLongTimeString()} - {texto} ");
                txtRecibido.AppendText("\n");
            });
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            int puerto;
            bool validation = int.TryParse(txtPuerto.Text, out puerto);
            if (!validation)
            {
                MessageBox.Show("port invalido");
            }

            string ip = txtIP.Text;

            cliente.Conectar(ip, puerto);
            Log($"IP = {cliente.RemoteEndPoint.Address}, PORT = {cliente.RemoteEndPoint.Port}");

        }

        private void BtnEnviarMensaje_Click(object sender, EventArgs e)
        {
            cliente.EnviarDatos(txtMensaje.Text);
        }
    }
}
