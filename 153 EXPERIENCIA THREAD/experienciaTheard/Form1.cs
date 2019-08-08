using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experienciaTheard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                text: "Se bloqueara la interfaz grafica debido a que se usa el bucle infinito en el thread que corresponde a esta",
                caption: "BLOQUEO",
                buttons: MessageBoxButtons.OKCancel,
                icon: MessageBoxIcon.Error);

            if (result == DialogResult.OK)
            {
                BucleInfinito();
            }
        }

        #region BUCLE
        private void BucleInfinito()
        {
            var nombreHiloGrafico = Thread.CurrentThread.Name;
            textBox2.Text = nombreHiloGrafico;
            int count = 0;
            while (true)
            {
                Thread.Sleep(1); //PARA MOSTRAR MEJOR
                if (listBox1.Items.Count > 30)
                {
                    listBox1.Items.Clear();
                }
                else
                {
                    count++;
                    label2.Text = count.ToString();
                }
            }
        }
        #endregion

        private void Button3_Click(object sender, EventArgs e)
        {
            Thread hiloInfinito = new Thread(BucleInfinitoThread);
            hiloInfinito.Name = "hilo prueba";
            hiloInfinito.Start();
        }

        #region BUCLE HILO
        private void BucleInfinitoThread()
        {
            string nombreHiloGrafico = Thread.CurrentThread.Name;
            asignarTextbox(nombreHiloGrafico);
            int count = 0;
            while (true)
            {
                Thread.Sleep(100); //PARA MOSTRAR MEJOR
                if (listBox1.Items.Count >= 30)
                {
                    clear();
                }
                else
                {
                    count++;
                    AddListbox(count.ToString());
                }

            }
        }

        #region metodos para comunicacion interfaz - thread
        public void asignarTextbox(string value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(asignarTextbox), new object[] { value });
                return;
            }
            textBox2.Text = value;
        }
        public void clear()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(clear));
                return;
            }
            listBox1.Items.Clear();
        }
        public void AddListbox(object value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object>(AddListbox), new object[] { value });
                return;
            }
            label2.Text = value.ToString();
            listBox1.Items.Add(value);
        }
        #endregion

        #endregion

    }
}
