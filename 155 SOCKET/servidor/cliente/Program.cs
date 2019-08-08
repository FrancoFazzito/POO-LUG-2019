using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            conectar();
        }

        private static void conectar()
        {
            byte[] ByRec;

            Socket PrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 1234);

            try
            {
                PrimerSocket.Bind(direccion);
                PrimerSocket.Listen(1);

                Console.WriteLine("escuchando..");

                Socket escuchar = PrimerSocket.Accept();

                ByRec = new byte[255];

                int a = escuchar.Receive(ByRec, 0, ByRec.Length, 0);
                Array.Resize(ref ByRec, a);
                Console.WriteLine("cliente dice " + Encoding.Default.GetString(ByRec));

                PrimerSocket.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA TERMINAR");
            Console.ReadLine();
        }
    }
}
