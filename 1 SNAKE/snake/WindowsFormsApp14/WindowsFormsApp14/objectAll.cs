using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp14
{
    class objectAll //tipo abstracto 
    {
        protected int x, y, ancho; //solo acceden aquellas que heredan //ver si se puede de 
        public objectAll()
        {
            ancho = 10;
        }
        public Boolean interseccion(objectAll o)
        {
            int difx = Math.Abs(this.x - o.x); //calcular posiciones iguales
            int dify = Math.Abs(this.y - o.y);
            if (difx >= 0 && difx < ancho && dify >= 0 && dify < ancho)
            {
                return true;
            }else{
                return false;
            }
        }
    }
}
