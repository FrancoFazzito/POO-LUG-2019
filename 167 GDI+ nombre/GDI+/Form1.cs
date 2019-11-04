using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        private int X = 0;
        private int Y = 0;

        public Form1()
        {
            InitializeComponent();
            //invalidate llama a paint cada vez que necesitemos
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dibujarString();
        }

        private void dibujarString()
        {
            Graphics g = Graphics.FromHwnd(this.Handle); //metodo que es de paint
            Font fuente = new Font("Times new roman", 30);
            string palabra = textBox1.Text;
            g.DrawString(palabra, fuente, Brushes.Black, new Point(200, 200));
            g.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //escribirString(e);
            //escribirArco(e);
            Graphics g = e.Graphics;
            DibujarF(g);
            DibujarR(g);
            DibujarA(g);
            DibujarN(g);
            DibujarC(g);
            DibujarO(g);
        }

        private static void DibujarO(Graphics g)
        {
            Rectangle rectangle = new Rectangle(350, 100, 100, 100);
            g.DrawEllipse(Pens.Crimson, rectangle);
        }

        private static void DibujarC(Graphics g)
        {
            Point[] points = new Point[] { new Point(350, 100), new Point(305, 150), new Point(350, 200) };
            g.DrawCurve(Pens.DimGray, points);
        }

        private static void DibujarN(Graphics g)
        {
            Point[] puntosIzquierda = new Point[] { new Point(250, 100), new Point(250, 200) };
            g.DrawLines(Pens.Brown, puntosIzquierda);
            Point[] puntosMedio = new Point[] { new Point(250, 100), new Point(300, 200) };
            g.DrawLines(Pens.Brown, puntosMedio);
            Point[] puntosDerecha = new Point[] { new Point(300, 100), new Point(300, 200) };
            g.DrawLines(Pens.Brown, puntosDerecha);
        }

        private static void DibujarA(Graphics g)
        {
            Point[] puntosIzquierda = new Point[] { new Point(225, 100), new Point(200, 200) };
            g.DrawLines(Pens.Red, puntosIzquierda);
            Point[] puntosDerecha = new Point[] { new Point(225, 100), new Point(250, 200) };
            g.DrawLines(Pens.Red, puntosDerecha);
            Point[] puntosMedio = new Point[] { new Point(212, 150), new Point(237, 150) };
            g.DrawLines(Pens.Red, puntosMedio);
        }

        private static void DibujarR(Graphics g)
        {
            g.DrawLine(Pens.Black,/*x inicio*/150,/*y inicio*/100,/*x final*/150,/*y final*/200);
            g.DrawLine(Pens.Black,/*x inicio*/150,/*y inicio*/150,/*x final*/200,/*y final*/200);
            Rectangle area = new Rectangle(150, 100, 50, 50);
            g.DrawRectangle(Pens.Black, area);
        }

        private static void DibujarF(Graphics g)
        {
            g.DrawLine(Pens.Blue,/*x inicio*/100,/*y inicio*/100,/*x final*/100,/*y final*/200);
            g.DrawLine(Pens.Blue,/*x inicio*/100,/*y inicio*/100,/*x final*/150,/*y final*/100);
            g.DrawLine(Pens.Blue,/*x inicio*/100,/*y inicio*/150,/*x final*/130,/*y final*/150);
        }

        private static void escribirArco(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawArc(Pens.Coral, new Rectangle(50, 50, 100, 100), 45, 180);
        }

        private void escribirString(PaintEventArgs e)
        {
            Graphics g = e.Graphics; //metodo que es de paint
            Font fuente = new Font("Times new roman", 30);
            string palabra = textBox1.Text;
            g.DrawString(palabra, fuente, Brushes.Green, new Point(X, Y));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            invalidar();
            //Invalidate(new Rectangle(0, 0, 120, 120)); muestra un rectangulo donde actualizar 
        }

        private void invalidar()
        {
            this.X += 10;
            this.Y += 10;
            Invalidate();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            escribirElipse();
        }

        private void escribirElipse()
        {
            Graphics g = Graphics.FromHwnd(this.Handle); //metodo que es de paint
            g.TranslateTransform(100, 100); //marca un nuevo origen 0 0

            Pen pen = new Pen(Brushes.Red, 10);
            g.DrawEllipse(pen, new Rectangle(0, 0, 50, 70));
            //g.PageUnit = GraphicsUnit.Pixel;
            g.Dispose();
        }

    }
}
