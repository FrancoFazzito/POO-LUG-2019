using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Cliente
{
    class Cliente
    {
        #region PROPS VARS
        private Socket socket; // socket para enviar y recibir datos 
        private Thread thread; // thread para escuchar los mensajes del server
        private bool conectado;
        public event EventHandler ConexionTerminada;
        public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;

        public bool Conectado { get { return conectado; } }

        public IPEndPoint LocalEndPoint { get { return socket?.LocalEndPoint as IPEndPoint; } }//get puerto/ip local

        public IPEndPoint RemoteEndPoint { get { return socket?.RemoteEndPoint as IPEndPoint; } }//get puerto/ip servidor

        

        #endregion

        public void Conectar(string ip, int puerto)
        {
            if (conectado)
            {
                return;
            }

            socket = new Socket(SocketType.Stream, ProtocolType.Tcp); //creacion del socket 
            socket.Connect(ip, puerto); //nos conectamos a servidor

            conectado = true;

            thread = new Thread(LeerSocket);
            thread.IsBackground = true;
            thread.Start();
        }

        public void LeerSocket()
        {
            byte[] buffer = new byte[100]; //instancia de buffer donde colocaremos los datos
            while (true)
            {
                try
                {
                    // Me quedo esperando a que llegue algún mensaje
                    int cantidadRecibida = socket.Receive(buffer: buffer, size: buffer.Length, SocketFlags.None); //retorna numero de bytes

                    if (cantidadRecibida > 0)
                    {

                        string mensaje = Encoding.UTF8.GetString(
                            bytes: buffer, /*QUE SE MANDA*/
                            index: 0, /*EN QUE POSICION*/
                            count: cantidadRecibida /*LENGHT*/ ); //se decodifica el mensaje
                        DatosRecibidos?.Invoke(this, new DatosRecibidosEventArgs(mensaje)); //y se invoca con el mensaje
                    }
                }
                catch
                {
                    socket.Close();
                    break;
                }
            }

            conectado = false;
            ConexionTerminada?.Invoke(this, new EventArgs());
        }

        public void EnviarDatos(string datos)
        {
            if (conectado)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(datos);
                socket?.Send(bytes);
            }
        }

        public class DatosRecibidosEventArgs : EventArgs
        {
            public DatosRecibidosEventArgs(string datos)
            {
                DatosRecibidos = datos;
            }

            public string DatosRecibidos { get; set; }
        }
    }
}
