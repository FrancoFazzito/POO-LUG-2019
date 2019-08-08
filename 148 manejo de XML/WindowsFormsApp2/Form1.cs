<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xdoc;
        string path;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xdoc = new XmlDocument();
                path = openFileDialog.FileName;
                xdoc.Load(path);
                //MessageBox.Show(xdoc.SelectSingleNode("people/person/name").InnerText);

                textBox1.Text = xdoc.SelectSingleNode("people/person/name").InnerText;
                textBox2.Text = xdoc.SelectSingleNode("people/person/age").InnerText;
                textBox3.Text = xdoc.SelectSingleNode("people/person/email").InnerText;
                listView1.Items.Clear();
                foreach (XmlNode item in xdoc.SelectNodes("people/person"/*busqueda en el arbol*/))
                {                 
                    listView1.Items.Add(item.SelectSingleNode("name" /*atributo*/).InnerText + " " +item.SelectSingleNode("age" /*atributo*/).InnerText + " " + item.SelectSingleNode("email" /*atributo*/).InnerText);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xdoc.SelectSingleNode("people/person/name").InnerXml = textBox6.Text;
            xdoc.SelectSingleNode("people/person/age").InnerXml = textBox4.Text;
            xdoc.SelectSingleNode("people/person/email").InnerXml = textBox5.Text;
            xdoc.Save(path);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            xdoc.Load(path);
            XmlNode persona = xdoc.CreateElement("person");

            XmlNode name = xdoc.CreateElement("name");
            name.InnerText = "ejemplo";
            persona.AppendChild(name);

            XmlNode age = xdoc.CreateElement("age");
            age.InnerText = "15";
            persona.AppendChild(age);

            XmlNode email = xdoc.CreateElement("email");
            email.InnerText = "franco@gmail.com";
            persona.AppendChild(email);

            xdoc.DocumentElement.AppendChild(persona);
            xdoc.Save(path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xdoc.Load(path);
            foreach (XmlNode Xnode in xdoc.SelectNodes("people/person"))
            {
                if(Xnode.SelectSingleNode("name").InnerText == "ejemplo")
                {
                    //item.RemoveAll();
                    Xnode.ParentNode.RemoveChild(Xnode);
                }
            }
            xdoc.Save(path);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            xdoc.Load(path);
            listView1.Items.Clear();
            foreach (XmlNode item in xdoc.SelectNodes("people/person"))
            {
                listView1.Items.Add(item.SelectSingleNode("name").InnerText 
                                    + " " + 
                                    item.SelectSingleNode("age").InnerText 
                                    + " " + 
                                    item.SelectSingleNode("email").InnerText
                                    );
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("books.xml");
            writer.WriteStartElement("book");
            writer.WriteElementString("title", "Graphics Programming using GDI+");
            writer.WriteElementString("author", "Mahesh Chand");
            writer.WriteElementString("publisher", "Addison-Wesley");
            writer.WriteElementString("price", "64.95");
            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xdoc;
        string path;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xdoc = new XmlDocument();
                path = openFileDialog.FileName;
                xdoc.Load(path);
                //MessageBox.Show(xdoc.SelectSingleNode("people/person/name").InnerText);

                textBox1.Text = xdoc.SelectSingleNode("people/person/name").InnerText;
                textBox2.Text = xdoc.SelectSingleNode("people/person/age").InnerText;
                textBox3.Text = xdoc.SelectSingleNode("people/person/email").InnerText;
                listView1.Items.Clear();
                foreach (XmlNode item in xdoc.SelectNodes("people/person"/*busqueda en el arbol*/))
                {                 
                    listView1.Items.Add(item.SelectSingleNode("name" /*atributo*/).InnerText + " " +item.SelectSingleNode("age" /*atributo*/).InnerText + " " + item.SelectSingleNode("email" /*atributo*/).InnerText);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xdoc.SelectSingleNode("people/person/name").InnerXml = textBox6.Text;
            xdoc.SelectSingleNode("people/person/age").InnerXml = textBox4.Text;
            xdoc.SelectSingleNode("people/person/email").InnerXml = textBox5.Text;
            xdoc.Save(path);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            xdoc.Load(path);
            XmlNode persona = xdoc.CreateElement("person");

            XmlNode name = xdoc.CreateElement("name");
            name.InnerText = "ejemplo";
            persona.AppendChild(name);

            XmlNode age = xdoc.CreateElement("age");
            age.InnerText = "15";
            persona.AppendChild(age);

            XmlNode email = xdoc.CreateElement("email");
            email.InnerText = "franco@gmail.com";
            persona.AppendChild(email);

            xdoc.DocumentElement.AppendChild(persona);
            xdoc.Save(path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xdoc.Load(path);
            foreach (XmlNode Xnode in xdoc.SelectNodes("people/person"))
            {
                if(Xnode.SelectSingleNode("name").InnerText == "ejemplo")
                {
                    //item.RemoveAll();
                    Xnode.ParentNode.RemoveChild(Xnode);
                }
            }
            xdoc.Save(path);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            xdoc.Load(path);
            listView1.Items.Clear();
            foreach (XmlNode item in xdoc.SelectNodes("people/person"))
            {
                listView1.Items.Add(item.SelectSingleNode("name").InnerText 
                                    + " " + 
                                    item.SelectSingleNode("age").InnerText 
                                    + " " + 
                                    item.SelectSingleNode("email").InnerText
                                    );
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("books.xml");
            writer.WriteStartElement("book");
            writer.WriteElementString("title", "Graphics Programming using GDI+");
            writer.WriteElementString("author", "Mahesh Chand");
            writer.WriteElementString("publisher", "Addison-Wesley");
            writer.WriteElementString("price", "64.95");
            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
        }
    }
}
>>>>>>> 7f85a414ed6b84bdf726a283e9468a6c5e3979f0
