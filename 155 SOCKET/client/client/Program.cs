using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            conectar();
        }

        private static void conectar()
        {
            Socket primerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("192.168.0.4"), 1234);
            string texto;
            byte[] textoEnviar;

            try
            {
                primerSocket.Connect(direccion);
                Console.WriteLine("conectado con exito");
                Console.WriteLine("ingrese texto");
                texto = Console.ReadLine();
                textoEnviar = Encoding.Default.GetBytes(texto);
                primerSocket.Send(textoEnviar, 0, textoEnviar.Length, 0);
                Console.WriteLine("enviado de forma correcta");
                primerSocket.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine("presione para continuar");
            Console.ReadLine();
        }
    }
}
