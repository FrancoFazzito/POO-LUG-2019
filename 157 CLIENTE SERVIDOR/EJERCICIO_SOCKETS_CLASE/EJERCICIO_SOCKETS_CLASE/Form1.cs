using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_SOCKETS_CLASE
{
    public partial class Form1 : Form
    {
        private Client cliente;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
           
            try
            {
                cliente = new Client(Parse.ConvertToString(txt_name));
                cliente.Conect(Parse.ConvertToIpAdress(txt_ip), Parse.ConvertToInt(txt_port));
                cliente.eventDataReceived += Cliente_eventDataReceived;
                Log(cliente.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(messageErrorForm(ex));
            }
        }

        private void Cliente_eventDataReceived(object sender, datosRecibidos e)
        {
            Log(e.datoRecibido);
        }

        private void Log(string datoRecibido)
        {
            Invoke((Action)delegate
            {
                listBox1.Items.Add(datoRecibido);
            });
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.SendData(Parse.ConvertToString(txt_message));
            }
            catch (Exception ex)
            {
                MessageBox.Show(messageErrorForm(ex));
            }
        }

        private static string messageErrorForm(Exception ex)
        {
            return $"{ex.Message}";
        }

    }

    public static class Parse
    {
        private const string MESSAGE_VALUE_ERROR = "No se ingreso un input correcto";

        public static string ConvertToString(TextBox txt)
        {
            string value = txt.Text.ToString();
            if (value != string.Empty)
            {
                return value;
            }
            else
            {
                throw new Exception(MessageError(txt));
            }
        }

        public static int ConvertToInt(TextBox txt)
        {
            int value = int.MinValue;
            bool validationInt = int.TryParse(txt.Text, out value);
            if (validationInt)
            {
                return value;
            }
            else
            {
                throw new Exception(MessageError(txt));

            }
        }
        public static IPAddress ConvertToIpAdress(TextBox txt)
        {
            IPAddress adress = null;
            bool validationIp = IPAddress.TryParse(txt.Text, out adress);

            if (validationIp)
            {
                return adress;
            }
            else
            {
                throw new Exception(MessageError(txt));
            }
        }

        private static string MessageError(TextBox txt)
        {
            return $"{MESSAGE_VALUE_ERROR} en {txt.Name} ";
        }

    }
}
