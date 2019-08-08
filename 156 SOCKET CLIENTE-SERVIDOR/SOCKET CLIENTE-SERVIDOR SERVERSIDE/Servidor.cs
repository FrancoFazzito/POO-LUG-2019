using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SOCKET_CLIENTE_SERVIDOR_SERVERSIDE
{
    class servidorEvento : EventArgs
    {
        private string datos;
        private IPEndPoint ip;

        public string Datos { get => datos;}
        public IPEndPoint Ip { get => ip;}

        public servidorEvento(string datos, IPEndPoint ip)
        {
            this.datos = datos;
            this.ip = ip;
        }
    }

    class cambioConexion : EventArgs
    {
        private IPEndPoint ip;
        public IPEndPoint Ip { get => ip; }
        public cambioConexion(IPEndPoint ip)
        {
            this.ip = ip;
        }
    }
    class Servidor
    {
        private ConcurrentDictionary<IPEndPoint, ClienteModelo> clientesDictionary;
        private Thread listenerThread;
        private TcpListener listener;
        private int puerto;

        public event EventHandler<cambioConexion> NuevaConexion;
        public event EventHandler<servidorEvento> DatosRecibidos;
        public event EventHandler<cambioConexion> ConexionTerminada;
        public Servidor(int puerto)
        {
            clientesDictionary = new ConcurrentDictionary<IPEndPoint, ClienteModelo>();
            this.puerto = puerto;
        }

        public bool getConexion()
        {
            if(listenerThread != null)
            {
                return listenerThread.IsAlive;
            }
            return false;
        }

        public void Escuchar()
        {
            listener = new TcpListener(IPAddress.Any, puerto);
            listener.Start();

            listenerThread = new Thread(EsperarCliente);
            listenerThread.IsBackground = true;
            listenerThread.Start();
        }

        private void EsperarCliente()
        {
            while (true)
            {
                Socket socket = listener.AcceptSocket();
                IPEndPoint IP = socket.RemoteEndPoint as IPEndPoint;

                Thread thread = new Thread(() => LeerSocket(IP));
                thread.IsBackground = true;

                clientesDictionary[IP] = new ClienteModelo(thread, socket);

                this.NuevaConexion?.Invoke(this, new cambioConexion(IP));
                thread.Start();
            }
        }

        private void LeerSocket(IPEndPoint IP)
        {
            byte[] buffer = new byte[255];
            ClienteModelo cliente = clientesDictionary[IP];
            bool conexion = cliente.GetConexion();
            while (conexion)
            {
                try
                {
                    int cantidadRecibida = cliente.GetSocket().Receive(buffer,buffer.Length,SocketFlags.None);
                    bool vacio = cantidadRecibida > 0;
                    if (vacio)
                    {
                        string datosRecibido = Encoding.UTF8.GetString(buffer, 0, cantidadRecibida);
                        this.DatosRecibidos.Invoke(this, new servidorEvento(datosRecibido,IP));
                    }
                    else
                    {
                        this.ConexionTerminada.Invoke(this, new cambioConexion(IP));
                        conexion = false;
                    }
                }
                catch
                {
                    this.ConexionTerminada.Invoke(this, new cambioConexion(IP));
                    conexion = false;
                }
            }
            clientesDictionary.TryRemove(IP, out cliente);
        }

        public void EnviarDatosGeneral(string datos)
        {
            //KeyValuePair<IPEndPoint, ClienteModelo> cliente
            foreach (var cliente in clientesDictionary)
            {
                Socket socket = cliente.Value.GetSocket();
                byte[] mensaje = Encoding.UTF8.GetBytes(datos);
                socket.Send(mensaje);
            }
        }

        public void EnviarDatosParticular(string datos, IPEndPoint ip)
        {
            ClienteModelo buscado = clientesDictionary.First(cliente => cliente.Key == ip).Value;
            if(buscado != null)
            {
                byte[] mensaje = Encoding.UTF8.GetBytes(datos);
                buscado.GetSocket().Send(mensaje);
            }
            else
            {
                throw new Exception($"no existe el cliente con ip: {ip}");
            }
        }

        public void Cerrar()
        {
            foreach (KeyValuePair<IPEndPoint, ClienteModelo> cliente in clientesDictionary)
            {
                Socket socket = cliente.Value.GetSocket();
                socket.Close();
            }
        }
    }

    class ClienteModelo
    {
        private Thread thread;
        private Socket socket;

        public ClienteModelo(Thread thread, Socket socket)
        {
            this.thread = thread;
            this.socket = socket;
        }

        public bool GetConexion()
        {
            return this.socket.Connected;
        }

        public Socket GetSocket()
        {
            return this.socket;
        }
    }
}
