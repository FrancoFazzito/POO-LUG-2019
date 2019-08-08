using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlesdinamicos
{
    public partial class Form1 : Form
    {
        private int y = 50;
        private int countBotones = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //instancia
            Button temp = new Button();
            //props
            temp.Width = 100;
            temp.Height = 30;
            temp.Location = new Point(50, y);
            y += 25;
            temp.Name = "boton" + countBotones.ToString();
            temp.Text = "boton #" + countBotones.ToString();
            countBotones++;
            //handlers
            temp.Click += new EventHandler(handler);
            //añadimos a la forma mediante controls
            Controls.Add(temp);
        }

        private void handler(object sender, EventArgs e)
        {
            int numero = ((Button)sender).Location.Y * 10;
            label1.Text = numero.ToString();
        }
    }
}
