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

namespace TaTeTi_Grafico
{
    public partial class Form1 : Form
    {
        private Servidor servidor;
        private int contador;
        private string[] matriz = new string[9];
        public Cuadro Tablero = new Cuadro();
        private string nombre;
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
                    if (dato == 'O')
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
        private void ImgBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
                if (servidor.Conexion())
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
        public string Nombre
        {
            set
            {
                nombre = value;
            }
        }
        private void Log(string texto)
        {
            Invoke((Action)delegate
            {
                txtLog.Text=texto;
            });
        }
        private void Servidor_NuevaConexion(object sender, ServidorEventArgs e)
        {
            Log($"IP = {e.EndPoint.Address} :{e.EndPoint.Port}");
            Tablero.SetEstado(1);
        }
        private void Servidor_ConexionTerminada(object sender, ServidorEventArgs e)
        {
            Log($"IP = {e.EndPoint.Address} :{e.EndPoint.Port}");
        }
        private void Servidor_DatosRecibidos(object sender, DatosRecibidosEventArgs e)
        {
            try
            {
                Log(e.DatosRecibidos);
                Tablero.Turno = true;
                Comprobar(Tablero.Primer);
                Tablero.CargarMatriz(e.DatosRecibidos);
                CargarPiezas(e.DatosRecibidos);
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
        private void EnviarMensaje()
        {
            try
            {
                Comprobar(Tablero.Primer);
                servidor.EnviarDatos(Tablero.ToString());
                Tablero.Turno = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            EnviarMensaje();
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
        public void Comprobar(string signo)
        {
            string opuesto = signo;//solo le asigno un valor de inicio
            if (signo == "X")
            {
                opuesto = "O";
            }
            else if (signo == "O")
            {
                opuesto = "X";
            }
            if (Tablero.Win(signo, Tablero.matriz))
            {
                Tablero.matriz = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
                MessageBox.Show("¡¡"+textBox1.Text+", GANASTE!!"); reset();
            }
            else if (Tablero.Win(opuesto, Tablero.matriz))
            {
                Tablero.matriz = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
                MessageBox.Show("" + textBox1.Text + ", PERDISTE.");
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            servidor = new Servidor(8050);
            servidor.NuevaConexion += Servidor_NuevaConexion;
            servidor.ConexionTerminada += Servidor_ConexionTerminada;
            servidor.DatosRecibidos += Servidor_DatosRecibidos;

            servidor.Escuchar();
            Tablero.Reset();
            //Tamaños fijos porque al cambiar a otra pantalla la imagen modifica su tamaño, con esto forzamos a que tenga un tamaño fijo
            Width = 660;
            Height = 580;
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            reset();
            servidor.EnviarDatos(Tablero.ToString());
            Tablero.SetEstado(1);
        }
    }
}
