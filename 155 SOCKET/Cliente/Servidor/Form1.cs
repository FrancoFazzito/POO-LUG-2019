using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Servidor servidor;
        private void Form1_Load(object sender, EventArgs e)
        {
            servidor = new Servidor(8050);

            servidor.NuevaConexion += Servidor_ConexionTerminada;
            servidor.ConexionTerminada += Servidor_ConexionTerminada;
            servidor.DatosRecibidos += Servidor_DatosRecibidos;

            servidor.Escuchar();
        }

        private void Servidor_NuevaConexion(object sender, ServidorEventArgs e)
        {
            Log($"Se ha conectado un nuevo cliente desde la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}");
        }

        private void Servidor_ConexionTerminada(object sender, ServidorEventArgs e)
        {
            Log($"Se ha desconectado el cliente de la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}");
        }

        private void Servidor_DatosRecibidos(object sender, DatosRecibidosEventArgs e)
        {
            Log($"Nuevo mensaje desde el cliente de la IP = {e.EndPoint.Address}, Puerto = {e.EndPoint.Port}");
            Log(e.DatosRecibidos);
        }
        private void Log(string texto)
        {
            Invoke((Action)delegate
            {
                txtLog.AppendText($"{DateTime.Now.ToLongTimeString()} - {texto}");
                txtLog.AppendText("\n");
            });
        }
    }
}
