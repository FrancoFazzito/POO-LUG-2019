using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server__ejemplo_def_
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(new IPEndPoint(IPAddress.Parse("0"), 1500));
            socket.Listen(0);

            Console.WriteLine("SERVIDOR OK");

            Socket accepted = socket.Accept();

            byte[] buffer = Encoding.Default.GetBytes("hello cliente");

            accepted.Send(buffer, 0, buffer.Length, 0);

            buffer = new byte[256];

            int rec = accepted.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            Console.WriteLine("recibido {0} ", Encoding.Default.GetString(buffer));

            socket.Close();
            accepted.Close();

            Console.Read();
        }
    }
}
