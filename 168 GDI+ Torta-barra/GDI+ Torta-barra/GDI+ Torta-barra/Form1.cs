using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GDI__Torta_barra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>();

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);

            numeros.Add(num1);
            numeros.Add(num2);
            numeros.Add(num3);

            float total = numeros.Sum();


            Graphics g = this.CreateGraphics();
            Random random = new Random(DateTime.Now.Millisecond);
            Pen p = new Pen(Color.Black, 1);

            Rectangle rec = new Rectangle(50, 12, 150, 150);
            g.DrawRectangle(p, rec);

            float sum = 0;
            foreach (int num in numeros)
            {
                float deg = (num / total) * 360;

                Brush color = new SolidBrush(Color.FromArgb(random.Next(0, 255), Color.FromArgb(random.Next(0, 255), Color.FromArgb(random.Next(0, 255)))));
                g.DrawPie(p, rec, sum, deg);
                g.FillPie(color, rec, sum, deg);
                sum += deg;
            }

            g.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>();

            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);

            numeros.Add(num1);
            numeros.Add(num2);
            numeros.Add(num3);

            Graphics g = this.CreateGraphics();
            Random random = new Random(DateTime.Now.Millisecond);
            Pen p = new Pen(Color.Black, 1);

            Rectangle rec = new Rectangle(50, 175, 150, 125);
            g.DrawRectangle(p, rec);
            int sum = numeros.Sum();
            int desplazamientoX = 0;
            int ancho = 30;
            foreach (int num in numeros)
            {
                int altoDibujo = num * 300 / sum;
                Brush color = new SolidBrush(Color.FromArgb(random.Next(0, 255), Color.FromArgb(random.Next(0, 255), Color.FromArgb(random.Next(0, 255)))));
                g.FillRectangle(color, 50 + desplazamientoX, 300 - altoDibujo, ancho, altoDibujo);
                desplazamientoX += 50;
            }

            g.Dispose();
        }
    }
}
