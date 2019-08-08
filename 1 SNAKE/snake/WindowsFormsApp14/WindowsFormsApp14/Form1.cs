using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        queue head;
        Food food;
        int xdir = 0,ydir = 0,cuadro = 10,score = 0;
        Boolean ejeX = true,ejeY = true;
        public Form1()
        {
            InitializeComponent();
            head = new queue(375, 180);
            food = new Food(canvas.Width, canvas.Height);
            graphics = canvas.CreateGraphics(); //crear dibujo
        }
        public void moveXY()
        {
            head.SetXY(head.viewX() + xdir, head.viewY() + ydir); //x && y de move
        }
        private void bucle_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.LightBlue);
            head.draw(graphics);
            food.DrawFood(graphics);
            moveXY();
            PUM();
            PUMwall();
            if (head.interseccion(food))
            {
                food.Newlocation(canvas.Width, canvas.Height);
                head.add();
                score++;
                
                if (bucle.Interval != 1)
                {
                    bucle.Interval--;
                }
                points.Text = (score).ToString();
            } 
        }
        public void ResetGame()
        {
            bucle.Interval = 100;
            ejeX = true;
            ejeY = true;
            xdir = 0;
            ydir = 0;
            head = new queue(375, 180);
            score = 0;
            points.Text = "0";
        }
        public void PUM()
        {
            queue temp;
            try {
                temp = head.getNext().getNext();

            } catch (Exception err){
                temp = null;
            }
            while(temp != null)
            {
                if(head.interseccion(temp))
                {
                    GameOver();
                }
                else
                {
                    temp = temp.getNext();
                }

            }
        }
        public void PUMwall()
        {
            if(head.viewX() < 0 || head.viewX() > canvas.Width - 10 || head.viewY() < 0 || head.viewY() > canvas.Height - 10) //ancho de canvas menos nuestro objecto
            {
                GameOver();
            }
        }
        public void GameOver()
        {
            
            ejeX = true;
            ejeY = true;
            xdir = 0;
            ydir = 0;
            head = new queue(375, 180);
            food = new Food(canvas.Width, canvas.Height);
            MessageBox.Show("perdio, su puntaje fue de " + score);
            score = 0;
            points.Text = "0";
            var confirmResult = MessageBox.Show("desea jugar de vuelta","reset",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ResetGame();
            }else if(confirmResult == DialogResult.No)
            {
                this.Dispose();
            }


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(ejeX)
            {
                if(e.KeyCode == Keys.W)
                {
                    ydir = -cuadro;
                    xdir = 0;
                    ejeX = false;
                    ejeY = true;
                }
                if (e.KeyCode == Keys.S)
                {
                    ydir = cuadro;
                    xdir = 0;
                    ejeX = false;
                    ejeY = true;
                }
            }
            if(ejeY)
            {
                if (e.KeyCode == Keys.D)
                {
                    ydir = 0;
                    xdir = cuadro;
                    ejeX = true;
                    ejeY = false;
                }
                if (e.KeyCode == Keys.A)
                {
                    ydir = 0;
                    xdir = -cuadro;
                    ejeX = true;
                    ejeY = false;
                }
            }

        }


    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
