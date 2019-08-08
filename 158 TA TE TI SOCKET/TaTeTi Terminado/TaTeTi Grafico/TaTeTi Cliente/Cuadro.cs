using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaTeTi_Cliente
{
    public class Cuadro
    {
        private bool flag = false;
        private int contador;
        private bool first = true;
        public string Primer;
        public string[] matriz { get; set; } = new string[9];
      
        public Cuadro()
        {
            Reset();
        }
        public bool Win(string dato, string[] tablero)
        {
            if (tablero[0] == dato && tablero[3] == dato && tablero[6] == dato ||
                tablero[1] == dato && tablero[4] == dato && tablero[7] == dato ||
                tablero[2] == dato && tablero[5] == dato && tablero[8] == dato ||
                tablero[0] == dato && tablero[1] == dato && tablero[2] == dato ||
                tablero[3] == dato && tablero[4] == dato && tablero[5] == dato ||
                tablero[6] == dato && tablero[7] == dato && tablero[8] == dato ||
                tablero[0] == dato && tablero[4] == dato && tablero[8] == dato ||
                tablero[6] == dato && tablero[4] == dato && tablero[2] == dato)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CargarMatriz(string datos)
        {
            string[] info = new string[9];
            if (datos.Length >= 9)
            {
                for (int i = 0; i < datos.Length; i++)
                {
                    info[i] = datos.ElementAt<char>(i).ToString();
                }
                matriz = info;
            }
        }
        public string[] CargarCuadro(PictureBox Imagen)
        {
            int indice = ObtenerIndice(Imagen);
            if (flag)
            {
                if (matriz[indice] == "-")
                {
                    int turno = Contador;
                    
                    if (contador <= 9)
                    {
                        if (turno % 2 == 0)
                        {
                            Imagen.Image = Image.FromFile("imgs/cruz.png");
                            matriz[indice] = "X";
                            if (first){
                                Primer = "X";
                                first = false;
                            }
                            return matriz;
                        }
                        else
                        {
                            Imagen.Image = Image.FromFile("imgs/circulo.png");
                            matriz[indice] = "O";
                            if (first)
                            {
                                Primer = "O";
                                first = false;
                            }
                            return matriz;
                        }
                    }
                    else
                    {
                        return matriz;
                    }
                }
                else
                {
                    throw new Exception("Esa posicion ya esta ocupada");
                }
            }
            else
            {
                throw new Exception("No es tu turno");
            }
        }
        private int ObtenerIndice(PictureBox Posicion)
        {
            string nombre = Posicion.Name.ToString();
            int pos = nombre.Length - 1;
            return int.Parse(nombre.Substring(pos)) - 1;
        }
        public void Reset()
        {
            matriz = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-" };
            first = true;
            Turno = true;
            contador = 1;
        }
        public int Contador
        {
            get
            {
                return contador;
            }
            set
            {
                contador = value;
            }
        }
        public bool Turno
        {
            set
            {
                flag = value;
                contador++;
            }
        }
        public override string ToString()
        {
            string cadena = "";
            for (int i = 0; i < 9; i++)
            {
                cadena = cadena +matriz[i];
            }
            return cadena;
        }
        internal void SetEstado(int val)
        {
            Turno = true;
            contador = val;
        }
    }
}
