using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
namespace TaTeTi_Cliente
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        private int contador;
        public Cuadro Tablero = new Cuadro();
        private string nombre;
        private string simbolo;
        public Form1()
        {
            InitializeComponent();
        }
        public void CargarPiezas(string cadena)
        {
            int fin = cadena.Count();

            if (cadena != "" && fin >= 9)
            {
                for (int i = 0; i < fin; i++)
                {
                    char dato = cadena.ElementAt<char>(i);
                    if (dato == 'X')
                    {
                        switch (i)
                        {
                            case 0:
                                ImgBox1.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 1:
                                ImgBox2.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 2:
                                ImgBox3.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 3:
                                ImgBox4.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 4:
                                ImgBox5.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 5:
                                ImgBox6.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 6:
                                ImgBox7.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 7:
                                ImgBox8.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            case 8:
                                ImgBox9.Image = Image.FromFile("imgs/cruz.png");
                                break;
                            default:
                                break;
                        }
                    }
                    else if (dato == 'O')
                    {
                        switch (i)
                        {
                            case 0:
                                ImgBox1.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 1:
                                ImgBox2.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 2:
                                ImgBox3.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 3:
                                ImgBox4.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 4:
                                ImgBox5.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 5:
                                ImgBox6.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 6:
                                ImgBox7.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 7:
                                ImgBox8.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            case 8:
                                ImgBox9.Image = Image.FromFile("imgs/circulo.png");
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Error en la comunicacion");
            }
        }
        public void reset()
        {
            ImgBox1.Image = Image.FromFile("imgs/vacio.png");
            ImgBox2.Image = Image.FromFile("imgs/vacio.png");
            ImgBox3.Image = Image.FromFile("imgs/vacio.png");
            ImgBox4.Image = Image.FromFile("imgs/vacio.png");
            ImgBox5.Image = Image.FromFile("imgs/vacio.png");
            ImgBox6.Image = Image.FromFile("imgs/vacio.png");
            ImgBox7.Image = Image.FromFile("imgs/vacio.png");
            ImgBox8.Image = Image.FromFile("imgs/vacio.png");
            ImgBox9.Image = Image.FromFile("imgs/vacio.png");
            Tablero.Reset();
        }
        private void ImgBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox1);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox2);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox3);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox4);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox5);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox6_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox6);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox7_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox7);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox8_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox8);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ImgBox9_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente.Conectado)
                {
                    Tablero.CargarCuadro(ImgBox9);
                    EnviarMensaje();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Comprobar(string signo)
        {
            string opuesto=signo;//solo le asigno un valor de inicio
            if (signo == "X")
            {
                opuesto = "O";
            }
            if (signo == "O")
            {
                opuesto = "X";
            }
            if (Tablero.Win(signo, Tablero.matriz))
            {
                Tablero.matriz = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
                MessageBox.Show("¡¡" + textBox1.Text + ", GANASTE!!");
                reset();
            }
            else if (Tablero.Win(opuesto, Tablero.matriz))
            {
                Tablero.matriz = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
                MessageBox.Show("" + textBox1.Text + ", PERDISTE.");
                reset();
            }
        }
        private void Log(string texto)
        {
            Invoke((Action)delegate
            {
                txtLog.Text = texto;
            });
        }
        private void Cliente_DatosRecibidos(object sender, DatosRecibidosEventArgs e)
        {
            try
            {
                Log(e.DatosRecibidos);
                Tablero.Turno = true;
                Comprobar(Tablero.Primer);
                CargarPiezas(e.DatosRecibidos);
                Tablero.CargarMatriz(e.DatosRecibidos);
                if (e.DatosRecibidos == "---------")
                {
                    reset();
                }
                else
                {
                    Tablero.CargarMatriz(e.DatosRecibidos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        private void Cliente_ConexionTerminada(object sender, EventArgs e)
        {
            Log("Finalizó la conexión");
            UpdateUI();
        }
        private void EnviarMensaje()
        {
            try
            {
                Comprobar(Tablero.Primer);
                cliente.EnviarDatos(Tablero.ToString());
                Tablero.Turno = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateUI()
        {
            Invoke((Action)delegate{
                txtIP.Enabled = txtPuerto.Enabled = btnConectar.Enabled = !cliente.Conectado;
                if (cliente.Conectado)
                {
                    Text = "Cliente (Conectado)";
                }
                else
                {
                    Text = "Cliente (Sin Conexion)";
                }
            });
        }
        private void BtnConectar_Click_1(object sender, EventArgs e)
        {
            int puerto;
            if (!int.TryParse(txtPuerto.Text, out puerto))
            {
                MessageBox.Show("El puerto ingresado no es válido", Text);
                return;
            }
            string ip = txtIP.Text;

            cliente.Conectar(ip, puerto);
            Log($"IP = {cliente.RemoteEndPoint.Address}: {cliente.RemoteEndPoint.Port}");

            UpdateUI();
            reset();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            cliente.ConexionTerminada += Cliente_ConexionTerminada;
            cliente.DatosRecibidos += Cliente_DatosRecibidos;

            label2.Text = nombre;
            Tablero.Reset();
            //Tamaños fijos porque al cambiar a otra pantalla la imagen modifica su tamaño, con esto forzamos a que tenga un tamaño fijo
            Width = 672;
            Height = 590;
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            reset();
            cliente.EnviarDatos(Tablero.ToString());
            Tablero.SetEstado(0);
        }
    }
}
