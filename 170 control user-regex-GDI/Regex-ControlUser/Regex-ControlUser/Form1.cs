using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regex_ControlUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (prueba1.Validacion)
            {
                label1.Text = "CORRECTO";
            }
            else
            {
                label1.Text = "INCORRECTO";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //barras
            List<int> numeros = new List<int>();

            int dato1 = int.Parse(textBox1.Text);
            int dato2 = int.Parse(textBox2.Text);
            int dato3 = int.Parse(textBox3.Text);

            numeros.Add(dato1);
            numeros.Add(dato2);
            numeros.Add(dato3);

            Graphics g = this.CreateGraphics();
            g.Clear(Color.Gray); //limpio para redibujar arriba
            Random random = new Random(DateTime.Now.Millisecond);

            int max = numeros.Max();
            
            int x = 10;//posicion X
            int ancho = 20;//ancho

            int multiAlto = 50; //indica cuanto de alto se va multuplicar por cada valor
            int maximoAlto = 300; //indica cuanto se va a bajar respecto a la posicion

            foreach (int num in numeros)
            {
                int alto = num * multiAlto / max;
                g.FillRectangle(Brushes.Black, x, maximoAlto - alto, ancho, alto);
                x += 50;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //circulo 
            List<int> numeros = new List<int>();

            int dato1 = int.Parse(textBox1.Text);
            int dato2 = int.Parse(textBox2.Text);
            int dato3 = int.Parse(textBox3.Text);

            numeros.Add(dato1);
            numeros.Add(dato2);
            numeros.Add(dato3);

            Graphics g = this.CreateGraphics();
            g.Clear(Color.Gray); //limpio para redibujar arriba
            Random random = new Random(DateTime.Now.Millisecond);

            Pen p = new Pen(Color.Black, 1);
            Rectangle rec = new Rectangle(300, 10, 150, 150);
            g.DrawRectangle(p, rec);

            float sum = numeros.Sum();
            float acumulador = 0;

            foreach (int num in numeros)
            {
                float grados = (num / sum) * 360;

                g.DrawPie(p, rec, acumulador, grados);
                acumulador += grados;
            }
        }
    }
}
