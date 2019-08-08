using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    class Program
    {
        public enum Tipoimagen { BMP,JPG,PNG,GIF,TIFF}
        static void Main(string[] args)
        {
            Console.WriteLine(Tipoimagen.TIFF);
            Console.WriteLine(Tipoimagen.BMP);
            Console.WriteLine(Tipoimagen.JPG);
            Console.WriteLine(Tipoimagen.PNG);
            Console.WriteLine(Tipoimagen.GIF);
            /*el usuario solo ve los datos validos*/
            Console.WriteLine(Convert.ToInt32(Tipoimagen.TIFF));
            Console.WriteLine(Convert.ToInt32(Tipoimagen.BMP));
            Console.WriteLine(Convert.ToInt32(Tipoimagen.JPG));
            Console.WriteLine(Convert.ToInt32(Tipoimagen.PNG));
            Console.WriteLine(Convert.ToInt32(Tipoimagen.GIF));
            /*SNIPPETS ALT T*/
             /*cada uno tiene un equivalente entero*/
            Console.ReadKey();
        }
    }
}
