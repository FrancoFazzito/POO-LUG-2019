using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar
using USER_SETTINGS.Properties;

namespace USER_SETTINGS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = (string)/*type cast*/ Settings.Default["Valor1"];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["Valor1"] = textBox1.Text; //guarda
            Settings.Default.Save();
        }
    }
}
