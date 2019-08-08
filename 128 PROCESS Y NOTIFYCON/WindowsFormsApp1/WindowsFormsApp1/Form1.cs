using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opennotepad_Click(object sender, EventArgs e)
        {
            proceso.EnableRaisingEvents = true;
            proceso.Start();
            lblEstado.Text = "notepad abierto";
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            proceso.Kill();
        }

        private void proceso_Exited(object sender, EventArgs e)
        {
            lblEstado.Text = "notepad cerrado";
            notifyIcon1.ShowBalloonTip(100, "TIP TITLE ES ESTO", "TIP TEXT ES ESTO", ToolTipIcon.Info);
        }

        private void aBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cIERRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
