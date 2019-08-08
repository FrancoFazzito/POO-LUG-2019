using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCKET_CLIENTE_SERVIDOR_SERVERSIDE
{
    public partial class Form1 : Form
    {
        private const int PORT_ESCUCHA = 8050;
        private Servidor servidor;
        public Form1()
        {
            InitializeComponent();
            servidor = new Servidor(PORT_ESCUCHA);

            servidor.NuevaConexion += Servidor_NuevaConexion;
            servidor.ConexionTerminada += Servidor_ConexionTerminada;
            servidor.DatosRecibidos += Servidor_DatosRecibidos;
            ValidacionCheckBox();
        }

        private void Servidor_DatosRecibidos(object sender, servidorEvento e)
        {
            Log($"{DateTime.Now}: {e.Datos} desde {e.Ip}");
            ValidacionCheckBox();
        }

        private void Servidor_ConexionTerminada(object sender, cambioConexion e)
        {
            Log($"{DateTime.Now}: CONEXION TERMINADA DE {e.Ip}");
            ValidacionCheckBox();
        }

        private void Servidor_NuevaConexion(object sender, cambioConexion e)
        {
            Log($"{DateTime.Now}: NUEVA CONEXION DE {e.Ip}");
            ValidacionCheckBox();
        }
        private void Log(string value)
        {
            Invoke((MethodInvoker)delegate
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.Items.Add(value);
            });
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            servidor.Escuchar();
            ValidacionCheckBox();
        }

        private void ValidacionCheckBox()
        {
            checkBox1.Checked = servidor.getConexion();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            servidor.EnviarDatosGeneral($"{txtDatosSend.Text} desde SERVER en PORT: {PORT_ESCUCHA} y IP: {IPAddress.Any}");
            ValidacionCheckBox();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            IPEndPoint remote = new IPEndPoint(IPAddress.Parse(IP.Text), PORT_ESCUCHA);
            servidor.EnviarDatosParticular(txtDatosParticularSend.Text, remote);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
