using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace clientFormDisconnect
{
    public partial class Form1 : Form
    {
        Socket socket;
        public Form1()
        {
            InitializeComponent();
            socket = GetNewSocket();
            FormClosing += Form1_FormClosing;    
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Close();
        }

        Socket GetNewSocket()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               socket.Connect(new IPEndPoint(IPAddress.Parse(textBox20.Text), 6));
               new Thread(() =>
               {
                   read();
               }).Start();
            }
            catch (Exception)
            {
                MessageBox.Show("CONNECTION FAILED");
            }
            
        }

        void read()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[255];
                    int rec = socket.Receive(buffer, 0, buffer.Length, 0);
                    if(rec <= 0)
                    {
                        throw new Exception();
                    }
                    Array.Resize(ref buffer, rec);

                    Invoke((MethodInvoker)delegate
                    {
                        listBox1.Items.Add(Encoding.Default.GetString(buffer));
                    });
                }
                catch (Exception)
                {

                    
                }
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.Default.GetBytes(textBox1.Text);

            socket.Send(data,0,data.Length,0);
        }
    }
}
