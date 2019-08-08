using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SOCKET_CLIENTE_SERVIDOR
{
    class Cliente : IDisposable
    {
        private bool conectado;

        private Socket socket;
        private Thread thread;

        public event EventHandler<datosRecibidosEvent> DatosRecibido;
        public event EventHandler conexionTerminada;
        public IPEndPoint GetLocal_IP()
        {
            return this.socket?.LocalEndPoint as IPEndPoint;
        }

        public IPEndPoint GetRemote_IP()
        {
            return this.socket?.RemoteEndPoint as IPEndPoint;
        }

        public bool estaConectado()
        {
            return this.conectado;
        }
        public void Conectar(string IP, int port)
        {
            if (conectado)
            {
                throw new Exception($"ya esta conectado a {IP} {port}");
            }

            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(IP /*IP*/, port /*puerto*/);

            this.conectado = true;

            thread = new Thread(LeerSocket);
            thread.IsBackground = true;
            thread.Start();
        }
        public void EnviarDatos(object datos)
        {
            if (conectado)
            {
                byte[] buffer = Encoding.UTF8.GetBytes(datos.ToString());
                socket.Send(buffer);
            }
            else
            {
                throw new Exception("no esta conectado");
            }
        }
        private void LeerSocket()
        {
            byte[] buffer = new byte[255];
            while (conectado)
            {
                try
                {
                    int cantidadRecibida = socket.Receive(buffer, buffer.Length, SocketFlags.None);
                    bool vacio = cantidadRecibida > 0;
                    if (vacio)
                    {
                        string mensaje = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);
                        DatosRecibido?.Invoke(this, new datosRecibidosEvent() { DatosRecibidos = mensaje } );
                    }
                }
                catch 
                {
                    socket.Close();
                    conectado = false;
                }
            }
            conexionTerminada?.Invoke(this, new EventArgs());
        }

        public void Dispose()
        {
            socket.Close();
            this.conectado = false;
            this.socket = null;
            this.thread = null;
        }

        public class datosRecibidosEvent : EventArgs
        {
            public string DatosRecibidos { get; set; }
        }


    }
    
}
