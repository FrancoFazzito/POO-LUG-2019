using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANDLER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "se apreto el boton ";
            if(((Button)sender).Name == "button1")
            {
                MessageBox.Show("boton 1");
                checkBox1.Checked = true;
                ((Button)sender).Text = "oprimido";
                label1.Text = ((Button)sender).Text;
            }
            if (((Button)sender).Name == "button2")
            {
                MessageBox.Show("boton 2");
                checkBox2.Checked = true;
            }
            if (((Button)sender).Name == "button3")
            {
                MessageBox.Show("boton 3");
                checkBox3.Checked = true;
            }
        }
    }
}
