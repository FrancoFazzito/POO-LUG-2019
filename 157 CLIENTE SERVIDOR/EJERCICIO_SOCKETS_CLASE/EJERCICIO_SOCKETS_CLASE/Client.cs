using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EJERCICIO_SOCKETS_CLASE
{
    class datosRecibidos : EventArgs
    {
        public string datoRecibido { get; set; }
        public datosRecibidos()
        {
            datoRecibido = string.Empty;
        }
    }

    class Client
    {
        public event EventHandler<datosRecibidos> eventDataReceived;

        private const int offset = 0;
        private TcpClient clienteSocket;
        private NetworkStream serverStream;

        private string nickName;
        private IPAddress ip;
        private int port;

        private string readData;
        private bool connected;
        
        public Client(string nickName)
        {
            //init de las variables
            clienteSocket = new TcpClient();
            serverStream = default(NetworkStream);
            readData = string.Empty;
            connected = false;
            this.nickName = nickName;
        }

        public void SendData(string message)
        {
            if (connected)
            {
                byte[] dataOut = Encoding.ASCII.GetBytes(message); // se pasa a byte [ ] el mensaje

                serverStream.Write(dataOut, offset /*0*/, dataOut.Length);
                serverStream.Flush(); //vaciar datos de la secuencia
            }
            else
            {
                throw new Exception($"Estimado {nickName} usted no esta conectado al servidor, error al enviar {message}");
            }
        }

        public void Conect(IPAddress ipAdress, int portNumber)
        {
            this.ip = ipAdress;
            this.port = portNumber;
            this.clienteSocket.Connect(ip , port);
            this.connected = clienteSocket.Connected;
            if (connected)
            {
                string messageConnection = $"Estimado {nickName} se ha conectado a servidor con IP: {ipAdress} y PORT: {portNumber}";
                byte[] dataOut = Encoding.ASCII.GetBytes(messageConnection);

                serverStream.Write(dataOut, offset /*0*/, dataOut.Length);
                serverStream.Flush(); //vaciar datos de la secuencia

                Thread ClientThread = new Thread(GetMessage);
                ClientThread.IsBackground = true;
                ClientThread.Start();
            }
            else
            {
                throw new Exception("No se ha podido conectar con servidor");
            }
        }

        private void GetMessage()
        {
            serverStream = clienteSocket.GetStream();

            byte[] dataIn = new byte[256];
            int bufferSize = clienteSocket.ReceiveBufferSize;

            serverStream.Read(dataIn, 0, bufferSize);

            string message = Encoding.ASCII.GetString(dataIn);
            this.eventDataReceived.Invoke(this, new datosRecibidos { datoRecibido = message });
        }

        public override string ToString()
        {
            return $"NAME: {this.nickName} IP: {this.ip} PORT: {this.port}";
        }
    }
}
