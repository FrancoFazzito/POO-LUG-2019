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

namespace ClienteFormDisconnect
{
    public partial class Form1 : Form
    {
        Socket socket;
        Socket accepted;

        public Form1()
        {
            InitializeComponent();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            socket = GetNewSocket();

            socket.Bind(new IPEndPoint(0, 6));
            socket.Listen(0);

            new Thread(delegate ()
            {
                accepted = socket.Accept();
                MessageBox.Show("CONNECTED ACCEPTED");
                socket.Close();

                while (true)
                {
                    try
                    {
                        byte[] buffer = new byte[255];
                        int rec = accepted.Receive(buffer, 0, buffer.Length, 0);

                        if (rec <= 0)
                        {
                            throw new SocketException();
                        }

                        Array.Resize(ref buffer, rec);

                        Invoke((MethodInvoker)delegate
                        {
                            listBox1.Items.Add(Encoding.Default.GetString(buffer));
                        });
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("DESCONECTADO");
                        accepted.Close();
                        break;
                    }
                }
                Application.Exit();
            }).Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.Default.GetBytes(textBox2.Text);
            accepted.Send(data, 0, data.Length, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
