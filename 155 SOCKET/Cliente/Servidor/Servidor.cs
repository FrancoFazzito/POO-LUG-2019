using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Concurrent;
using System.Threading;

namespace Servidor
{
    public class ServidorEventArgs : EventArgs //eventos del servidor
    {
        public ServidorEventArgs(IPEndPoint ep)
        {
            EndPoint = ep;
        }

        public IPEndPoint EndPoint { get; }
    }

    public class DatosRecibidosEventArgs : ServidorEventArgs //evento de recibo de datos
    {
        public DatosRecibidosEventArgs(IPEndPoint ep, string datos) : base(ep)
        {
            DatosRecibidos = datos;
        }

        public string DatosRecibidos { get; set; }
    }
    class Servidor
    {


        private struct InfoDeUnCliente
        {
            public Socket Socket; // Socket utilizado para mantener la conexión con el cliente
            public Thread Thread; // Thread utilizado para escuchar al cliente
        }

        private Thread listenerThread; //escucha las conexiones nuevas
        private TcpListener listener;  // escuhar conexion entrantes
        private ConcurrentDictionary<IPEndPoint, InfoDeUnCliente> clientes = new ConcurrentDictionary<IPEndPoint, InfoDeUnCliente>();

        public int PuertoEscucha { get; }
        public event EventHandler<ServidorEventArgs> NuevaConexion;
        public event EventHandler<ServidorEventArgs> ConexionTerminada;
        public event EventHandler<DatosRecibidosEventArgs> DatosRecibidos;

        public Servidor(int puerto)
        {
            PuertoEscucha = puerto;
        }

        public void Escuchar()
        {
            listener = new TcpListener(IPAddress.Any, PuertoEscucha);
            listener.Start();
            listenerThread = new Thread(EsperarCliente);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }

        public void Cerrar()
        {
            foreach (InfoDeUnCliente cliente in clientes.Values)
            {
                cliente.Socket.Close();
            }
        }

        public void EnviarDatos(string datos)
        {
            foreach (InfoDeUnCliente cliente in clientes.Values)
            {
                cliente.Socket.Send(Encoding.UTF8.GetBytes(datos));
            }
        }

        private void EsperarCliente()
        {
            while (true)
            {
                Socket socket = listener.AcceptSocket(); // Se queda esperando la conexión de un cliente
                IPEndPoint endPoint = socket.RemoteEndPoint as IPEndPoint;

                Thread thread = new Thread(() => LeerSocket(endPoint));
                thread.IsBackground = true;

                clientes[endPoint] = new InfoDeUnCliente()
                {
                    Socket = socket,
                    Thread = thread,
                };

                // Disparo el evento NuevaConexion
                NuevaConexion?.Invoke(this, new ServidorEventArgs(endPoint));

                // Inicio el thread encargado de escuchar los mensajes del cliente
                thread.Start();
            }
        }

        private void LeerSocket(IPEndPoint endPoint)
        {
            var buffer = new byte[100]; // Array a utilizar para recibir los datos que llegan
            var cliente = clientes[endPoint]; // Información del cliente que se va a escuchar
            while (cliente.Socket.Connected)
            {
                try
                {
                    // Me quedo esperando a que llegue un mensaje desde el cliente
                    int cantidadRecibida = cliente.Socket.Receive(buffer, buffer.Length, SocketFlags.None);

                    // Me fijo cuántos bytes recibí. Si no recibí nada, entonces se desconectó el cliente
                    if (cantidadRecibida > 0)
                    {
                        // Decodifico el mensaje recibido usando UTF-8 (https://es.wikipedia.org/wiki/UTF-8)
                        var datosRecibidos = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);

                        // Disparo el evento de la recepción del mensaje
                        DatosRecibidos?.Invoke(this, new DatosRecibidosEventArgs(endPoint, datosRecibidos));
                    }
                    else
                    {
                        // Disparo el evento de la finalización de la conexión
                        ConexionTerminada?.Invoke(this, new ServidorEventArgs(endPoint));
                        break;
                    }
                }
                catch
                {
                    if (!cliente.Socket.Connected)
                    {
                        // Disparo el evento de la finalización de la conexión
                        ConexionTerminada?.Invoke(this, new ServidorEventArgs(endPoint));
                        break;
                    }
                }
            }
            clientes.TryRemove(endPoint, out cliente);
        }
    }
}
