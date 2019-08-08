using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace cliente__ejemplo_def_
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.0.4"), 1500);

            socket.Connect(endPoint);

            Console.WriteLine("enter message");

            string msg = Console.ReadLine();
            byte[] msgbuffer = Encoding.Default.GetBytes(msg);
            socket.Send(msgbuffer, 0, msgbuffer.Length, 0);

            byte[] buffer = new byte[256];
            int rec = socket.Receive(buffer, 0, buffer.Length, 0);

            Array.Resize(ref buffer, rec);

            Console.WriteLine("recibido {0}", Encoding.Default.GetString(buffer));

            Console.Read();
        }
    }
}
