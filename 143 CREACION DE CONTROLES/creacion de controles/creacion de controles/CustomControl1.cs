using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creacion_de_controles
{
    public partial class CustomControl1 : Control
    {
        private bool presionado = false;
        private bool activado = false;
        public CustomControl1()
        {
            InitializeComponent();
        }

        public bool Presionado
        {
            get => presionado; set
            {
                presionado = value;
                Invalidate();
            }
        }
        public bool Activado
        {
            get => activado;
            set
            {
                activado = value;
                Invalidate();
                /*generar el invalidate para que se redibuje*/
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //DAMOS CLICK PARA LA VISTA DE CODIGO
            Graphics g = pe.Graphics;
            //base.OnPaint(pe);
            Rectangle rect = ClientRectangle; //propiedad del area 
            rect.Width--;
            rect.Height--;
            g.FillRectangle(new SolidBrush(Parent.BackColor/*fondo de la ventana*/), ClientRectangle); //fondo del color
            Color color;
            if(presionado)
            {
                color = Color.Blue;
            }
            else
            {
                color = Color.Red;
            }
            g.FillEllipse(new SolidBrush(color), rect); //fondo
            Font fuente = new Font("arial", rect.Height * 0.5f, FontStyle.Italic);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            g.DrawString(Text, fuente, Brushes.Black, new Rectangle(rect.Left, rect.Top, rect.Width, rect.Height));
            if(activado)
            {
                g.FillEllipse(Brushes.Red, new Rectangle(rect.Left, rect.Top, rect.Width, rect.Height));
            }
            else
            {
                g.FillEllipse(Brushes.CadetBlue, new Rectangle(rect.Left, rect.Top, rect.Width, rect.Height));
            }
        }
        public new string Text //override de la clase padre 
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                presionado = true;
            }
            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                presionado = true;
            }
            Invalidate();
        }

    }
}
