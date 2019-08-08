using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCKET_CLIENTE_SERVIDOR
{
    public partial class Form1 : Form
    {
        private Cliente cliente;
        
        public Form1()
        {
            InitializeComponent();
            cliente = new Cliente();
            cliente.conexionTerminada += Cliente_conexionTerminada;
            cliente.DatosRecibido += Cliente_DatosRecibido;
            validacionCheck();
        }

        private void Cliente_DatosRecibido(object sender, Cliente.datosRecibidosEvent e)
        {
            Log(e.DatosRecibidos);
            validacionCheck();
        }

        private void Cliente_conexionTerminada(object sender, EventArgs e)
        {
            Log("finalizo conexion");
            validacionCheck();
        }

        private void Log(string datos)
        {
            Invoke((Action)delegate
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.Items.Add(datos);
            });
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int puerto;
            string ip = txtIp.Text;

            bool countPoint = ip.Count(f => f == '.') == 3;
            bool validacionPort = int.TryParse(txtPort.Text, out puerto);

            if (validacionPort && countPoint)
            {
                cliente.Conectar(ip, puerto);
                Log($"el cliente se conecto al servidor IP = {cliente.GetRemote_IP().Address} PORT = {cliente.GetRemote_IP().Port}");
                validacionCheck();
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            cliente.EnviarDatos(txtMensaje.Text);
            validacionCheck();
        }

        private void validacionCheck()
        {
            checkBox1.Checked = cliente.estaConectado();
        }
    }
}
