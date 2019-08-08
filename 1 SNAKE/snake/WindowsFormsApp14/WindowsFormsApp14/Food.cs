using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp14
{
    class Food : objectAll
    {
        
        public Food(int width, int height)
        {
            this.x = GenRndFood(width/10); //ancho canvas por 10 luego
            this.y = GenRndFood(height/10); //largue canvas por 10 luego
        }
        public void DrawFood(Graphics graphics)
        {
            graphics.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.ancho, this.ancho);
        }
        public int GenRndFood(int N)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int num = (rnd.Next(0, N) * 10)+ 1;
            return num;
        }
        public void Newlocation(int width, int height)
        {
            this.x = GenRndFood(width / 10); //ancho canvas por 10 luego 
            this.y = GenRndFood(height / 10); //largue canvas por 10 luego
        }
    }
}
