using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using INTERFACES;
using NEGOCIO;
using ENTIDADES;

namespace CONTROLLER
{
    public class ControllerCliente : IABMC
    {
        private Form formCliente;
        private GestorCliente gestorCliente;
        
        public ControllerCliente(Form formCliente)
        {
            this.formCliente = formCliente;
            gestorCliente = new GestorCliente();
            gestorCliente.eventoDiez += GestorCliente_eventoDiez;
        }

        private void GestorCliente_eventoDiez(object sender, EventArgs e)
        {
            MessageBox.Show("SE HA CARGADO UN 10");
        }

        public void Alta()
        {
            TextBox textBoxId = formCliente.Controls[FormControl.id] as TextBox;
            int id = int.Parse(textBoxId.Text);

            TextBox textBoxNombre = formCliente.Controls[FormControl.nombre] as TextBox;
            string nombre = textBoxNombre.Text;

            Cliente cliente = new Cliente(id, nombre);
            gestorCliente.Alta(cliente);
        }

        public void Baja()
        {
            DataGridView datagrid = formCliente.Controls[FormControl.dgv] as DataGridView;
            Cliente cliente = datagrid.SelectedRows[0].DataBoundItem as Cliente;
            gestorCliente.Baja(cliente);
        }

        public void Consultar()
        {
            DataGridView datagrid = formCliente.Controls[FormControl.dgv] as DataGridView;
            datagrid.DataSource = null;
            datagrid.DataSource = gestorCliente.Consultar();
        }

        public void ConsultarFiltro()
        {
            throw new NotImplementedException();
        }

        public void Modificacion()
        {
            DataGridView datagrid = formCliente.Controls[FormControl.dgv] as DataGridView;
            Cliente clienteDGV = datagrid.SelectedRows[0].DataBoundItem as Cliente;
            int id = clienteDGV.Id;

            TextBox textBoxNombre = formCliente.Controls[FormControl.nombre] as TextBox;
            string nombre = textBoxNombre.Text;

            Cliente cliente = new Cliente(id, nombre);
            gestorCliente.Modificacion(cliente);
        }

        public void DibujarTorta()
        {
            List<Cliente> listado = gestorCliente.Consultar();
            List<int> datos = new List<int>();
            int count3 = listado.Count(cliente => cliente.Id <= 3);
            int count6 = listado.Count(cliente => cliente.Id >= 6);
            int count9 = listado.Count(cliente => cliente.Id >= 9);

            datos.Add(count3);
            datos.Add(count6);
            datos.Add(count9);

            Graphics g = this.formCliente.CreateGraphics();
            g.Clear(Color.Beige);

            Pen p = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Azure);

            Rectangle rec = new Rectangle(230, 360, 280, 240);
            g.DrawRectangle(p, rec);

            float suma = datos.Sum();
            float acumulador = 0;

            foreach (var num in datos)
            {
                float grados = (num / suma) * 360;
                g.DrawPie(p, rec, acumulador, grados);
                g.FillPie(brush, rec, acumulador, grados);
                acumulador += grados;
            }
            g.Dispose();
        }

        public void DibujarBarra()
        {
            List<Cliente> listado = gestorCliente.Consultar();
            List<int> datos = new List<int>();
            int count3 = listado.Count(cliente => cliente.Id <= 3);
            int count6 = listado.Count(cliente => cliente.Id >= 6);
            int count9 = listado.Count(cliente => cliente.Id >= 9);

            datos.Add(count3);
            datos.Add(count6);
            datos.Add(count9);

            Graphics g = this.formCliente.CreateGraphics();
            g.Clear(Color.Beige);

            Pen p = new Pen(Color.Black, 2);
            SolidBrush brush = new SolidBrush(Color.Azure);

            Rectangle rec = new Rectangle(10, 360, 212, 240);
            g.DrawRectangle(p, rec);

            int max = datos.Max();
            int x = 11;
            int ancho = 10;
            int multiAlto = 150;
            int maximoAlto = 600;

            foreach (int num in datos)
            {
                int alto = num * multiAlto / max;
                g.FillRectangle(Brushes.Azure, x, maximoAlto - alto, ancho, alto);
                g.DrawRectangle(Pens.Black, x, maximoAlto - alto, ancho, alto);
                x += 30;
            }
        }
    }

    public static class FormControl
    {
        public const string id = "txt_id";
        public const string nombre = "txt_nombre";
        public const string dgv = "dgv_cliente";
        public const string control = "control_seguridad"; 
    }
}
