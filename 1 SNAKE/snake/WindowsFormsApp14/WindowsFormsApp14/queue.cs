using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    class queue : objectAll
    {
        queue next;
        public queue(int x, int y)
        {
            this.x = x;
            this.y = y;
            next = null;
        }
        public void draw(Graphics graphics)
        {
            if(next != null)
            {
                next.draw(graphics);
            }
            graphics.FillRectangle(new SolidBrush(Color.Black), this.x, this.y, this.ancho, this.ancho);
        }
        public void add() //recursiva para meter
        {
            if(next == null)
            {
                next = new queue(this.x, this.y);
            }
            else
            {
                next.add();
            }
        }
        public void SetXY(int x, int y)
        {
            if (next != null)
            {
                next.SetXY(this.x, this.y); //x && y viejos
            }
            this.x = x;
            this.y = y;
        }
        public int viewY()
        {
            return this.y;
        }
        public int viewX()
        {
            return this.x;
        }
        public queue getNext()
        {
            return next;
        }
    }
}
